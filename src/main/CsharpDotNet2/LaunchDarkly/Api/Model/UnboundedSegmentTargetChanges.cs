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
  public class UnboundedSegmentTargetChanges {
    /// <summary>
    /// Users to add to this list of targets
    /// </summary>
    /// <value>Users to add to this list of targets</value>
    [DataMember(Name="add", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add")]
    public List<string> Add { get; set; }

    /// <summary>
    /// Users to remove from this list of targets
    /// </summary>
    /// <value>Users to remove from this list of targets</value>
    [DataMember(Name="remove", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remove")]
    public List<string> Remove { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UnboundedSegmentTargetChanges {\n");
      sb.Append("  Add: ").Append(Add).Append("\n");
      sb.Append("  Remove: ").Append(Remove).Append("\n");
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
