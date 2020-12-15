using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LaunchDarkly.Api.Model {

  /// <summary>
  /// Approval settings for an environment. Only appears if the approvals feature is enabled.
  /// </summary>
  [DataContract]
  public class EnvironmentApprovalSettings {
    /// <summary>
    /// The approvals system used.
    /// </summary>
    /// <value>The approvals system used.</value>
    [DataMember(Name="serviceKind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceKind")]
    public string ServiceKind { get; set; }

    /// <summary>
    /// Whether any changes to flags in this environment will require approval.
    /// </summary>
    /// <value>Whether any changes to flags in this environment will require approval.</value>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public bool? Required { get; set; }

    /// <summary>
    /// Whether requesters can approve or decline their own request. They may always comment.
    /// </summary>
    /// <value>Whether requesters can approve or decline their own request. They may always comment.</value>
    [DataMember(Name="canReviewOwnRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canReviewOwnRequest")]
    public bool? CanReviewOwnRequest { get; set; }

    /// <summary>
    /// The number of approvals required before an approval request can be applied.
    /// </summary>
    /// <value>The number of approvals required before an approval request can be applied.</value>
    [DataMember(Name="minNumApprovals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minNumApprovals")]
    public long? MinNumApprovals { get; set; }

    /// <summary>
    /// Whether changes can be applied as long as minNumApprovals is met, regardless of if any reviewers have declined a request.
    /// </summary>
    /// <value>Whether changes can be applied as long as minNumApprovals is met, regardless of if any reviewers have declined a request.</value>
    [DataMember(Name="canApplyDeclinedChanges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canApplyDeclinedChanges")]
    public bool? CanApplyDeclinedChanges { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnvironmentApprovalSettings {\n");
      sb.Append("  ServiceKind: ").Append(ServiceKind).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  CanReviewOwnRequest: ").Append(CanReviewOwnRequest).Append("\n");
      sb.Append("  MinNumApprovals: ").Append(MinNumApprovals).Append("\n");
      sb.Append("  CanApplyDeclinedChanges: ").Append(CanApplyDeclinedChanges).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
