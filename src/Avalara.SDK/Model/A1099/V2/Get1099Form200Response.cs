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
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Form1042S, Form1095B, Form1095C, Form1099Div, Form1099Int, Form1099K, Form1099Misc, Form1099Nec, Form1099R");
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
