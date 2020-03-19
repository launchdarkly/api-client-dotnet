using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LaunchDarkly.Api.Model {

  /// <summary>
  /// Default values to be used when a new environment is created.
  /// </summary>
  [DataContract]
  public class Defaults {
    /// <summary>
    /// The index of the variation to be served when a flag's targeting is on (default variation).
    /// </summary>
    /// <value>The index of the variation to be served when a flag's targeting is on (default variation).</value>
    [DataMember(Name="onVariation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "onVariation")]
    public int? OnVariation { get; set; }

    /// <summary>
    /// The index of the variation to be served when a flag is off.
    /// </summary>
    /// <value>The index of the variation to be served when a flag is off.</value>
    [DataMember(Name="offVariation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offVariation")]
    public int? OffVariation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Defaults {\n");
      sb.Append("  OnVariation: ").Append(OnVariation).Append("\n");
      sb.Append("  OffVariation: ").Append(OffVariation).Append("\n");
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
