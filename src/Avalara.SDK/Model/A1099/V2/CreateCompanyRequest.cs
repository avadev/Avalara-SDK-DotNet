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
    /// CreateCompanyRequest
    /// </summary>
    [JsonConverter(typeof(CreateCompanyRequestJsonConverter))]
    [DataContract(Name = "CreateCompany_request")]
    public partial class CreateCompanyRequest : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompanyRequest" /> class
        /// with the <see cref="CompanyCreateUpdateRequestModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CompanyCreateUpdateRequestModel.</param>
        public CreateCompanyRequest(CompanyCreateUpdateRequestModel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompanyRequest" /> class
        /// with the <see cref="CompanyResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CompanyResponse.</param>
        public CreateCompanyRequest(CompanyResponse actualInstance)
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
                if (value.GetType() == typeof(CompanyCreateUpdateRequestModel) || value is CompanyCreateUpdateRequestModel)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CompanyResponse) || value is CompanyResponse)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: CompanyCreateUpdateRequestModel, CompanyResponse");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `CompanyCreateUpdateRequestModel`. If the actual instance is not `CompanyCreateUpdateRequestModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CompanyCreateUpdateRequestModel</returns>
        public CompanyCreateUpdateRequestModel GetCompanyCreateUpdateRequestModel()
        {
            return (CompanyCreateUpdateRequestModel)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CompanyResponse`. If the actual instance is not `CompanyResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CompanyResponse</returns>
        public CompanyResponse GetCompanyResponse()
        {
            return (CompanyResponse)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCompanyRequest {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, CreateCompanyRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CreateCompanyRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CreateCompanyRequest</returns>
        public static CreateCompanyRequest FromJson(string jsonString)
        {
            CreateCompanyRequest newCreateCompanyRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCreateCompanyRequest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CompanyCreateUpdateRequestModel).GetProperty("AdditionalProperties") == null)
                {
                    newCreateCompanyRequest = new CreateCompanyRequest(JsonConvert.DeserializeObject<CompanyCreateUpdateRequestModel>(jsonString, CreateCompanyRequest.SerializerSettings));
                }
                else
                {
                    newCreateCompanyRequest = new CreateCompanyRequest(JsonConvert.DeserializeObject<CompanyCreateUpdateRequestModel>(jsonString, CreateCompanyRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CompanyCreateUpdateRequestModel");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CompanyCreateUpdateRequestModel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CompanyResponse).GetProperty("AdditionalProperties") == null)
                {
                    newCreateCompanyRequest = new CreateCompanyRequest(JsonConvert.DeserializeObject<CompanyResponse>(jsonString, CreateCompanyRequest.SerializerSettings));
                }
                else
                {
                    newCreateCompanyRequest = new CreateCompanyRequest(JsonConvert.DeserializeObject<CompanyResponse>(jsonString, CreateCompanyRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CompanyResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CompanyResponse: {1}", jsonString, exception.ToString()));
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
            return newCreateCompanyRequest;
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
    /// Custom JSON converter for CreateCompanyRequest
    /// </summary>
    public class CreateCompanyRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CreateCompanyRequest).GetMethod("ToJson").Invoke(value, null)));
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
                    return CreateCompanyRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return CreateCompanyRequest.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
