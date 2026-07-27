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
 * > **Note:** You must have an active Avalara 1099 & W-9 subscription to authenticate and use these APIs. If you don't have a subscription, please contact our [Sales team](https://www.avalara.com/us/en/products/1099/request-a-demo.html).  ## Authentication  The Avalara 1099 & W-9 API uses **Bearer Token Authentication**. To authenticate, acquire a bearer token using a **Client ID** and **Client Secret** that you generate in the Avalara 1099 & W-9 web application.  The sample cURL commands below use **production** URLs. For **sandbox**, replace them with the sandbox URLs listed in the Sandbox Environment table.  ### Option 1 — Client ID and Client Secret (recommended)  **Step 1: Create API credentials in the Avalara 1099 & W-9 web app**  For a full walkthrough, see the [Avalara 1099 & W-9 integration guide](https://developer.avalara.com/products/avalara-1099-and-w9/integration-guides/1099-and-w-9/siu2796410674799/).  > **Note:** To enable credential creation you must first enter a valid company address in **Account Settings > Account** and enable two-factor authentication in **Account Settings > Security**.  1. In Avalara 1099 & W-9, open **Account Settings** (gear icon, top-right of any page) and select **API**. 2. Click **Create new credentials** (a valid company address and 2FA are required). 3. Copy your **Client Id** and **Client Secret** securely — they will not be shown again after you leave the screen.  **Step 2: Request a bearer token**  ```bash curl -X POST 'https://identity.avalara.com/connect/token' \\   - -header 'Content-Type: application/x-www-form-urlencoded' \\   - -data-urlencode 'grant_type=client_credentials' \\   - -data-urlencode 'client_id={{client_id}}' \\   - -data-urlencode 'client_secret={{client_secret}}' ```  ### Option 2 — Account ID and License Key  If your organization already uses other Avalara products (AvaTax, CertCapture) and has access to the logged-in area of Avalara.com, you can generate the bearer token using your **Account ID** and **License Key**.  > **Note:** If you already have a license key for other Avalara products you can reuse it. Generating a new key will reset any previously created key.  1. Log in to Avalara.com. 2. Go to **Settings → License and API Keys**. 3. Click **Generate New Key**. 4. Note your **Account ID** from the Account menu.  ```bash curl -X POST 'https://identity.avalara.com/connect/token' \\   - -header 'Content-Type: application/x-www-form-urlencoded' \\   - -data-urlencode 'grant_type=client_credentials' \\   - -data-urlencode 'client_id={{accountId}}' \\   - -data-urlencode 'client_secret={{licenseKey}}' ```  ### Using and renewing the bearer token  Include the token in the `Authorization` header on every request:  ```http Authorization: Bearer {access_token} ```  Tokens expire after the number of seconds in the `expires_in` field of the token response. Your integration must renew the token before it expires.  **Example token response**  ```json {   \"access_token\": \"eyJhbGciOiJIUzI1NiIsInR5cCI...\",   \"expires_in\": 3600,   \"token_type\": \"Bearer\",   \"scope\": \"avatax_api iam-ds\" } ```  ### Sandbox Environment  Use the same steps as production, replacing the base URLs:  | Purpose | Production | Sandbox | | - -- | - -- | - -- | | Account & License Key management (web) | `https://www.avalara.com` | `https://sandbox.admin.avalara.com` | | Account & License Key management (API) | `https://rest.avatax.com` | `https://sandbox-rest.avatax.com` | | Token generation | `https://identity.avalara.com` | `https://ai-sbx.avlr.sh` |  ## Environments  #### Production - **Avalara 1099 API URL:** [`https://api.avalara.com/avalara1099`](https://api.avalara.com/avalara1099) - **Identity Token URL:** [`https://identity.avalara.com/connect/token`](https://identity.avalara.com/connect/token)  #### Sandbox - **Avalara 1099 API URL:** [`https://api.sbx.avalara.com/avalara1099`](https://api.sbx.avalara.com/avalara1099) - **Identity Token URL:** [`https://ai-sbx.avlr.sh/connect/token`](https://ai-sbx.avlr.sh/connect/token)  - --  ## API & SDK Documentation  [Avalara 1099 API Reference](https://developer.avalara.com/api-reference/avalara1099/avalara1099/)  [Avalara SDKs](https://developer.avalara.com/sdk/)  [Swagger](https://api.avalara.com/avalara1099/swagger/index.html?api-version=2.0)
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
