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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using FileParameter = Avalara.SDK.Client.FileParameter;
using OpenAPIDateConverter = Avalara.SDK.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Avalara.SDK.Model.A1099.V2
{
    /// <summary>
    /// Get1099Form200Response
    /// </summary>
    [JsonConverter(typeof(Get1099Form200ResponseJsonConverter))]
    [DataContract(Name = "Get1099Form_200_response")]
    public partial class Get1099Form200Response : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Get1099Form200Response" /> class
        /// with the <see cref="Form1042S" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1042S.</param>
        public Get1099Form200Response(Form1042S actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Get1099Form200Response" /> class
        /// with the <see cref="Form1095B" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1095B.</param>
        public Get1099Form200Response(Form1095B actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Get1099Form200Response" /> class
        /// with the <see cref="Form1095C" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1095C.</param>
        public Get1099Form200Response(Form1095C actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Get1099Form200Response" /> class
        /// with the <see cref="Form1099Div" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099Div.</param>
        public Get1099Form200Response(Form1099Div actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Get1099Form200Response" /> class
        /// with the <see cref="Form1099Int" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099Int.</param>
        public Get1099Form200Response(Form1099Int actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Get1099Form200Response" /> class
        /// with the <see cref="Form1099K" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099K.</param>
        public Get1099Form200Response(Form1099K actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Get1099Form200Response" /> class
        /// with the <see cref="Form1099Misc" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099Misc.</param>
        public Get1099Form200Response(Form1099Misc actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Get1099Form200Response" /> class
        /// with the <see cref="Form1099Nec" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099Nec.</param>
        public Get1099Form200Response(Form1099Nec actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Get1099Form200Response" /> class
        /// with the <see cref="Form1099R" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099R.</param>
        public Get1099Form200Response(Form1099R actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Get1099Form200Response" /> class
        /// with the <see cref="Form1099W2" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099W2.</param>
        public Get1099Form200Response(Form1099W2 actualInstance)
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
                if (value.GetType() == typeof(Form1042S) || value is Form1042S)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1095B) || value is Form1095B)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1095C) || value is Form1095C)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099Div) || value is Form1099Div)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099Int) || value is Form1099Int)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099K) || value is Form1099K)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099Misc) || value is Form1099Misc)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099Nec) || value is Form1099Nec)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099R) || value is Form1099R)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099W2) || value is Form1099W2)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Form1042S, Form1095B, Form1095C, Form1099Div, Form1099Int, Form1099K, Form1099Misc, Form1099Nec, Form1099R, Form1099W2");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Form1042S`. If the actual instance is not `Form1042S`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1042S</returns>
        public Form1042S GetForm1042S()
        {
            return (Form1042S)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1095B`. If the actual instance is not `Form1095B`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1095B</returns>
        public Form1095B GetForm1095B()
        {
            return (Form1095B)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1095C`. If the actual instance is not `Form1095C`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1095C</returns>
        public Form1095C GetForm1095C()
        {
            return (Form1095C)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099Div`. If the actual instance is not `Form1099Div`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099Div</returns>
        public Form1099Div GetForm1099Div()
        {
            return (Form1099Div)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099Int`. If the actual instance is not `Form1099Int`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099Int</returns>
        public Form1099Int GetForm1099Int()
        {
            return (Form1099Int)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099K`. If the actual instance is not `Form1099K`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099K</returns>
        public Form1099K GetForm1099K()
        {
            return (Form1099K)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099Misc`. If the actual instance is not `Form1099Misc`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099Misc</returns>
        public Form1099Misc GetForm1099Misc()
        {
            return (Form1099Misc)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099Nec`. If the actual instance is not `Form1099Nec`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099Nec</returns>
        public Form1099Nec GetForm1099Nec()
        {
            return (Form1099Nec)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099R`. If the actual instance is not `Form1099R`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099R</returns>
        public Form1099R GetForm1099R()
        {
            return (Form1099R)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099W2`. If the actual instance is not `Form1099W2`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099W2</returns>
        public Form1099W2 GetForm1099W2()
        {
            return (Form1099W2)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Get1099Form200Response {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, Get1099Form200Response.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Get1099Form200Response
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Get1099Form200Response</returns>
        public static Get1099Form200Response FromJson(string jsonString)
        {
            Get1099Form200Response newGet1099Form200Response = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newGet1099Form200Response;
            }

            try
            {
                var discriminatorObj = JObject.Parse(jsonString)["type"];
                string discriminatorValue =  discriminatorObj == null ?string.Empty :discriminatorObj.ToString();
                switch (discriminatorValue)
                {
                    case "1042-S":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1042S>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "1095-B":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1095B>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "1095-C":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1095C>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "1099-DIV":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Div>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "1099-INT":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Int>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "1099-K":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099K>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "1099-MISC":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Misc>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "1099-NEC":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Nec>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "1099-R":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099R>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "W-2":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099W2>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "Form1042S":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1042S>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "Form1095B":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1095B>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "Form1095C":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1095C>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "Form1099Div":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Div>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "Form1099Int":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Int>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "Form1099K":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099K>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "Form1099Misc":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Misc>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "Form1099Nec":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Nec>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "Form1099R":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099R>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    case "Form1099W2":
                        newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099W2>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                        return newGet1099Form200Response;
                    default:
                        System.Diagnostics.Debug.WriteLine(string.Format("Failed to lookup discriminator value `{0}` for Get1099Form200Response. Possible values: 1042-S 1095-B 1095-C 1099-DIV 1099-INT 1099-K 1099-MISC 1099-NEC 1099-R W-2 Form1042S Form1095B Form1095C Form1099Div Form1099Int Form1099K Form1099Misc Form1099Nec Form1099R Form1099W2", discriminatorValue));
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to parse the json data : `{0}` {1}", jsonString, ex.ToString()));
            }

            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1042S).GetProperty("AdditionalProperties") == null)
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1042S>(jsonString, Get1099Form200Response.SerializerSettings));
                }
                else
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1042S>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1042S");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1042S: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1095B).GetProperty("AdditionalProperties") == null)
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1095B>(jsonString, Get1099Form200Response.SerializerSettings));
                }
                else
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1095B>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1095B");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1095B: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1095C).GetProperty("AdditionalProperties") == null)
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1095C>(jsonString, Get1099Form200Response.SerializerSettings));
                }
                else
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1095C>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1095C");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1095C: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099Div).GetProperty("AdditionalProperties") == null)
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Div>(jsonString, Get1099Form200Response.SerializerSettings));
                }
                else
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Div>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099Div");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099Div: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099Int).GetProperty("AdditionalProperties") == null)
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Int>(jsonString, Get1099Form200Response.SerializerSettings));
                }
                else
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Int>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099Int");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099Int: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099K).GetProperty("AdditionalProperties") == null)
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099K>(jsonString, Get1099Form200Response.SerializerSettings));
                }
                else
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099K>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099K");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099K: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099Misc).GetProperty("AdditionalProperties") == null)
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Misc>(jsonString, Get1099Form200Response.SerializerSettings));
                }
                else
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Misc>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099Misc");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099Misc: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099Nec).GetProperty("AdditionalProperties") == null)
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Nec>(jsonString, Get1099Form200Response.SerializerSettings));
                }
                else
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099Nec>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099Nec");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099Nec: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099R).GetProperty("AdditionalProperties") == null)
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099R>(jsonString, Get1099Form200Response.SerializerSettings));
                }
                else
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099R>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099R");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099R: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099W2).GetProperty("AdditionalProperties") == null)
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099W2>(jsonString, Get1099Form200Response.SerializerSettings));
                }
                else
                {
                    newGet1099Form200Response = new Get1099Form200Response(JsonConvert.DeserializeObject<Form1099W2>(jsonString, Get1099Form200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099W2");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099W2: {1}", jsonString, exception.ToString()));
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
            return newGet1099Form200Response;
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
    /// Custom JSON converter for Get1099Form200Response
    /// </summary>
    public class Get1099Form200ResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Get1099Form200Response).GetMethod("ToJson").Invoke(value, null)));
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
                    return Get1099Form200Response.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return Get1099Form200Response.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
