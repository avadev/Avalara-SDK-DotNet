﻿/*
 Avalara API Client Library
 * Avalara Shipping Verification for Beverage Alcohol
 *
 * API for evaluating transactions against direct-to-consumer Beverage Alcohol shipping regulations.  This API is currently in beta. 
 *
 * The version of SDK  : 22.1.0
 */

using System;
using System.IO;
using Xunit;

using Avalara.SDK.Client;
using Avalara.SDK.Helpers;
using Avalara.SDK.Api.EInvoicing.V1;
using System.Threading.Tasks;

namespace Avalara.SDK.Test.Api
{
    /// <summary>
    ///  Class for testing ShippingVerificationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EInvoicingTests : IDisposable
    {
        private MandatesApi mandatesApi;
        private DocumentsApi documentsApi;
        private ApiClient apiclient;
        public EInvoicingTests()
        {
            var root = Directory.GetCurrentDirectory();
            var basePath = root.Split(new string[] { "\\src\\" }, StringSplitOptions.None)[0];
            var dotenv = Path.Combine(basePath, ".env");
            DotEnv.Load(dotenv);
            Configuration configuration = new Configuration
            {
                Environment = Enum.TryParse<AvalaraEnvironment>(Environment.GetEnvironmentVariable("ENVIRONMENT"), true, out var env) ? env : AvalaraEnvironment.Sandbox,
                BearerToken = Environment.GetEnvironmentVariable("BEARER_TOKEN_EINVOICING"),
                AppName = "Test",
                AppVersion = "1.0",
                MachineName = "LocalBox"
            };

            apiclient = new ApiClient(configuration);

            mandatesApi = new MandatesApi(apiclient);
            documentsApi = new DocumentsApi(apiclient);

        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShippingVerificationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<MandatesApi>(mandatesApi);
        }

        /// <summary>
        /// Test Get Documents
        /// </summary>
        [Fact]
        public async Task DocumentsTest()
        {
            var response = await documentsApi.GetDocumentListAsync(new GetDocumentListRequestSdk() { });
            Assert.NotNull(response);
        }

        /// <summary>
        /// Test Get Mandates
        /// </summary>
        [Fact]
        public async Task MandatesTest()
        {
            var response = await mandatesApi.GetMandatesAsync(new GetMandatesRequestSdk() { });
            Assert.NotNull(response.Value);
        }
    }
}