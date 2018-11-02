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
    /// SubmissionBatch
    /// </summary>
    [DataContract]
    public partial class SubmissionBatch :  IEquatable<SubmissionBatch>, IValidatableObject
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,

            /// <summary>
            /// Enum Processed for value: processed
            /// </summary>
            [EnumMember(Value = "processed")]
            Processed = 2,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 3

        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmissionBatch" /> class.
        /// </summary>
        /// <param name="pendingCount">pendingCount.</param>
        /// <param name="completionPercentage">completionPercentage.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="totalCount">totalCount.</param>
        /// <param name="submissions">submissions.</param>
        /// <param name="processedAt">processedAt.</param>
        /// <param name="id">id.</param>
        /// <param name="state">state.</param>
        /// <param name="errorCount">errorCount.</param>
        public SubmissionBatch(int? pendingCount = default(int?), int? completionPercentage = default(int?), Object metadata = default(Object), int? totalCount = default(int?), List<Submission> submissions = default(List<Submission>), string processedAt = default(string), string id = default(string), StateEnum? state = default(StateEnum?), int? errorCount = default(int?))
        {
            this.PendingCount = pendingCount;
            this.CompletionPercentage = completionPercentage;
            this.Metadata = metadata;
            this.TotalCount = totalCount;
            this.Submissions = submissions;
            this.ProcessedAt = processedAt;
            this.Id = id;
            this.State = state;
            this.ErrorCount = errorCount;
        }
        
        /// <summary>
        /// Gets or Sets PendingCount
        /// </summary>
        [DataMember(Name="pending_count", EmitDefaultValue=false)]
        public int? PendingCount { get; set; }

        /// <summary>
        /// Gets or Sets CompletionPercentage
        /// </summary>
        [DataMember(Name="completion_percentage", EmitDefaultValue=false)]
        public int? CompletionPercentage { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Gets or Sets Submissions
        /// </summary>
        [DataMember(Name="submissions", EmitDefaultValue=false)]
        public List<Submission> Submissions { get; set; }

        /// <summary>
        /// Gets or Sets ProcessedAt
        /// </summary>
        [DataMember(Name="processed_at", EmitDefaultValue=false)]
        public string ProcessedAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Gets or Sets ErrorCount
        /// </summary>
        [DataMember(Name="error_count", EmitDefaultValue=false)]
        public int? ErrorCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmissionBatch {\n");
            sb.Append("  PendingCount: ").Append(PendingCount).Append("\n");
            sb.Append("  CompletionPercentage: ").Append(CompletionPercentage).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  Submissions: ").Append(Submissions).Append("\n");
            sb.Append("  ProcessedAt: ").Append(ProcessedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
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
            return this.Equals(input as SubmissionBatch);
        }

        /// <summary>
        /// Returns true if SubmissionBatch instances are equal
        /// </summary>
        /// <param name="input">Instance of SubmissionBatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmissionBatch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PendingCount == input.PendingCount ||
                    (this.PendingCount != null &&
                    this.PendingCount.Equals(input.PendingCount))
                ) && 
                (
                    this.CompletionPercentage == input.CompletionPercentage ||
                    (this.CompletionPercentage != null &&
                    this.CompletionPercentage.Equals(input.CompletionPercentage))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.Submissions == input.Submissions ||
                    this.Submissions != null &&
                    this.Submissions.SequenceEqual(input.Submissions)
                ) && 
                (
                    this.ProcessedAt == input.ProcessedAt ||
                    (this.ProcessedAt != null &&
                    this.ProcessedAt.Equals(input.ProcessedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.ErrorCount == input.ErrorCount ||
                    (this.ErrorCount != null &&
                    this.ErrorCount.Equals(input.ErrorCount))
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
                if (this.PendingCount != null)
                    hashCode = hashCode * 59 + this.PendingCount.GetHashCode();
                if (this.CompletionPercentage != null)
                    hashCode = hashCode * 59 + this.CompletionPercentage.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.Submissions != null)
                    hashCode = hashCode * 59 + this.Submissions.GetHashCode();
                if (this.ProcessedAt != null)
                    hashCode = hashCode * 59 + this.ProcessedAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ErrorCount != null)
                    hashCode = hashCode * 59 + this.ErrorCount.GetHashCode();
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
