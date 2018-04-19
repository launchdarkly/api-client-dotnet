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
  public class Fallthrough {
    /// <summary>
    /// Gets or Sets Variation
    /// </summary>
    [DataMember(Name="variation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variation")]
    public int? Variation { get; set; }

    /// <summary>
    /// Gets or Sets Rollout
    /// </summary>
    [DataMember(Name="rollout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rollout")]
    public Rollout Rollout { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Fallthrough {\n");
      sb.Append("  Variation: ").Append(Variation).Append("\n");
      sb.Append("  Rollout: ").Append(Rollout).Append("\n");
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
