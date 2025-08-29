/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara 1099 & W-9 API Definition
 *
 * ## 🔐 Authentication  Generate a **license key** from: *[Avalara Portal](https://www.avalara.com/us/en/signin.html) → Settings → License and API Keys*.  [More on authentication methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  [Test your credentials](https://developer.avalara.com/avatax/test-credentials/)  ## 📘 API & SDK Documentation  [Avalara SDK (.NET) on GitHub](https://github.com/avadev/Avalara-SDK-DotNet#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples – 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
 *

 * @author     Sachin Baijal <sachin.baijal@avalara.com>
 * @author     Jonathan Wenger <jonathan.wenger@avalara.com>
 * @copyright  2004-2022 Avalara, Inc.
 * @license    https://www.apache.org/licenses/LICENSE-2.0
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Avalara.SDK.Client.FileParameter;
using OpenAPIDateConverter = Avalara.SDK.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Avalara.SDK.Model.A1099.V2
{
    /// <summary>
    /// CreateAndSendW9FormEmailRequest
    /// </summary>
    [JsonConverter(typeof(CreateAndSendW9FormEmailRequestJsonConverter))]
    [DataContract(Name = "CreateAndSendW9FormEmail_request")]
    public partial class CreateAndSendW9FormEmailRequest : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAndSendW9FormEmailRequest" /> class
        /// with the <see cref="W4FormMinimalRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W4FormMinimalRequest.</param>
        public CreateAndSendW9FormEmailRequest(W4FormMinimalRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAndSendW9FormEmailRequest" /> class
        /// with the <see cref="W8BenEFormMinimalRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W8BenEFormMinimalRequest.</param>
        public CreateAndSendW9FormEmailRequest(W8BenEFormMinimalRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAndSendW9FormEmailRequest" /> class
        /// with the <see cref="W8BenFormMinimalRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W8BenFormMinimalRequest.</param>
        public CreateAndSendW9FormEmailRequest(W8BenFormMinimalRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAndSendW9FormEmailRequest" /> class
        /// with the <see cref="W8ImyFormMinimalRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W8ImyFormMinimalRequest.</param>
        public CreateAndSendW9FormEmailRequest(W8ImyFormMinimalRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAndSendW9FormEmailRequest" /> class
        /// with the <see cref="W9FormMinimalRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W9FormMinimalRequest.</param>
        public CreateAndSendW9FormEmailRequest(W9FormMinimalRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(W4FormMinimalRequest) || value is W4FormMinimalRequest)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W8BenEFormMinimalRequest) || value is W8BenEFormMinimalRequest)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W8BenFormMinimalRequest) || value is W8BenFormMinimalRequest)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W8ImyFormMinimalRequest) || value is W8ImyFormMinimalRequest)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W9FormMinimalRequest) || value is W9FormMinimalRequest)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: W4FormMinimalRequest, W8BenEFormMinimalRequest, W8BenFormMinimalRequest, W8ImyFormMinimalRequest, W9FormMinimalRequest");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `W4FormMinimalRequest`. If the actual instance is not `W4FormMinimalRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W4FormMinimalRequest</returns>
        public W4FormMinimalRequest GetW4FormMinimalRequest()
        {
            return (W4FormMinimalRequest)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W8BenEFormMinimalRequest`. If the actual instance is not `W8BenEFormMinimalRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W8BenEFormMinimalRequest</returns>
        public W8BenEFormMinimalRequest GetW8BenEFormMinimalRequest()
        {
            return (W8BenEFormMinimalRequest)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W8BenFormMinimalRequest`. If the actual instance is not `W8BenFormMinimalRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W8BenFormMinimalRequest</returns>
        public W8BenFormMinimalRequest GetW8BenFormMinimalRequest()
        {
            return (W8BenFormMinimalRequest)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W8ImyFormMinimalRequest`. If the actual instance is not `W8ImyFormMinimalRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W8ImyFormMinimalRequest</returns>
        public W8ImyFormMinimalRequest GetW8ImyFormMinimalRequest()
        {
            return (W8ImyFormMinimalRequest)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W9FormMinimalRequest`. If the actual instance is not `W9FormMinimalRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W9FormMinimalRequest</returns>
        public W9FormMinimalRequest GetW9FormMinimalRequest()
        {
            return (W9FormMinimalRequest)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAndSendW9FormEmailRequest {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, CreateAndSendW9FormEmailRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CreateAndSendW9FormEmailRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CreateAndSendW9FormEmailRequest</returns>
        public static CreateAndSendW9FormEmailRequest FromJson(string jsonString)
        {
            CreateAndSendW9FormEmailRequest newCreateAndSendW9FormEmailRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCreateAndSendW9FormEmailRequest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W4FormMinimalRequest).GetProperty("AdditionalProperties") == null)
                {
                    newCreateAndSendW9FormEmailRequest = new CreateAndSendW9FormEmailRequest(JsonConvert.DeserializeObject<W4FormMinimalRequest>(jsonString, CreateAndSendW9FormEmailRequest.SerializerSettings));
                }
                else
                {
                    newCreateAndSendW9FormEmailRequest = new CreateAndSendW9FormEmailRequest(JsonConvert.DeserializeObject<W4FormMinimalRequest>(jsonString, CreateAndSendW9FormEmailRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W4FormMinimalRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W4FormMinimalRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W8BenEFormMinimalRequest).GetProperty("AdditionalProperties") == null)
                {
                    newCreateAndSendW9FormEmailRequest = new CreateAndSendW9FormEmailRequest(JsonConvert.DeserializeObject<W8BenEFormMinimalRequest>(jsonString, CreateAndSendW9FormEmailRequest.SerializerSettings));
                }
                else
                {
                    newCreateAndSendW9FormEmailRequest = new CreateAndSendW9FormEmailRequest(JsonConvert.DeserializeObject<W8BenEFormMinimalRequest>(jsonString, CreateAndSendW9FormEmailRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W8BenEFormMinimalRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W8BenEFormMinimalRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W8BenFormMinimalRequest).GetProperty("AdditionalProperties") == null)
                {
                    newCreateAndSendW9FormEmailRequest = new CreateAndSendW9FormEmailRequest(JsonConvert.DeserializeObject<W8BenFormMinimalRequest>(jsonString, CreateAndSendW9FormEmailRequest.SerializerSettings));
                }
                else
                {
                    newCreateAndSendW9FormEmailRequest = new CreateAndSendW9FormEmailRequest(JsonConvert.DeserializeObject<W8BenFormMinimalRequest>(jsonString, CreateAndSendW9FormEmailRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W8BenFormMinimalRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W8BenFormMinimalRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W8ImyFormMinimalRequest).GetProperty("AdditionalProperties") == null)
                {
                    newCreateAndSendW9FormEmailRequest = new CreateAndSendW9FormEmailRequest(JsonConvert.DeserializeObject<W8ImyFormMinimalRequest>(jsonString, CreateAndSendW9FormEmailRequest.SerializerSettings));
                }
                else
                {
                    newCreateAndSendW9FormEmailRequest = new CreateAndSendW9FormEmailRequest(JsonConvert.DeserializeObject<W8ImyFormMinimalRequest>(jsonString, CreateAndSendW9FormEmailRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W8ImyFormMinimalRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W8ImyFormMinimalRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W9FormMinimalRequest).GetProperty("AdditionalProperties") == null)
                {
                    newCreateAndSendW9FormEmailRequest = new CreateAndSendW9FormEmailRequest(JsonConvert.DeserializeObject<W9FormMinimalRequest>(jsonString, CreateAndSendW9FormEmailRequest.SerializerSettings));
                }
                else
                {
                    newCreateAndSendW9FormEmailRequest = new CreateAndSendW9FormEmailRequest(JsonConvert.DeserializeObject<W9FormMinimalRequest>(jsonString, CreateAndSendW9FormEmailRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W9FormMinimalRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W9FormMinimalRequest: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newCreateAndSendW9FormEmailRequest;
        }


        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for CreateAndSendW9FormEmailRequest
    /// </summary>
    public class CreateAndSendW9FormEmailRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CreateAndSendW9FormEmailRequest).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return CreateAndSendW9FormEmailRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return CreateAndSendW9FormEmailRequest.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
