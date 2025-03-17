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
    /// Resource data model for /w9/forms API
    /// </summary>
    [JsonConverter(typeof(W9FormsPostRequestJsonConverter))]
    [DataContract(Name = "_w9_forms_post_request")]
    public partial class W9FormsPostRequest : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="W9FormsPostRequest" /> class
        /// with the <see cref="W4FormDataModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W4FormDataModel.</param>
        public W9FormsPostRequest(W4FormDataModel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="W9FormsPostRequest" /> class
        /// with the <see cref="W8BeneFormDataModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W8BeneFormDataModel.</param>
        public W9FormsPostRequest(W8BeneFormDataModel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="W9FormsPostRequest" /> class
        /// with the <see cref="W8BenFormDataModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W8BenFormDataModel.</param>
        public W9FormsPostRequest(W8BenFormDataModel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="W9FormsPostRequest" /> class
        /// with the <see cref="W8ImyFormDataModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W8ImyFormDataModel.</param>
        public W9FormsPostRequest(W8ImyFormDataModel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="W9FormsPostRequest" /> class
        /// with the <see cref="W9FormDataModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of W9FormDataModel.</param>
        public W9FormsPostRequest(W9FormDataModel actualInstance)
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
                if (value.GetType() == typeof(W4FormDataModel) || value is W4FormDataModel)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W8BenFormDataModel) || value is W8BenFormDataModel)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W8BeneFormDataModel) || value is W8BeneFormDataModel)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W8ImyFormDataModel) || value is W8ImyFormDataModel)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(W9FormDataModel) || value is W9FormDataModel)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: W4FormDataModel, W8BenFormDataModel, W8BeneFormDataModel, W8ImyFormDataModel, W9FormDataModel");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `W4FormDataModel`. If the actual instance is not `W4FormDataModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W4FormDataModel</returns>
        public W4FormDataModel GetW4FormDataModel()
        {
            return (W4FormDataModel)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W8BeneFormDataModel`. If the actual instance is not `W8BeneFormDataModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W8BeneFormDataModel</returns>
        public W8BeneFormDataModel GetW8BeneFormDataModel()
        {
            return (W8BeneFormDataModel)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W8BenFormDataModel`. If the actual instance is not `W8BenFormDataModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W8BenFormDataModel</returns>
        public W8BenFormDataModel GetW8BenFormDataModel()
        {
            return (W8BenFormDataModel)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W8ImyFormDataModel`. If the actual instance is not `W8ImyFormDataModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W8ImyFormDataModel</returns>
        public W8ImyFormDataModel GetW8ImyFormDataModel()
        {
            return (W8ImyFormDataModel)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `W9FormDataModel`. If the actual instance is not `W9FormDataModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of W9FormDataModel</returns>
        public W9FormDataModel GetW9FormDataModel()
        {
            return (W9FormDataModel)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class W9FormsPostRequest {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, W9FormsPostRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of W9FormsPostRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of W9FormsPostRequest</returns>
        public static W9FormsPostRequest FromJson(string jsonString)
        {
            W9FormsPostRequest newW9FormsPostRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newW9FormsPostRequest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W4FormDataModel).GetProperty("AdditionalProperties") == null)
                {
                    newW9FormsPostRequest = new W9FormsPostRequest(JsonConvert.DeserializeObject<W4FormDataModel>(jsonString, W9FormsPostRequest.SerializerSettings));
                }
                else
                {
                    newW9FormsPostRequest = new W9FormsPostRequest(JsonConvert.DeserializeObject<W4FormDataModel>(jsonString, W9FormsPostRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W4FormDataModel");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W4FormDataModel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W8BenFormDataModel).GetProperty("AdditionalProperties") == null)
                {
                    newW9FormsPostRequest = new W9FormsPostRequest(JsonConvert.DeserializeObject<W8BenFormDataModel>(jsonString, W9FormsPostRequest.SerializerSettings));
                }
                else
                {
                    newW9FormsPostRequest = new W9FormsPostRequest(JsonConvert.DeserializeObject<W8BenFormDataModel>(jsonString, W9FormsPostRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W8BenFormDataModel");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W8BenFormDataModel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W8BeneFormDataModel).GetProperty("AdditionalProperties") == null)
                {
                    newW9FormsPostRequest = new W9FormsPostRequest(JsonConvert.DeserializeObject<W8BeneFormDataModel>(jsonString, W9FormsPostRequest.SerializerSettings));
                }
                else
                {
                    newW9FormsPostRequest = new W9FormsPostRequest(JsonConvert.DeserializeObject<W8BeneFormDataModel>(jsonString, W9FormsPostRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W8BeneFormDataModel");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W8BeneFormDataModel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W8ImyFormDataModel).GetProperty("AdditionalProperties") == null)
                {
                    newW9FormsPostRequest = new W9FormsPostRequest(JsonConvert.DeserializeObject<W8ImyFormDataModel>(jsonString, W9FormsPostRequest.SerializerSettings));
                }
                else
                {
                    newW9FormsPostRequest = new W9FormsPostRequest(JsonConvert.DeserializeObject<W8ImyFormDataModel>(jsonString, W9FormsPostRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W8ImyFormDataModel");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W8ImyFormDataModel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(W9FormDataModel).GetProperty("AdditionalProperties") == null)
                {
                    newW9FormsPostRequest = new W9FormsPostRequest(JsonConvert.DeserializeObject<W9FormDataModel>(jsonString, W9FormsPostRequest.SerializerSettings));
                }
                else
                {
                    newW9FormsPostRequest = new W9FormsPostRequest(JsonConvert.DeserializeObject<W9FormDataModel>(jsonString, W9FormsPostRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("W9FormDataModel");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into W9FormDataModel: {1}", jsonString, exception.ToString()));
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
            return newW9FormsPostRequest;
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
    /// Custom JSON converter for W9FormsPostRequest
    /// </summary>
    public class W9FormsPostRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(W9FormsPostRequest).GetMethod("ToJson").Invoke(value, null)));
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
                    return W9FormsPostRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return W9FormsPostRequest.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
