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
  public class FeatureFlagScheduledChange {
    /// <summary>
    /// A unix epoch time in milliseconds specifying the date the scheduled changes will be applied
    /// </summary>
    /// <value>A unix epoch time in milliseconds specifying the date the scheduled changes will be applied</value>
    [DataMember(Name="executionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "executionDate")]
    public int? ExecutionDate { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_version")]
    public int? Version { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Instructions
    /// </summary>
    [DataMember(Name="instructions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instructions")]
    public SemanticPatchInstruction Instructions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeatureFlagScheduledChange {\n");
      sb.Append("  ExecutionDate: ").Append(ExecutionDate).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Instructions: ").Append(Instructions).Append("\n");
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
