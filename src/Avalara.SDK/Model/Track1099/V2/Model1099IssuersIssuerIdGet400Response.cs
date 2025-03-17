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
 * This is the API specification for Avalara's Track 1099 service, based on the OpenAPI 3.0 standard. The API allows users to manage and track 1099 tax forms efficiently. This is the specification for the Avalara 1099 & W9 API. Some overall notes about the API:  - The API generally follows the [JSON:API](https://jsonapi.org/) specification. - Authentication is done by including an API **Bearer** token in the **Authorization** header (API tokens can be generated from your [profile page](https://www.track1099.com/api_tokens) when logged into the application). - The maximum request size allowed is **100MB**.  [Find out more about Avalara](https://www.avalara.com)
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

namespace Avalara.SDK.Model.Track1099.V2
{
    /// <summary>
    /// Model1099IssuersIssuerIdGet400Response
    /// </summary>
    [JsonConverter(typeof(Model1099IssuersIssuerIdGet400ResponseJsonConverter))]
    [DataContract(Name = "_1099_issuers__issuerId__get_400_response")]
    public partial class Model1099IssuersIssuerIdGet400Response : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Model1099IssuersIssuerIdGet400Response" /> class
        /// with the <see cref="ProblemDetails" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ProblemDetails.</param>
        public Model1099IssuersIssuerIdGet400Response(ProblemDetails actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model1099IssuersIssuerIdGet400Response" /> class
        /// with the <see cref="HttpValidationProblemDetails" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of HttpValidationProblemDetails.</param>
        public Model1099IssuersIssuerIdGet400Response(HttpValidationProblemDetails actualInstance)
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
                if (value.GetType() == typeof(HttpValidationProblemDetails) || value is HttpValidationProblemDetails)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ProblemDetails) || value is ProblemDetails)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: HttpValidationProblemDetails, ProblemDetails");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ProblemDetails`. If the actual instance is not `ProblemDetails`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ProblemDetails</returns>
        public ProblemDetails GetProblemDetails()
        {
            return (ProblemDetails)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `HttpValidationProblemDetails`. If the actual instance is not `HttpValidationProblemDetails`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of HttpValidationProblemDetails</returns>
        public HttpValidationProblemDetails GetHttpValidationProblemDetails()
        {
            return (HttpValidationProblemDetails)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Model1099IssuersIssuerIdGet400Response {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, Model1099IssuersIssuerIdGet400Response.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Model1099IssuersIssuerIdGet400Response
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Model1099IssuersIssuerIdGet400Response</returns>
        public static Model1099IssuersIssuerIdGet400Response FromJson(string jsonString)
        {
            Model1099IssuersIssuerIdGet400Response newModel1099IssuersIssuerIdGet400Response = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newModel1099IssuersIssuerIdGet400Response;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(HttpValidationProblemDetails).GetProperty("AdditionalProperties") == null)
                {
                    newModel1099IssuersIssuerIdGet400Response = new Model1099IssuersIssuerIdGet400Response(JsonConvert.DeserializeObject<HttpValidationProblemDetails>(jsonString, Model1099IssuersIssuerIdGet400Response.SerializerSettings));
                }
                else
                {
                    newModel1099IssuersIssuerIdGet400Response = new Model1099IssuersIssuerIdGet400Response(JsonConvert.DeserializeObject<HttpValidationProblemDetails>(jsonString, Model1099IssuersIssuerIdGet400Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("HttpValidationProblemDetails");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into HttpValidationProblemDetails: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ProblemDetails).GetProperty("AdditionalProperties") == null)
                {
                    newModel1099IssuersIssuerIdGet400Response = new Model1099IssuersIssuerIdGet400Response(JsonConvert.DeserializeObject<ProblemDetails>(jsonString, Model1099IssuersIssuerIdGet400Response.SerializerSettings));
                }
                else
                {
                    newModel1099IssuersIssuerIdGet400Response = new Model1099IssuersIssuerIdGet400Response(JsonConvert.DeserializeObject<ProblemDetails>(jsonString, Model1099IssuersIssuerIdGet400Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ProblemDetails");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ProblemDetails: {1}", jsonString, exception.ToString()));
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
            return newModel1099IssuersIssuerIdGet400Response;
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
    /// Custom JSON converter for Model1099IssuersIssuerIdGet400Response
    /// </summary>
    public class Model1099IssuersIssuerIdGet400ResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Model1099IssuersIssuerIdGet400Response).GetMethod("ToJson").Invoke(value, null)));
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
                    return Model1099IssuersIssuerIdGet400Response.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return Model1099IssuersIssuerIdGet400Response.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
