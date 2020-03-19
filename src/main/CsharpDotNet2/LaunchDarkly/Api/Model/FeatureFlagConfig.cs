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
    public Fallthrough Fallthrough { get; set; }

    /// <summary>
    /// Gets or Sets OffVariation
    /// </summary>
    [DataMember(Name="offVariation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offVariation")]
    public int? OffVariation { get; set; }

    /// <summary>
    /// Gets or Sets Prerequisites
    /// </summary>
    [DataMember(Name="prerequisites", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prerequisites")]
    public List<Prerequisite> Prerequisites { get; set; }

    /// <summary>
    /// Set to true to send detailed event information for this flag.
    /// </summary>
    /// <value>Set to true to send detailed event information for this flag.</value>
    [DataMember(Name="trackEvents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trackEvents")]
    public bool? TrackEvents { get; set; }

    /// <summary>
    /// Set to true to send detailed event information when targeting is enabled but no individual targeting rule is matched.
    /// </summary>
    /// <value>Set to true to send detailed event information when targeting is enabled but no individual targeting rule is matched.</value>
    [DataMember(Name="trackEventsFallthrough", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trackEventsFallthrough")]
    public bool? TrackEventsFallthrough { get; set; }


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
      sb.Append("  OffVariation: ").Append(OffVariation).Append("\n");
      sb.Append("  Prerequisites: ").Append(Prerequisites).Append("\n");
      sb.Append("  TrackEvents: ").Append(TrackEvents).Append("\n");
      sb.Append("  TrackEventsFallthrough: ").Append(TrackEventsFallthrough).Append("\n");
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
