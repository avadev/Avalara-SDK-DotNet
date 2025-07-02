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
    /// IUpdateForm1099Request
    /// </summary>
    [JsonConverter(typeof(IUpdateForm1099RequestJsonConverter))]
    [DataContract(Name = "IUpdateForm1099Request")]
    public partial class IUpdateForm1099Request : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IUpdateForm1099Request" /> class
        /// with the <see cref="Form1099DivRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099DivRequest.</param>
        public IUpdateForm1099Request(Form1099DivRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IUpdateForm1099Request" /> class
        /// with the <see cref="Form1099MiscRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099MiscRequest.</param>
        public IUpdateForm1099Request(Form1099MiscRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IUpdateForm1099Request" /> class
        /// with the <see cref="Form1099NecRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Form1099NecRequest.</param>
        public IUpdateForm1099Request(Form1099NecRequest actualInstance)
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
                if (value.GetType() == typeof(Form1099DivRequest) || value is Form1099DivRequest)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099MiscRequest) || value is Form1099MiscRequest)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Form1099NecRequest) || value is Form1099NecRequest)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Form1099DivRequest, Form1099MiscRequest, Form1099NecRequest");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Form1099DivRequest`. If the actual instance is not `Form1099DivRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099DivRequest</returns>
        public Form1099DivRequest GetForm1099DivRequest()
        {
            return (Form1099DivRequest)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099MiscRequest`. If the actual instance is not `Form1099MiscRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099MiscRequest</returns>
        public Form1099MiscRequest GetForm1099MiscRequest()
        {
            return (Form1099MiscRequest)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Form1099NecRequest`. If the actual instance is not `Form1099NecRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Form1099NecRequest</returns>
        public Form1099NecRequest GetForm1099NecRequest()
        {
            return (Form1099NecRequest)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IUpdateForm1099Request {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, IUpdateForm1099Request.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of IUpdateForm1099Request
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of IUpdateForm1099Request</returns>
        public static IUpdateForm1099Request FromJson(string jsonString)
        {
            IUpdateForm1099Request newIUpdateForm1099Request = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newIUpdateForm1099Request;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099DivRequest).GetProperty("AdditionalProperties") == null)
                {
                    newIUpdateForm1099Request = new IUpdateForm1099Request(JsonConvert.DeserializeObject<Form1099DivRequest>(jsonString, IUpdateForm1099Request.SerializerSettings));
                }
                else
                {
                    newIUpdateForm1099Request = new IUpdateForm1099Request(JsonConvert.DeserializeObject<Form1099DivRequest>(jsonString, IUpdateForm1099Request.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099DivRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099DivRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099MiscRequest).GetProperty("AdditionalProperties") == null)
                {
                    newIUpdateForm1099Request = new IUpdateForm1099Request(JsonConvert.DeserializeObject<Form1099MiscRequest>(jsonString, IUpdateForm1099Request.SerializerSettings));
                }
                else
                {
                    newIUpdateForm1099Request = new IUpdateForm1099Request(JsonConvert.DeserializeObject<Form1099MiscRequest>(jsonString, IUpdateForm1099Request.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099MiscRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099MiscRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Form1099NecRequest).GetProperty("AdditionalProperties") == null)
                {
                    newIUpdateForm1099Request = new IUpdateForm1099Request(JsonConvert.DeserializeObject<Form1099NecRequest>(jsonString, IUpdateForm1099Request.SerializerSettings));
                }
                else
                {
                    newIUpdateForm1099Request = new IUpdateForm1099Request(JsonConvert.DeserializeObject<Form1099NecRequest>(jsonString, IUpdateForm1099Request.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Form1099NecRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Form1099NecRequest: {1}", jsonString, exception.ToString()));
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
            return newIUpdateForm1099Request;
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
    /// Custom JSON converter for IUpdateForm1099Request
    /// </summary>
    public class IUpdateForm1099RequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(IUpdateForm1099Request).GetMethod("ToJson").Invoke(value, null)));
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
                    return IUpdateForm1099Request.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return IUpdateForm1099Request.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
