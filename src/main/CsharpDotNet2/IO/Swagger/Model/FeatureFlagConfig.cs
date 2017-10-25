using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class FeatureFlagConfig {
    /// <summary>
    /// Gets or Sets On
    /// </summary>
    [DataMember(Name="on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "on")]
    public bool? On { get; set; }

    /// <summary>
    /// Gets or Sets Archived
    /// </summary>
    [DataMember(Name="archived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archived")]
    public bool? Archived { get; set; }

    /// <summary>
    /// Gets or Sets Salt
    /// </summary>
    [DataMember(Name="salt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "salt")]
    public string Salt { get; set; }

    /// <summary>
    /// Gets or Sets Sel
    /// </summary>
    [DataMember(Name="sel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sel")]
    public string Sel { get; set; }

    /// <summary>
    /// Gets or Sets LastModified
    /// </summary>
    [DataMember(Name="lastModified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastModified")]
    public long? LastModified { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public int? Version { get; set; }

    /// <summary>
    /// Gets or Sets Targets
    /// </summary>
    [DataMember(Name="targets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targets")]
    public List<Target> Targets { get; set; }

    /// <summary>
    /// Gets or Sets Rules
    /// </summary>
    [DataMember(Name="rules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rules")]
    public List<Rule> Rules { get; set; }

    /// <summary>
    /// Gets or Sets Fallthrough
    /// </summary>
    [DataMember(Name="fallthrough", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fallthrough")]
    public FeatureFlagConfigFallthrough Fallthrough { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeatureFlagConfig {\n");
      sb.Append("  On: ").Append(On).Append("\n");
      sb.Append("  Archived: ").Append(Archived).Append("\n");
      sb.Append("  Salt: ").Append(Salt).Append("\n");
      sb.Append("  Sel: ").Append(Sel).Append("\n");
      sb.Append("  LastModified: ").Append(LastModified).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  Targets: ").Append(Targets).Append("\n");
      sb.Append("  Rules: ").Append(Rules).Append("\n");
      sb.Append("  Fallthrough: ").Append(Fallthrough).Append("\n");
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
