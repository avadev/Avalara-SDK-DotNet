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
    /// CreateW9Form201Response
    /// </summary>
    [JsonConverter(typeof(CreateW9Form201ResponseJsonConverter))]
    [DataContract(Name = "CreateW9Form_201_response")]
    public partial class CreateW9Form201Response : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateW9Form201Response" /> class
        /// with the <see cref="W4FormResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W4FormResponse.</param>
        public CreateW9Form201Response(W4FormResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateW9Form201Response" /> class
        /// with the <see cref="W8BenEFormResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W8BenEFormResponse.</param>
        public CreateW9Form201Response(W8BenEFormResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateW9Form201Response" /> class
        /// with the <see cref="W8BenFormResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W8BenFormResponse.</param>
        public CreateW9Form201Response(W8BenFormResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateW9Form201Response" /> class
        /// with the <see cref="W8ImyFormResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W8ImyFormResponse.</param>
        public CreateW9Form201Response(W8ImyFormResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateW9Form201Response" /> class
        /// with the <see cref="W9FormResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W9FormResponse.</param>
        public CreateW9Form201Response(W9FormResponse actualInstance)
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
                if (value.GetType() == typeof(W4FormResponse) || value is W4FormResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W8BenEFormResponse) || value is W8BenEFormResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W8BenFormResponse) || value is W8BenFormResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W8ImyFormResponse) || value is W8ImyFormResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W9FormResponse) || value is W9FormResponse)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: W4FormResponse, W8BenEFormResponse, W8BenFormResponse, W8ImyFormResponse, W9FormResponse");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `W4FormResponse`. If the actual instance is not `W4FormResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W4FormResponse</returns>
        public W4FormResponse GetW4FormResponse()
        {
            return (W4FormResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W8BenEFormResponse`. If the actual instance is not `W8BenEFormResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W8BenEFormResponse</returns>
        public W8BenEFormResponse GetW8BenEFormResponse()
        {
            return (W8BenEFormResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W8BenFormResponse`. If the actual instance is not `W8BenFormResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W8BenFormResponse</returns>
        public W8BenFormResponse GetW8BenFormResponse()
        {
            return (W8BenFormResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W8ImyFormResponse`. If the actual instance is not `W8ImyFormResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W8ImyFormResponse</returns>
        public W8ImyFormResponse GetW8ImyFormResponse()
        {
            return (W8ImyFormResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W9FormResponse`. If the actual instance is not `W9FormResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W9FormResponse</returns>
        public W9FormResponse GetW9FormResponse()
        {
            return (W9FormResponse)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateW9Form201Response {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, CreateW9Form201Response.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CreateW9Form201Response
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CreateW9Form201Response</returns>
        public static CreateW9Form201Response FromJson(string jsonString)
        {
            CreateW9Form201Response newCreateW9Form201Response = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCreateW9Form201Response;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W4FormResponse).GetProperty("AdditionalProperties") == null)
                {
                    newCreateW9Form201Response = new CreateW9Form201Response(JsonConvert.DeserializeObject<W4FormResponse>(jsonString, CreateW9Form201Response.SerializerSettings));
                }
                else
                {
                    newCreateW9Form201Response = new CreateW9Form201Response(JsonConvert.DeserializeObject<W4FormResponse>(jsonString, CreateW9Form201Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W4FormResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W4FormResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W8BenEFormResponse).GetProperty("AdditionalProperties") == null)
                {
                    newCreateW9Form201Response = new CreateW9Form201Response(JsonConvert.DeserializeObject<W8BenEFormResponse>(jsonString, CreateW9Form201Response.SerializerSettings));
                }
                else
                {
                    newCreateW9Form201Response = new CreateW9Form201Response(JsonConvert.DeserializeObject<W8BenEFormResponse>(jsonString, CreateW9Form201Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W8BenEFormResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W8BenEFormResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W8BenFormResponse).GetProperty("AdditionalProperties") == null)
                {
                    newCreateW9Form201Response = new CreateW9Form201Response(JsonConvert.DeserializeObject<W8BenFormResponse>(jsonString, CreateW9Form201Response.SerializerSettings));
                }
                else
                {
                    newCreateW9Form201Response = new CreateW9Form201Response(JsonConvert.DeserializeObject<W8BenFormResponse>(jsonString, CreateW9Form201Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W8BenFormResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W8BenFormResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W8ImyFormResponse).GetProperty("AdditionalProperties") == null)
                {
                    newCreateW9Form201Response = new CreateW9Form201Response(JsonConvert.DeserializeObject<W8ImyFormResponse>(jsonString, CreateW9Form201Response.SerializerSettings));
                }
                else
                {
                    newCreateW9Form201Response = new CreateW9Form201Response(JsonConvert.DeserializeObject<W8ImyFormResponse>(jsonString, CreateW9Form201Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W8ImyFormResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W8ImyFormResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W9FormResponse).GetProperty("AdditionalProperties") == null)
                {
                    newCreateW9Form201Response = new CreateW9Form201Response(JsonConvert.DeserializeObject<W9FormResponse>(jsonString, CreateW9Form201Response.SerializerSettings));
                }
                else
                {
                    newCreateW9Form201Response = new CreateW9Form201Response(JsonConvert.DeserializeObject<W9FormResponse>(jsonString, CreateW9Form201Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W9FormResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W9FormResponse: {1}", jsonString, exception.ToString()));
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
            return newCreateW9Form201Response;
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
    /// Custom JSON converter for CreateW9Form201Response
    /// </summary>
    public class CreateW9Form201ResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CreateW9Form201Response).GetMethod("ToJson").Invoke(value, null)));
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
                    return CreateW9Form201Response.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return CreateW9Form201Response.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
