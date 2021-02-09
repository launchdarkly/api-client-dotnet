using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LaunchDarkly.Api.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ApprovalRequestConfigBody {
    /// <summary>
    /// A name that describes the changes you would like to apply to a feature flag configuration
    /// </summary>
    /// <value>A name that describes the changes you would like to apply to a feature flag configuration</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Instructions
    /// </summary>
    [DataMember(Name="instructions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instructions")]
    public SemanticPatchInstruction Instructions { get; set; }

    /// <summary>
    /// Gets or Sets NotifyMemberIds
    /// </summary>
    [DataMember(Name="notifyMemberIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notifyMemberIds")]
    public List<string> NotifyMemberIds { get; set; }

    /// <summary>
    /// comment will be included in audit log item for change.
    /// </summary>
    /// <value>comment will be included in audit log item for change.</value>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApprovalRequestConfigBody {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Instructions: ").Append(Instructions).Append("\n");
      sb.Append("  NotifyMemberIds: ").Append(NotifyMemberIds).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
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
