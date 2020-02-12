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
  public class EnvironmentPost {
    /// <summary>
    /// The name of the new environment.
    /// </summary>
    /// <value>The name of the new environment.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A project-unique key for the new environment.
    /// </summary>
    /// <value>A project-unique key for the new environment.</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// A color swatch (as an RGB hex value with no leading '#', e.g. C8C8C8).
    /// </summary>
    /// <value>A color swatch (as an RGB hex value with no leading '#', e.g. C8C8C8).</value>
    [DataMember(Name="color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color")]
    public string Color { get; set; }

    /// <summary>
    /// The default TTL for the new environment.
    /// </summary>
    /// <value>The default TTL for the new environment.</value>
    [DataMember(Name="defaultTtl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultTtl")]
    public decimal? DefaultTtl { get; set; }

    /// <summary>
    /// Determines whether the environment is in secure mode.
    /// </summary>
    /// <value>Determines whether the environment is in secure mode.</value>
    [DataMember(Name="secureMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secureMode")]
    public bool? SecureMode { get; set; }

    /// <summary>
    /// Set to true to send detailed event information for newly created flags.
    /// </summary>
    /// <value>Set to true to send detailed event information for newly created flags.</value>
    [DataMember(Name="defaultTrackEvents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultTrackEvents")]
    public bool? DefaultTrackEvents { get; set; }

    /// <summary>
    /// An array of tags for this environment.
    /// </summary>
    /// <value>An array of tags for this environment.</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Determines if this environment requires comments for flag and segment changes.
    /// </summary>
    /// <value>Determines if this environment requires comments for flag and segment changes.</value>
    [DataMember(Name="requireComments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requireComments")]
    public bool? RequireComments { get; set; }

    /// <summary>
    /// Determines if this environment requires confirmation for flag and segment changes.
    /// </summary>
    /// <value>Determines if this environment requires confirmation for flag and segment changes.</value>
    [DataMember(Name="confirmChanges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "confirmChanges")]
    public bool? ConfirmChanges { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnvironmentPost {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Color: ").Append(Color).Append("\n");
      sb.Append("  DefaultTtl: ").Append(DefaultTtl).Append("\n");
      sb.Append("  SecureMode: ").Append(SecureMode).Append("\n");
      sb.Append("  DefaultTrackEvents: ").Append(DefaultTrackEvents).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  RequireComments: ").Append(RequireComments).Append("\n");
      sb.Append("  ConfirmChanges: ").Append(ConfirmChanges).Append("\n");
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
