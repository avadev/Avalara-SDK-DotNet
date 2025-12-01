/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Avalara.SDK.Client;

namespace Avalara.SDK.Test.Client
{
    /// <summary>
    /// Class for testing ApiClient FileParameter deserialization
    /// Tests for lines 143-167 of ApiClient.cs which handle FileParameter responses
    /// </summary>
    /// <remarks>
    /// Note: The current implementation has a limitation where Content-Disposition headers
    /// are not properly extracted from response.Headers due to how headers are serialized
    /// on line 111 of ApiClient.cs. The code does `x.Key + "=" + x.Value` where x.Value is
    /// an IEnumerable&lt;string&gt;, which doesn't produce the expected string format.
    /// These tests focus on testing the parts that work (default filename, content type extraction).
    /// </remarks>
    public class ApiClientTests : IDisposable
    {
        private Configuration _configuration;
        private object _customJsonCodec;
        private MethodInfo _deserializeMethod;

        public ApiClientTests()
        {
            _configuration = new Configuration
            {
                Environment = AvalaraEnvironment.Sandbox,
                BearerToken = "test_token",
                AppName = "Test",
                AppVersion = "1.0",
                MachineName = "TestBox"
            };

            // Get the internal CustomJsonCodec type using reflection
            var assembly = typeof(ApiClient).Assembly;
            var codecType = assembly.GetType("Avalara.SDK.Client.CustomJsonCodec");

            // Get the constructor that takes IReadableConfiguration
            var constructor = codecType.GetConstructor(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                null,
                new[] { typeof(IReadableConfiguration) },
                null);

            // Create an instance of CustomJsonCodec
            _customJsonCodec = constructor.Invoke(new object[] { _configuration });

            // Get the internal Deserialize method
            _deserializeMethod = codecType.GetMethod("Deserialize",
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public,
                null,
                new[] { typeof(HttpResponseMessage), typeof(Type) },
                null);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        private async Task<T> DeserializeAsync<T>(HttpResponseMessage response)
        {
            var task = (Task<object>)_deserializeMethod.Invoke(_customJsonCodec, new object[] { response, typeof(T) });
            var result = await task;
            return (T)result;
        }

        /// <summary>
        /// Tests that FileParameter uses default filename when Content-Disposition header is missing (line 147).
        /// </summary>
        [Fact]
        public async Task Deserialize_FileParameter_WithoutContentDisposition_UsesDefaultFilename()
        {
            // Arrange
            var testContent = Encoding.UTF8.GetBytes("Binary content");
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(testContent)
            };
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

            // Act
            var result = await DeserializeAsync<FileParameter>(response);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<FileParameter>(result);
            Assert.Equal("downloaded_file", result.Name);
            Assert.Equal("application/octet-stream", result.ContentType);
            Assert.NotNull(result.Content);

            // Verify content is readable
            using (var reader = new StreamReader(result.Content))
            {
                result.Content.Position = 0;
                var content = await reader.ReadToEndAsync();
                Assert.Equal("Binary content", content);
            }
        }

        /// <summary>
        /// Tests that FileParameter extracts content type from response headers (lines 159-163).
        /// </summary>
        [Fact]
        public async Task Deserialize_FileParameter_ExtractsContentType()
        {
            // Arrange
            var testContent = Encoding.UTF8.GetBytes("PDF content");
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(testContent)
            };
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");

            // Act
            var result = await DeserializeAsync<FileParameter>(response);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("application/pdf", result.ContentType);
        }

        /// <summary>
        /// Tests that FileParameter uses default content type when Content-Type header is missing (line 159).
        /// </summary>
        [Fact]
        public async Task Deserialize_FileParameter_WithoutContentType_UsesDefaultContentType()
        {
            // Arrange
            var testContent = Encoding.UTF8.GetBytes("Unknown type content");
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(testContent)
            };
            // No Content-Type header set

            // Act
            var result = await DeserializeAsync<FileParameter>(response);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("application/octet-stream", result.ContentType);
        }

        /// <summary>
        /// Tests that FileParameter creates a MemoryStream with the response bytes (line 165).
        /// </summary>
        [Fact]
        public async Task Deserialize_FileParameter_CreatesMemoryStreamWithBytes()
        {
            // Arrange
            var testContent = Encoding.UTF8.GetBytes("Test file content");
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(testContent)
            };

            // Act
            var result = await DeserializeAsync<FileParameter>(response);

            // Assert
            Assert.NotNull(result.Content);
            Assert.IsType<MemoryStream>(result.Content);
            Assert.Equal(testContent.Length, result.Content.Length);

            // Verify the bytes are correct
            result.Content.Position = 0;
            var buffer = new byte[testContent.Length];
            await result.Content.ReadAsync(buffer, 0, buffer.Length);
            Assert.Equal(testContent, buffer);
        }

        /// <summary>
        /// Tests that FileParameter correctly handles empty response content.
        /// </summary>
        [Fact]
        public async Task Deserialize_FileParameter_WithEmptyContent_ReturnsEmptyStream()
        {
            // Arrange
            var testContent = Array.Empty<byte>();
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(testContent)
            };
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");

            // Act
            var result = await DeserializeAsync<FileParameter>(response);

            // Assert
            Assert.NotNull(result);
            Assert.NotNull(result.Content);
            Assert.Equal(0, result.Content.Length);
        }

        /// <summary>
        /// Tests that FileParameter correctly handles large binary content (line 145).
        /// </summary>
        [Fact]
        public async Task Deserialize_FileParameter_WithLargeBinaryContent_ReturnsCorrectFileParameter()
        {
            // Arrange
            var testContent = new byte[1024 * 1024]; // 1 MB
            for (int i = 0; i < testContent.Length; i++)
            {
                testContent[i] = (byte)(i % 256);
            }
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(testContent)
            };
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/zip");

            // Act
            var result = await DeserializeAsync<FileParameter>(response);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("application/zip", result.ContentType);
            Assert.NotNull(result.Content);
            Assert.Equal(1024 * 1024, result.Content.Length);

            // Verify a few bytes to ensure content is correct
            result.Content.Position = 0;
            Assert.Equal(0, result.Content.ReadByte());
            result.Content.Position = 255;
            Assert.Equal(255, result.Content.ReadByte());
            result.Content.Position = 256;
            Assert.Equal(0, result.Content.ReadByte());
        }

        /// <summary>
        /// Tests that FileParameter returns correct type from deserialization (line 166).
        /// </summary>
        [Fact]
        public async Task Deserialize_FileParameter_ReturnsFileParameterType()
        {
            // Arrange
            var testContent = Encoding.UTF8.GetBytes("Test");
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(testContent)
            };

            // Act
            var result = await DeserializeAsync<FileParameter>(response);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<FileParameter>(result);
            Assert.IsAssignableFrom<FileParameter>(result);
        }

        /// <summary>
        /// Tests that FileParameter handles various content types correctly.
        /// </summary>
        [Theory]
        [InlineData("application/pdf")]
        [InlineData("application/json")]
        [InlineData("text/csv")]
        [InlineData("application/xml")]
        [InlineData("image/png")]
        [InlineData("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")]
        public async Task Deserialize_FileParameter_HandlesVariousContentTypes(string contentType)
        {
            // Arrange
            var testContent = Encoding.UTF8.GetBytes("Test content");
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(testContent)
            };
            response.Content.Headers.ContentType = new MediaTypeHeaderValue(contentType);

            // Act
            var result = await DeserializeAsync<FileParameter>(response);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(contentType, result.ContentType);
        }
    }
}
