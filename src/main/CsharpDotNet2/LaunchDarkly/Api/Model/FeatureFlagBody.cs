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
  public class FeatureFlagBody {
    /// <summary>
    /// A human-friendly name for the feature flag. Remember to note if this flag is intended to be temporary or permanent.
    /// </summary>
    /// <value>A human-friendly name for the feature flag. Remember to note if this flag is intended to be temporary or permanent.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A unique key that will be used to reference the flag in your code.
    /// </summary>
    /// <value>A unique key that will be used to reference the flag in your code.</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// A description of the feature flag.
    /// </summary>
    /// <value>A description of the feature flag.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// An array of possible variations for the flag.
    /// </summary>
    /// <value>An array of possible variations for the flag.</value>
    [DataMember(Name="variations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variations")]
    public List<Variation> Variations { get; set; }

    /// <summary>
    /// Whether or not the flag is a temporary flag.
    /// </summary>
    /// <value>Whether or not the flag is a temporary flag.</value>
    [DataMember(Name="temporary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "temporary")]
    public bool? Temporary { get; set; }

    /// <summary>
    /// Tags for the feature flag.
    /// </summary>
    /// <value>Tags for the feature flag.</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Whether or not this flag should be made available to the client-side JavaScript SDK.
    /// </summary>
    /// <value>Whether or not this flag should be made available to the client-side JavaScript SDK.</value>
    [DataMember(Name="includeInSnippet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeInSnippet")]
    public bool? IncludeInSnippet { get; set; }

    /// <summary>
    /// Gets or Sets ClientSideAvailability
    /// </summary>
    [DataMember(Name="clientSideAvailability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientSideAvailability")]
    public ClientSideAvailability ClientSideAvailability { get; set; }

    /// <summary>
    /// Gets or Sets Defaults
    /// </summary>
    [DataMember(Name="defaults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaults")]
    public Defaults Defaults { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeatureFlagBody {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Variations: ").Append(Variations).Append("\n");
      sb.Append("  Temporary: ").Append(Temporary).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  IncludeInSnippet: ").Append(IncludeInSnippet).Append("\n");
      sb.Append("  ClientSideAvailability: ").Append(ClientSideAvailability).Append("\n");
      sb.Append("  Defaults: ").Append(Defaults).Append("\n");
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
