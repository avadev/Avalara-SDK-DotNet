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
 * ## 🔐 Authentication  Use **username/password** or generate a **license key** from: *Avalara Portal → Settings → License and API Keys*.  [More on authentication methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  [Test your credentials](https://developer.avalara.com/avatax/test-credentials/)  ## 📘 API & SDK Documentation  [Avalara SDK (.NET) on GitHub](https://github.com/avadev/Avalara-SDK-DotNet#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples – 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
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
    /// Update1099Form200Response
    /// </summary>
    [JsonConverter(typeof(Update1099Form200ResponseJsonConverter))]
    [DataContract(Name = "Update1099Form_200_response")]
    public partial class Update1099Form200Response : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Update1099Form200Response" /> class
        /// with the <see cref="FormResponseBase" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of FormResponseBase.</param>
        public Update1099Form200Response(FormResponseBase actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Update1099Form200Response" /> class
        /// with the <see cref="Form1099DivResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099DivResponse.</param>
        public Update1099Form200Response(Form1099DivResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Update1099Form200Response" /> class
        /// with the <see cref="Form1099MiscResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099MiscResponse.</param>
        public Update1099Form200Response(Form1099MiscResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Update1099Form200Response" /> class
        /// with the <see cref="Form1099NecResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099NecResponse.</param>
        public Update1099Form200Response(Form1099NecResponse actualInstance)
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
                if (value.GetType() == typeof(Form1099DivResponse) || value is Form1099DivResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099MiscResponse) || value is Form1099MiscResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099NecResponse) || value is Form1099NecResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(FormResponseBase) || value is FormResponseBase)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Form1099DivResponse, Form1099MiscResponse, Form1099NecResponse, FormResponseBase");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `FormResponseBase`. If the actual instance is not `FormResponseBase`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of FormResponseBase</returns>
        public FormResponseBase GetFormResponseBase()
        {
            return (FormResponseBase)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099DivResponse`. If the actual instance is not `Form1099DivResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099DivResponse</returns>
        public Form1099DivResponse GetForm1099DivResponse()
        {
            return (Form1099DivResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099MiscResponse`. If the actual instance is not `Form1099MiscResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099MiscResponse</returns>
        public Form1099MiscResponse GetForm1099MiscResponse()
        {
            return (Form1099MiscResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099NecResponse`. If the actual instance is not `Form1099NecResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099NecResponse</returns>
        public Form1099NecResponse GetForm1099NecResponse()
        {
            return (Form1099NecResponse)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Update1099Form200Response {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, Update1099Form200Response.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Update1099Form200Response
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Update1099Form200Response</returns>
        public static Update1099Form200Response FromJson(string jsonString)
        {
            Update1099Form200Response newUpdate1099Form200Response = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newUpdate1099Form200Response;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099DivResponse).GetProperty("AdditionalProperties") == null)
                {
                    newUpdate1099Form200Response = new Update1099Form200Response(JsonConvert.DeserializeObject<Form1099DivResponse>(jsonString, Update1099Form200Response.SerializerSettings));
                }
                else
                {
                    newUpdate1099Form200Response = new Update1099Form200Response(JsonConvert.DeserializeObject<Form1099DivResponse>(jsonString, Update1099Form200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099DivResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099DivResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099MiscResponse).GetProperty("AdditionalProperties") == null)
                {
                    newUpdate1099Form200Response = new Update1099Form200Response(JsonConvert.DeserializeObject<Form1099MiscResponse>(jsonString, Update1099Form200Response.SerializerSettings));
                }
                else
                {
                    newUpdate1099Form200Response = new Update1099Form200Response(JsonConvert.DeserializeObject<Form1099MiscResponse>(jsonString, Update1099Form200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099MiscResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099MiscResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099NecResponse).GetProperty("AdditionalProperties") == null)
                {
                    newUpdate1099Form200Response = new Update1099Form200Response(JsonConvert.DeserializeObject<Form1099NecResponse>(jsonString, Update1099Form200Response.SerializerSettings));
                }
                else
                {
                    newUpdate1099Form200Response = new Update1099Form200Response(JsonConvert.DeserializeObject<Form1099NecResponse>(jsonString, Update1099Form200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099NecResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099NecResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(FormResponseBase).GetProperty("AdditionalProperties") == null)
                {
                    newUpdate1099Form200Response = new Update1099Form200Response(JsonConvert.DeserializeObject<FormResponseBase>(jsonString, Update1099Form200Response.SerializerSettings));
                }
                else
                {
                    newUpdate1099Form200Response = new Update1099Form200Response(JsonConvert.DeserializeObject<FormResponseBase>(jsonString, Update1099Form200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("FormResponseBase");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into FormResponseBase: {1}", jsonString, exception.ToString()));
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
            return newUpdate1099Form200Response;
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
    /// Custom JSON converter for Update1099Form200Response
    /// </summary>
    public class Update1099Form200ResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Update1099Form200Response).GetMethod("ToJson").Invoke(value, null)));
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
                    return Update1099Form200Response.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return Update1099Form200Response.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
