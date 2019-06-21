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
    /// PendingTemplate
    /// </summary>
    [DataContract]
    public partial class PendingTemplate :  IEquatable<PendingTemplate>, IValidatableObject
    {
        /// <summary>
        /// Defines ExpirationInterval
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExpirationIntervalEnum
        {
            /// <summary>
            /// Enum Minutes for value: minutes
            /// </summary>
            [EnumMember(Value = "minutes")]
            Minutes = 1,

            /// <summary>
            /// Enum Hours for value: hours
            /// </summary>
            [EnumMember(Value = "hours")]
            Hours = 2,

            /// <summary>
            /// Enum Days for value: days
            /// </summary>
            [EnumMember(Value = "days")]
            Days = 3

        }

        /// <summary>
        /// Gets or Sets ExpirationInterval
        /// </summary>
        [DataMember(Name="expiration_interval", EmitDefaultValue=false)]
        public ExpirationIntervalEnum? ExpirationInterval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PendingTemplate" /> class.
        /// </summary>
        /// <param name="expirationInterval">expirationInterval.</param>
        /// <param name="webhookUrl">webhookUrl.</param>
        /// <param name="expireAfter">expireAfter.</param>
        /// <param name="allowAdditionalProperties">allowAdditionalProperties.</param>
        /// <param name="publicSubmissions">publicSubmissions.</param>
        /// <param name="slackWebhookUrl">slackWebhookUrl.</param>
        /// <param name="publicWebForm">publicWebForm.</param>
        /// <param name="editableSubmissions">editableSubmissions.</param>
        /// <param name="expireSubmissions">expireSubmissions.</param>
        /// <param name="name">name.</param>
        /// <param name="templateType">templateType.</param>
        /// <param name="id">id.</param>
        /// <param name="redirectUrl">redirectUrl.</param>
        public PendingTemplate(ExpirationIntervalEnum? expirationInterval = default(ExpirationIntervalEnum?), string webhookUrl = default(string), decimal? expireAfter = default(decimal?), bool? allowAdditionalProperties = default(bool?), bool? publicSubmissions = default(bool?), string slackWebhookUrl = default(string), bool? publicWebForm = default(bool?), bool? editableSubmissions = default(bool?), bool? expireSubmissions = default(bool?), string name = default(string), string templateType = default(string), string id = default(string), string redirectUrl = default(string))
        {
            this.ExpirationInterval = expirationInterval;
            this.WebhookUrl = webhookUrl;
            this.ExpireAfter = expireAfter;
            this.AllowAdditionalProperties = allowAdditionalProperties;
            this.PublicSubmissions = publicSubmissions;
            this.SlackWebhookUrl = slackWebhookUrl;
            this.PublicWebForm = publicWebForm;
            this.EditableSubmissions = editableSubmissions;
            this.ExpireSubmissions = expireSubmissions;
            this.Name = name;
            this.TemplateType = templateType;
            this.Id = id;
            this.RedirectUrl = redirectUrl;
        }
        

        /// <summary>
        /// Gets or Sets WebhookUrl
        /// </summary>
        [DataMember(Name="webhook_url", EmitDefaultValue=false)]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Gets or Sets ExpireAfter
        /// </summary>
        [DataMember(Name="expire_after", EmitDefaultValue=false)]
        public decimal? ExpireAfter { get; set; }

        /// <summary>
        /// Gets or Sets AllowAdditionalProperties
        /// </summary>
        [DataMember(Name="allow_additional_properties", EmitDefaultValue=false)]
        public bool? AllowAdditionalProperties { get; set; }

        /// <summary>
        /// Gets or Sets PublicSubmissions
        /// </summary>
        [DataMember(Name="public_submissions", EmitDefaultValue=false)]
        public bool? PublicSubmissions { get; set; }

        /// <summary>
        /// Gets or Sets SlackWebhookUrl
        /// </summary>
        [DataMember(Name="slack_webhook_url", EmitDefaultValue=false)]
        public string SlackWebhookUrl { get; set; }

        /// <summary>
        /// Gets or Sets PublicWebForm
        /// </summary>
        [DataMember(Name="public_web_form", EmitDefaultValue=false)]
        public bool? PublicWebForm { get; set; }

        /// <summary>
        /// Gets or Sets EditableSubmissions
        /// </summary>
        [DataMember(Name="editable_submissions", EmitDefaultValue=false)]
        public bool? EditableSubmissions { get; set; }

        /// <summary>
        /// Gets or Sets ExpireSubmissions
        /// </summary>
        [DataMember(Name="expire_submissions", EmitDefaultValue=false)]
        public bool? ExpireSubmissions { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TemplateType
        /// </summary>
        [DataMember(Name="template_type", EmitDefaultValue=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets RedirectUrl
        /// </summary>
        [DataMember(Name="redirect_url", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PendingTemplate {\n");
            sb.Append("  ExpirationInterval: ").Append(ExpirationInterval).Append("\n");
            sb.Append("  WebhookUrl: ").Append(WebhookUrl).Append("\n");
            sb.Append("  ExpireAfter: ").Append(ExpireAfter).Append("\n");
            sb.Append("  AllowAdditionalProperties: ").Append(AllowAdditionalProperties).Append("\n");
            sb.Append("  PublicSubmissions: ").Append(PublicSubmissions).Append("\n");
            sb.Append("  SlackWebhookUrl: ").Append(SlackWebhookUrl).Append("\n");
            sb.Append("  PublicWebForm: ").Append(PublicWebForm).Append("\n");
            sb.Append("  EditableSubmissions: ").Append(EditableSubmissions).Append("\n");
            sb.Append("  ExpireSubmissions: ").Append(ExpireSubmissions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TemplateType: ").Append(TemplateType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
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
            return this.Equals(input as PendingTemplate);
        }

        /// <summary>
        /// Returns true if PendingTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of PendingTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PendingTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpirationInterval == input.ExpirationInterval ||
                    (this.ExpirationInterval != null &&
                    this.ExpirationInterval.Equals(input.ExpirationInterval))
                ) && 
                (
                    this.WebhookUrl == input.WebhookUrl ||
                    (this.WebhookUrl != null &&
                    this.WebhookUrl.Equals(input.WebhookUrl))
                ) && 
                (
                    this.ExpireAfter == input.ExpireAfter ||
                    (this.ExpireAfter != null &&
                    this.ExpireAfter.Equals(input.ExpireAfter))
                ) && 
                (
                    this.AllowAdditionalProperties == input.AllowAdditionalProperties ||
                    (this.AllowAdditionalProperties != null &&
                    this.AllowAdditionalProperties.Equals(input.AllowAdditionalProperties))
                ) && 
                (
                    this.PublicSubmissions == input.PublicSubmissions ||
                    (this.PublicSubmissions != null &&
                    this.PublicSubmissions.Equals(input.PublicSubmissions))
                ) && 
                (
                    this.SlackWebhookUrl == input.SlackWebhookUrl ||
                    (this.SlackWebhookUrl != null &&
                    this.SlackWebhookUrl.Equals(input.SlackWebhookUrl))
                ) && 
                (
                    this.PublicWebForm == input.PublicWebForm ||
                    (this.PublicWebForm != null &&
                    this.PublicWebForm.Equals(input.PublicWebForm))
                ) && 
                (
                    this.EditableSubmissions == input.EditableSubmissions ||
                    (this.EditableSubmissions != null &&
                    this.EditableSubmissions.Equals(input.EditableSubmissions))
                ) && 
                (
                    this.ExpireSubmissions == input.ExpireSubmissions ||
                    (this.ExpireSubmissions != null &&
                    this.ExpireSubmissions.Equals(input.ExpireSubmissions))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TemplateType == input.TemplateType ||
                    (this.TemplateType != null &&
                    this.TemplateType.Equals(input.TemplateType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
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
                if (this.ExpirationInterval != null)
                    hashCode = hashCode * 59 + this.ExpirationInterval.GetHashCode();
                if (this.WebhookUrl != null)
                    hashCode = hashCode * 59 + this.WebhookUrl.GetHashCode();
                if (this.ExpireAfter != null)
                    hashCode = hashCode * 59 + this.ExpireAfter.GetHashCode();
                if (this.AllowAdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AllowAdditionalProperties.GetHashCode();
                if (this.PublicSubmissions != null)
                    hashCode = hashCode * 59 + this.PublicSubmissions.GetHashCode();
                if (this.SlackWebhookUrl != null)
                    hashCode = hashCode * 59 + this.SlackWebhookUrl.GetHashCode();
                if (this.PublicWebForm != null)
                    hashCode = hashCode * 59 + this.PublicWebForm.GetHashCode();
                if (this.EditableSubmissions != null)
                    hashCode = hashCode * 59 + this.EditableSubmissions.GetHashCode();
                if (this.ExpireSubmissions != null)
                    hashCode = hashCode * 59 + this.ExpireSubmissions.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TemplateType != null)
                    hashCode = hashCode * 59 + this.TemplateType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
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
