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
 * ## Authentication  #### Step 1: Generate API Credentials  Generate a *client ID* and *client secret* from your [Avalara1099 account](https://sbx.track1099.com/api_tokens): *Your Profile → API*.  #### Step 2: Get an Identity Token  Send a `POST` request to the **Identity Token URL** with your *client ID* and *client secret* from Step 1 as form-encoded parameters:  ```http POST https://identity.avalara.com/connect/token Content-Type: application/x-www-form-urlencoded  grant_type=client_credentials client_id=<your client ID> client_secret=<your client secret> ```  **Body parameters** - `grant_type` — Always `client_credentials` - `client_id` — Your *client ID* from Step 1 - `client_secret` — Your *client secret* from Step 1  **Successful response**  ```json {   \"access_token\": \"eyJhbGci...\",   \"expires_in\": 3600,   \"token_type\": \"Bearer\" } ```  Use the `access_token` as a bearer token in the `Authorization` header on every A1099 API request:  ```http Authorization: Bearer <access_token> ```  - --  For more on authenticating requests, see the [A1099 authentication guide](https://developer.avalara.com/1099-and-w-9/kny2997001535374/).  - --  ## Environments  #### Production - **Avalara 1099 API URL:** [`https://api.avalara.com/avalara1099`](https://api.avalara.com/avalara1099) - **Identity Token URL:** [`https://identity.avalara.com/connect/token`](https://identity.avalara.com/connect/token)  #### Sandbox - **Avalara 1099 API URL:** [`https://api.sbx.avalara.com/avalara1099`](https://api.sbx.avalara.com/avalara1099) - **Identity Token URL:** [`https://ai-sbx.avlr.sh/connect/token`](https://ai-sbx.avlr.sh/connect/token)  - --  ## API & SDK Documentation  [Avalara 1099 API Reference](https://developer.avalara.com/api-reference/avalara1099/avalara1099/)  [Avalara SDKs](https://developer.avalara.com/sdk/)  [Swagger](https://api.avalara.com/avalara1099/swagger/index.html?api-version=2.0)
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
    /// CreateW9FormRequest
    /// </summary>
    [JsonConverter(typeof(CreateW9FormRequestJsonConverter))]
    [DataContract(Name = "CreateW9Form_request")]
    public partial class CreateW9FormRequest : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateW9FormRequest" /> class
        /// with the <see cref="W9FormRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W9FormRequest.</param>
        public CreateW9FormRequest(W9FormRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateW9FormRequest" /> class
        /// with the <see cref="W8ImyFormRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W8ImyFormRequest.</param>
        public CreateW9FormRequest(W8ImyFormRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateW9FormRequest" /> class
        /// with the <see cref="W8BenEFormRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W8BenEFormRequest.</param>
        public CreateW9FormRequest(W8BenEFormRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateW9FormRequest" /> class
        /// with the <see cref="W8BenFormRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W8BenFormRequest.</param>
        public CreateW9FormRequest(W8BenFormRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateW9FormRequest" /> class
        /// with the <see cref="W4FormRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W4FormRequest.</param>
        public CreateW9FormRequest(W4FormRequest actualInstance)
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
                if (value.GetType() == typeof(W4FormRequest) || value is W4FormRequest)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W8BenEFormRequest) || value is W8BenEFormRequest)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W8BenFormRequest) || value is W8BenFormRequest)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W8ImyFormRequest) || value is W8ImyFormRequest)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W9FormRequest) || value is W9FormRequest)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: W4FormRequest, W8BenEFormRequest, W8BenFormRequest, W8ImyFormRequest, W9FormRequest");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `W9FormRequest`. If the actual instance is not `W9FormRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W9FormRequest</returns>
        public W9FormRequest GetW9FormRequest()
        {
            return (W9FormRequest)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W8ImyFormRequest`. If the actual instance is not `W8ImyFormRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W8ImyFormRequest</returns>
        public W8ImyFormRequest GetW8ImyFormRequest()
        {
            return (W8ImyFormRequest)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W8BenEFormRequest`. If the actual instance is not `W8BenEFormRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W8BenEFormRequest</returns>
        public W8BenEFormRequest GetW8BenEFormRequest()
        {
            return (W8BenEFormRequest)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W8BenFormRequest`. If the actual instance is not `W8BenFormRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W8BenFormRequest</returns>
        public W8BenFormRequest GetW8BenFormRequest()
        {
            return (W8BenFormRequest)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W4FormRequest`. If the actual instance is not `W4FormRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W4FormRequest</returns>
        public W4FormRequest GetW4FormRequest()
        {
            return (W4FormRequest)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateW9FormRequest {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, CreateW9FormRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CreateW9FormRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CreateW9FormRequest</returns>
        public static CreateW9FormRequest FromJson(string jsonString)
        {
            CreateW9FormRequest newCreateW9FormRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCreateW9FormRequest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W4FormRequest).GetProperty("AdditionalProperties") == null)
                {
                    newCreateW9FormRequest = new CreateW9FormRequest(JsonConvert.DeserializeObject<W4FormRequest>(jsonString, CreateW9FormRequest.SerializerSettings));
                }
                else
                {
                    newCreateW9FormRequest = new CreateW9FormRequest(JsonConvert.DeserializeObject<W4FormRequest>(jsonString, CreateW9FormRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W4FormRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W4FormRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W8BenEFormRequest).GetProperty("AdditionalProperties") == null)
                {
                    newCreateW9FormRequest = new CreateW9FormRequest(JsonConvert.DeserializeObject<W8BenEFormRequest>(jsonString, CreateW9FormRequest.SerializerSettings));
                }
                else
                {
                    newCreateW9FormRequest = new CreateW9FormRequest(JsonConvert.DeserializeObject<W8BenEFormRequest>(jsonString, CreateW9FormRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W8BenEFormRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W8BenEFormRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W8BenFormRequest).GetProperty("AdditionalProperties") == null)
                {
                    newCreateW9FormRequest = new CreateW9FormRequest(JsonConvert.DeserializeObject<W8BenFormRequest>(jsonString, CreateW9FormRequest.SerializerSettings));
                }
                else
                {
                    newCreateW9FormRequest = new CreateW9FormRequest(JsonConvert.DeserializeObject<W8BenFormRequest>(jsonString, CreateW9FormRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W8BenFormRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W8BenFormRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W8ImyFormRequest).GetProperty("AdditionalProperties") == null)
                {
                    newCreateW9FormRequest = new CreateW9FormRequest(JsonConvert.DeserializeObject<W8ImyFormRequest>(jsonString, CreateW9FormRequest.SerializerSettings));
                }
                else
                {
                    newCreateW9FormRequest = new CreateW9FormRequest(JsonConvert.DeserializeObject<W8ImyFormRequest>(jsonString, CreateW9FormRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W8ImyFormRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W8ImyFormRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W9FormRequest).GetProperty("AdditionalProperties") == null)
                {
                    newCreateW9FormRequest = new CreateW9FormRequest(JsonConvert.DeserializeObject<W9FormRequest>(jsonString, CreateW9FormRequest.SerializerSettings));
                }
                else
                {
                    newCreateW9FormRequest = new CreateW9FormRequest(JsonConvert.DeserializeObject<W9FormRequest>(jsonString, CreateW9FormRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W9FormRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W9FormRequest: {1}", jsonString, exception.ToString()));
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
            return newCreateW9FormRequest;
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
    /// Custom JSON converter for CreateW9FormRequest
    /// </summary>
    public class CreateW9FormRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CreateW9FormRequest).GetMethod("ToJson").Invoke(value, null)));
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
                    return CreateW9FormRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return CreateW9FormRequest.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
