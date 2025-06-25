/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara 1099 API Definition
 *
 * ## Authentication Use **username/password** or **generate a license** key from: Avalara Portal → Settings → License and API Keys  More info on authentication: [Avalara Authentication Methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  Validate your credentials here: [Test Credentials](https://developer.avalara.com/avatax/test-credentials/)  ## API & SDK Docs [Avalara (C#/.NET) SDK on GitHub](https://github.com/avadev/Avalara-SDK-DotNet/tree/main#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples for 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
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
    /// 1099 form
    /// </summary>
    [JsonConverter(typeof(Form1099OneOfJsonConverter))]
    [DataContract(Name = "Form1099OneOf")]
    public partial class Form1099OneOf : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099OneOf" /> class
        /// with the <see cref="Form1099NecModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099NecModel.</param>
        public Form1099OneOf(Form1099NecModel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099OneOf" /> class
        /// with the <see cref="Form1099MiscModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099MiscModel.</param>
        public Form1099OneOf(Form1099MiscModel actualInstance)
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
                if (value.GetType() == typeof(Form1099MiscModel) || value is Form1099MiscModel)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099NecModel) || value is Form1099NecModel)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Form1099MiscModel, Form1099NecModel");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Form1099NecModel`. If the actual instance is not `Form1099NecModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099NecModel</returns>
        public Form1099NecModel GetForm1099NecModel()
        {
            return (Form1099NecModel)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099MiscModel`. If the actual instance is not `Form1099MiscModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099MiscModel</returns>
        public Form1099MiscModel GetForm1099MiscModel()
        {
            return (Form1099MiscModel)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Form1099OneOf {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, Form1099OneOf.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Form1099OneOf
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Form1099OneOf</returns>
        public static Form1099OneOf FromJson(string jsonString)
        {
            Form1099OneOf newForm1099OneOf = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newForm1099OneOf;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099MiscModel).GetProperty("AdditionalProperties") == null)
                {
                    newForm1099OneOf = new Form1099OneOf(JsonConvert.DeserializeObject<Form1099MiscModel>(jsonString, Form1099OneOf.SerializerSettings));
                }
                else
                {
                    newForm1099OneOf = new Form1099OneOf(JsonConvert.DeserializeObject<Form1099MiscModel>(jsonString, Form1099OneOf.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099MiscModel");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099MiscModel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099NecModel).GetProperty("AdditionalProperties") == null)
                {
                    newForm1099OneOf = new Form1099OneOf(JsonConvert.DeserializeObject<Form1099NecModel>(jsonString, Form1099OneOf.SerializerSettings));
                }
                else
                {
                    newForm1099OneOf = new Form1099OneOf(JsonConvert.DeserializeObject<Form1099NecModel>(jsonString, Form1099OneOf.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099NecModel");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099NecModel: {1}", jsonString, exception.ToString()));
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
            return newForm1099OneOf;
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
    /// Custom JSON converter for Form1099OneOf
    /// </summary>
    public class Form1099OneOfJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Form1099OneOf).GetMethod("ToJson").Invoke(value, null)));
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
                    return Form1099OneOf.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return Form1099OneOf.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
