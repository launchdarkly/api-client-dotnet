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
  public class FeatureFlagCopyBody {
    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public FeatureFlagCopyObject Source { get; set; }

    /// <summary>
    /// Gets or Sets Target
    /// </summary>
    [DataMember(Name="target", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target")]
    public FeatureFlagCopyObject Target { get; set; }

    /// <summary>
    /// comment will be included in audit log item for change.
    /// </summary>
    /// <value>comment will be included in audit log item for change.</value>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Define the parts of the flag configuration that will be copied.
    /// </summary>
    /// <value>Define the parts of the flag configuration that will be copied.</value>
    [DataMember(Name="includedActions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includedActions")]
    public List<CopyActions> IncludedActions { get; set; }

    /// <summary>
    /// Define the parts of the flag configuration that will not be copied.
    /// </summary>
    /// <value>Define the parts of the flag configuration that will not be copied.</value>
    [DataMember(Name="excludedActions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "excludedActions")]
    public List<CopyActions> ExcludedActions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeatureFlagCopyBody {\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Target: ").Append(Target).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  IncludedActions: ").Append(IncludedActions).Append("\n");
      sb.Append("  ExcludedActions: ").Append(ExcludedActions).Append("\n");
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
