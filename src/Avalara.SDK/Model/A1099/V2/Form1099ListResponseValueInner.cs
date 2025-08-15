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
    /// Form1099ListResponseValueInner
    /// </summary>
    [JsonConverter(typeof(Form1099ListResponseValueInnerJsonConverter))]
    [DataContract(Name = "Form1099ListResponse_value_inner")]
    public partial class Form1099ListResponseValueInner : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099ListResponseValueInner" /> class
        /// with the <see cref="Form1099BaseResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099BaseResponse.</param>
        public Form1099ListResponseValueInner(Form1099BaseResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099ListResponseValueInner" /> class
        /// with the <see cref="Form1042SListItemResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1042SListItemResponse.</param>
        public Form1099ListResponseValueInner(Form1042SListItemResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099ListResponseValueInner" /> class
        /// with the <see cref="Form1095BListItemResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1095BListItemResponse.</param>
        public Form1099ListResponseValueInner(Form1095BListItemResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099ListResponseValueInner" /> class
        /// with the <see cref="Form1099DivListItemResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099DivListItemResponse.</param>
        public Form1099ListResponseValueInner(Form1099DivListItemResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099ListResponseValueInner" /> class
        /// with the <see cref="Form1099IntListItemResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099IntListItemResponse.</param>
        public Form1099ListResponseValueInner(Form1099IntListItemResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099ListResponseValueInner" /> class
        /// with the <see cref="Form1099KListItemResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099KListItemResponse.</param>
        public Form1099ListResponseValueInner(Form1099KListItemResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099ListResponseValueInner" /> class
        /// with the <see cref="Form1099MiscListItemResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099MiscListItemResponse.</param>
        public Form1099ListResponseValueInner(Form1099MiscListItemResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099ListResponseValueInner" /> class
        /// with the <see cref="Form1099NecListItemResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099NecListItemResponse.</param>
        public Form1099ListResponseValueInner(Form1099NecListItemResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099ListResponseValueInner" /> class
        /// with the <see cref="Form1099RListItemResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099RListItemResponse.</param>
        public Form1099ListResponseValueInner(Form1099RListItemResponse actualInstance)
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
                if (value.GetType() == typeof(Form1042SListItemResponse) || value is Form1042SListItemResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1095BListItemResponse) || value is Form1095BListItemResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099BaseResponse) || value is Form1099BaseResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099DivListItemResponse) || value is Form1099DivListItemResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099IntListItemResponse) || value is Form1099IntListItemResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099KListItemResponse) || value is Form1099KListItemResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099MiscListItemResponse) || value is Form1099MiscListItemResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099NecListItemResponse) || value is Form1099NecListItemResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099RListItemResponse) || value is Form1099RListItemResponse)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Form1042SListItemResponse, Form1095BListItemResponse, Form1099BaseResponse, Form1099DivListItemResponse, Form1099IntListItemResponse, Form1099KListItemResponse, Form1099MiscListItemResponse, Form1099NecListItemResponse, Form1099RListItemResponse");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Form1099BaseResponse`. If the actual instance is not `Form1099BaseResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099BaseResponse</returns>
        public Form1099BaseResponse GetForm1099BaseResponse()
        {
            return (Form1099BaseResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1042SListItemResponse`. If the actual instance is not `Form1042SListItemResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1042SListItemResponse</returns>
        public Form1042SListItemResponse GetForm1042SListItemResponse()
        {
            return (Form1042SListItemResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1095BListItemResponse`. If the actual instance is not `Form1095BListItemResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1095BListItemResponse</returns>
        public Form1095BListItemResponse GetForm1095BListItemResponse()
        {
            return (Form1095BListItemResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099DivListItemResponse`. If the actual instance is not `Form1099DivListItemResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099DivListItemResponse</returns>
        public Form1099DivListItemResponse GetForm1099DivListItemResponse()
        {
            return (Form1099DivListItemResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099IntListItemResponse`. If the actual instance is not `Form1099IntListItemResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099IntListItemResponse</returns>
        public Form1099IntListItemResponse GetForm1099IntListItemResponse()
        {
            return (Form1099IntListItemResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099KListItemResponse`. If the actual instance is not `Form1099KListItemResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099KListItemResponse</returns>
        public Form1099KListItemResponse GetForm1099KListItemResponse()
        {
            return (Form1099KListItemResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099MiscListItemResponse`. If the actual instance is not `Form1099MiscListItemResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099MiscListItemResponse</returns>
        public Form1099MiscListItemResponse GetForm1099MiscListItemResponse()
        {
            return (Form1099MiscListItemResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099NecListItemResponse`. If the actual instance is not `Form1099NecListItemResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099NecListItemResponse</returns>
        public Form1099NecListItemResponse GetForm1099NecListItemResponse()
        {
            return (Form1099NecListItemResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099RListItemResponse`. If the actual instance is not `Form1099RListItemResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099RListItemResponse</returns>
        public Form1099RListItemResponse GetForm1099RListItemResponse()
        {
            return (Form1099RListItemResponse)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Form1099ListResponseValueInner {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, Form1099ListResponseValueInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Form1099ListResponseValueInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Form1099ListResponseValueInner</returns>
        public static Form1099ListResponseValueInner FromJson(string jsonString)
        {
            Form1099ListResponseValueInner newForm1099ListResponseValueInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newForm1099ListResponseValueInner;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1042SListItemResponse).GetProperty("AdditionalProperties") == null)
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1042SListItemResponse>(jsonString, Form1099ListResponseValueInner.SerializerSettings));
                }
                else
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1042SListItemResponse>(jsonString, Form1099ListResponseValueInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1042SListItemResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1042SListItemResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1095BListItemResponse).GetProperty("AdditionalProperties") == null)
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1095BListItemResponse>(jsonString, Form1099ListResponseValueInner.SerializerSettings));
                }
                else
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1095BListItemResponse>(jsonString, Form1099ListResponseValueInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1095BListItemResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1095BListItemResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099BaseResponse).GetProperty("AdditionalProperties") == null)
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1099BaseResponse>(jsonString, Form1099ListResponseValueInner.SerializerSettings));
                }
                else
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1099BaseResponse>(jsonString, Form1099ListResponseValueInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099BaseResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099BaseResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099DivListItemResponse).GetProperty("AdditionalProperties") == null)
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1099DivListItemResponse>(jsonString, Form1099ListResponseValueInner.SerializerSettings));
                }
                else
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1099DivListItemResponse>(jsonString, Form1099ListResponseValueInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099DivListItemResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099DivListItemResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099IntListItemResponse).GetProperty("AdditionalProperties") == null)
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1099IntListItemResponse>(jsonString, Form1099ListResponseValueInner.SerializerSettings));
                }
                else
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1099IntListItemResponse>(jsonString, Form1099ListResponseValueInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099IntListItemResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099IntListItemResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099KListItemResponse).GetProperty("AdditionalProperties") == null)
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1099KListItemResponse>(jsonString, Form1099ListResponseValueInner.SerializerSettings));
                }
                else
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1099KListItemResponse>(jsonString, Form1099ListResponseValueInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099KListItemResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099KListItemResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099MiscListItemResponse).GetProperty("AdditionalProperties") == null)
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1099MiscListItemResponse>(jsonString, Form1099ListResponseValueInner.SerializerSettings));
                }
                else
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1099MiscListItemResponse>(jsonString, Form1099ListResponseValueInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099MiscListItemResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099MiscListItemResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099NecListItemResponse).GetProperty("AdditionalProperties") == null)
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1099NecListItemResponse>(jsonString, Form1099ListResponseValueInner.SerializerSettings));
                }
                else
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1099NecListItemResponse>(jsonString, Form1099ListResponseValueInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099NecListItemResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099NecListItemResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099RListItemResponse).GetProperty("AdditionalProperties") == null)
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1099RListItemResponse>(jsonString, Form1099ListResponseValueInner.SerializerSettings));
                }
                else
                {
                    newForm1099ListResponseValueInner = new Form1099ListResponseValueInner(JsonConvert.DeserializeObject<Form1099RListItemResponse>(jsonString, Form1099ListResponseValueInner.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099RListItemResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099RListItemResponse: {1}", jsonString, exception.ToString()));
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
            return newForm1099ListResponseValueInner;
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
    /// Custom JSON converter for Form1099ListResponseValueInner
    /// </summary>
    public class Form1099ListResponseValueInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Form1099ListResponseValueInner).GetMethod("ToJson").Invoke(value, null)));
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
                    return Form1099ListResponseValueInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return Form1099ListResponseValueInner.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
