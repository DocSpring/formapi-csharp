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
    /// MoveTemplateData
    /// </summary>
    [DataContract]
    public partial class MoveTemplateData :  IEquatable<MoveTemplateData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoveTemplateData" /> class.
        /// </summary>
        /// <param name="parentFolderId">parentFolderId.</param>
        public MoveTemplateData(string parentFolderId = default(string))
        {
            this.ParentFolderId = parentFolderId;
        }
        
        /// <summary>
        /// Gets or Sets ParentFolderId
        /// </summary>
        [DataMember(Name="parent_folder_id", EmitDefaultValue=false)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MoveTemplateData {\n");
            sb.Append("  ParentFolderId: ").Append(ParentFolderId).Append("\n");
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
            return this.Equals(input as MoveTemplateData);
        }

        /// <summary>
        /// Returns true if MoveTemplateData instances are equal
        /// </summary>
        /// <param name="input">Instance of MoveTemplateData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MoveTemplateData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParentFolderId == input.ParentFolderId ||
                    (this.ParentFolderId != null &&
                    this.ParentFolderId.Equals(input.ParentFolderId))
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
                if (this.ParentFolderId != null)
                    hashCode = hashCode * 59 + this.ParentFolderId.GetHashCode();
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
