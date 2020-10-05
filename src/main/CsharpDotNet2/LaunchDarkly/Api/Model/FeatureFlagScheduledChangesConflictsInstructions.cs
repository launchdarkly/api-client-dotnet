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
  public class FeatureFlagScheduledChangesConflictsInstructions {
    /// <summary>
    /// The name of the modification you would like to perform on a resource.
    /// </summary>
    /// <value>The name of the modification you would like to perform on a resource.</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// Gets or Sets Conflicts
    /// </summary>
    [DataMember(Name="conflicts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conflicts")]
    public List<ScheduledChangesFeatureFlagConflict> Conflicts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeatureFlagScheduledChangesConflictsInstructions {\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  Conflicts: ").Append(Conflicts).Append("\n");
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
