/* 
 * API v1
 *
 * FormAPI is a service that helps you fill out and sign PDF templates.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = FormApi.Client.Client.OpenAPIDateConverter;

namespace FormApi.Client.Model
{
    /// <summary>
    /// Templatesv2TemplateDocument
    /// </summary>
    [DataContract]
    public partial class Templatesv2TemplateDocument :  IEquatable<Templatesv2TemplateDocument>, IValidatableObject
    {
        /// <summary>
        /// Defines Storage
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StorageEnum
        {
            /// <summary>
            /// Enum Cache for value: cache
            /// </summary>
            [EnumMember(Value = "cache")]
            Cache = 1

        }

        /// <summary>
        /// Gets or Sets Storage
        /// </summary>
        [DataMember(Name="storage", EmitDefaultValue=false)]
        public StorageEnum? Storage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Templatesv2TemplateDocument" /> class.
        /// </summary>
        /// <param name="metadata">metadata.</param>
        /// <param name="id">id.</param>
        /// <param name="storage">storage.</param>
        public Templatesv2TemplateDocument(Templatesv2TemplateDocumentMetadata metadata = default(Templatesv2TemplateDocumentMetadata), string id = default(string), StorageEnum? storage = default(StorageEnum?))
        {
            this.Metadata = metadata;
            this.Id = id;
            this.Storage = storage;
        }
        
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Templatesv2TemplateDocumentMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Templatesv2TemplateDocument {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Storage: ").Append(Storage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Templatesv2TemplateDocument);
        }

        /// <summary>
        /// Returns true if Templatesv2TemplateDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of Templatesv2TemplateDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Templatesv2TemplateDocument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Storage == input.Storage ||
                    (this.Storage != null &&
                    this.Storage.Equals(input.Storage))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Storage != null)
                    hashCode = hashCode * 59 + this.Storage.GetHashCode();
                return hashCode;
            }
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

}
