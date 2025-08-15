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
    /// BulkUpsert1099FormsRequest
    /// </summary>
    [JsonConverter(typeof(BulkUpsert1099FormsRequestJsonConverter))]
    [DataContract(Name = "BulkUpsert1099Forms_request")]
    public partial class BulkUpsert1099FormsRequest : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpsert1099FormsRequest" /> class
        /// with the <see cref="Form1042SList" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1042SList.</param>
        public BulkUpsert1099FormsRequest(Form1042SList actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpsert1099FormsRequest" /> class
        /// with the <see cref="Form1095BList" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1095BList.</param>
        public BulkUpsert1099FormsRequest(Form1095BList actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpsert1099FormsRequest" /> class
        /// with the <see cref="Form1095CList" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1095CList.</param>
        public BulkUpsert1099FormsRequest(Form1095CList actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpsert1099FormsRequest" /> class
        /// with the <see cref="Form1099DivList" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099DivList.</param>
        public BulkUpsert1099FormsRequest(Form1099DivList actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpsert1099FormsRequest" /> class
        /// with the <see cref="Form1099IntList" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099IntList.</param>
        public BulkUpsert1099FormsRequest(Form1099IntList actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpsert1099FormsRequest" /> class
        /// with the <see cref="Form1099KList" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099KList.</param>
        public BulkUpsert1099FormsRequest(Form1099KList actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpsert1099FormsRequest" /> class
        /// with the <see cref="Form1099MiscList" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099MiscList.</param>
        public BulkUpsert1099FormsRequest(Form1099MiscList actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpsert1099FormsRequest" /> class
        /// with the <see cref="Form1099NecList" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099NecList.</param>
        public BulkUpsert1099FormsRequest(Form1099NecList actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpsert1099FormsRequest" /> class
        /// with the <see cref="Form1099RList" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099RList.</param>
        public BulkUpsert1099FormsRequest(Form1099RList actualInstance)
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
                if (value.GetType() == typeof(Form1042SList) || value is Form1042SList)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1095BList) || value is Form1095BList)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1095CList) || value is Form1095CList)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099DivList) || value is Form1099DivList)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099IntList) || value is Form1099IntList)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099KList) || value is Form1099KList)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099MiscList) || value is Form1099MiscList)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099NecList) || value is Form1099NecList)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099RList) || value is Form1099RList)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Form1042SList, Form1095BList, Form1095CList, Form1099DivList, Form1099IntList, Form1099KList, Form1099MiscList, Form1099NecList, Form1099RList");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Form1042SList`. If the actual instance is not `Form1042SList`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1042SList</returns>
        public Form1042SList GetForm1042SList()
        {
            return (Form1042SList)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1095BList`. If the actual instance is not `Form1095BList`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1095BList</returns>
        public Form1095BList GetForm1095BList()
        {
            return (Form1095BList)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1095CList`. If the actual instance is not `Form1095CList`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1095CList</returns>
        public Form1095CList GetForm1095CList()
        {
            return (Form1095CList)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099DivList`. If the actual instance is not `Form1099DivList`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099DivList</returns>
        public Form1099DivList GetForm1099DivList()
        {
            return (Form1099DivList)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099IntList`. If the actual instance is not `Form1099IntList`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099IntList</returns>
        public Form1099IntList GetForm1099IntList()
        {
            return (Form1099IntList)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099KList`. If the actual instance is not `Form1099KList`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099KList</returns>
        public Form1099KList GetForm1099KList()
        {
            return (Form1099KList)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099MiscList`. If the actual instance is not `Form1099MiscList`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099MiscList</returns>
        public Form1099MiscList GetForm1099MiscList()
        {
            return (Form1099MiscList)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099NecList`. If the actual instance is not `Form1099NecList`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099NecList</returns>
        public Form1099NecList GetForm1099NecList()
        {
            return (Form1099NecList)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099RList`. If the actual instance is not `Form1099RList`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099RList</returns>
        public Form1099RList GetForm1099RList()
        {
            return (Form1099RList)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkUpsert1099FormsRequest {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, BulkUpsert1099FormsRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of BulkUpsert1099FormsRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of BulkUpsert1099FormsRequest</returns>
        public static BulkUpsert1099FormsRequest FromJson(string jsonString)
        {
            BulkUpsert1099FormsRequest newBulkUpsert1099FormsRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newBulkUpsert1099FormsRequest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1042SList).GetProperty("AdditionalProperties") == null)
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1042SList>(jsonString, BulkUpsert1099FormsRequest.SerializerSettings));
                }
                else
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1042SList>(jsonString, BulkUpsert1099FormsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1042SList");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1042SList: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1095BList).GetProperty("AdditionalProperties") == null)
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1095BList>(jsonString, BulkUpsert1099FormsRequest.SerializerSettings));
                }
                else
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1095BList>(jsonString, BulkUpsert1099FormsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1095BList");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1095BList: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1095CList).GetProperty("AdditionalProperties") == null)
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1095CList>(jsonString, BulkUpsert1099FormsRequest.SerializerSettings));
                }
                else
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1095CList>(jsonString, BulkUpsert1099FormsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1095CList");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1095CList: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099DivList).GetProperty("AdditionalProperties") == null)
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099DivList>(jsonString, BulkUpsert1099FormsRequest.SerializerSettings));
                }
                else
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099DivList>(jsonString, BulkUpsert1099FormsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099DivList");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099DivList: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099IntList).GetProperty("AdditionalProperties") == null)
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099IntList>(jsonString, BulkUpsert1099FormsRequest.SerializerSettings));
                }
                else
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099IntList>(jsonString, BulkUpsert1099FormsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099IntList");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099IntList: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099KList).GetProperty("AdditionalProperties") == null)
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099KList>(jsonString, BulkUpsert1099FormsRequest.SerializerSettings));
                }
                else
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099KList>(jsonString, BulkUpsert1099FormsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099KList");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099KList: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099MiscList).GetProperty("AdditionalProperties") == null)
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099MiscList>(jsonString, BulkUpsert1099FormsRequest.SerializerSettings));
                }
                else
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099MiscList>(jsonString, BulkUpsert1099FormsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099MiscList");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099MiscList: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099NecList).GetProperty("AdditionalProperties") == null)
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099NecList>(jsonString, BulkUpsert1099FormsRequest.SerializerSettings));
                }
                else
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099NecList>(jsonString, BulkUpsert1099FormsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099NecList");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099NecList: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099RList).GetProperty("AdditionalProperties") == null)
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099RList>(jsonString, BulkUpsert1099FormsRequest.SerializerSettings));
                }
                else
                {
                    newBulkUpsert1099FormsRequest = new BulkUpsert1099FormsRequest(JsonConvert.DeserializeObject<Form1099RList>(jsonString, BulkUpsert1099FormsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099RList");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099RList: {1}", jsonString, exception.ToString()));
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
            return newBulkUpsert1099FormsRequest;
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
    /// Custom JSON converter for BulkUpsert1099FormsRequest
    /// </summary>
    public class BulkUpsert1099FormsRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(BulkUpsert1099FormsRequest).GetMethod("ToJson").Invoke(value, null)));
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
                    return BulkUpsert1099FormsRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return BulkUpsert1099FormsRequest.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
