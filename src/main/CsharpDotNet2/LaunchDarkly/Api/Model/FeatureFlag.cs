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
  public class FeatureFlag {
    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// Name of the feature flag.
    /// </summary>
    /// <value>Name of the feature flag.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of the feature flag.
    /// </summary>
    /// <value>Description of the feature flag.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Whether the feature flag is a boolean flag or multivariate.
    /// </summary>
    /// <value>Whether the feature flag is a boolean flag or multivariate.</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// A unix epoch time in milliseconds specifying the creation time of this flag.
    /// </summary>
    /// <value>A unix epoch time in milliseconds specifying the creation time of this flag.</value>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public long? CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets IncludeInSnippet
    /// </summary>
    [DataMember(Name="includeInSnippet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeInSnippet")]
    public bool? IncludeInSnippet { get; set; }

    /// <summary>
    /// Whether or not this flag is temporary.
    /// </summary>
    /// <value>Whether or not this flag is temporary.</value>
    [DataMember(Name="temporary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "temporary")]
    public bool? Temporary { get; set; }

    /// <summary>
    /// The ID of the member that should maintain this flag.
    /// </summary>
    /// <value>The ID of the member that should maintain this flag.</value>
    [DataMember(Name="maintainerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maintainerId")]
    public string MaintainerId { get; set; }

    /// <summary>
    /// An array of tags for this feature flag.
    /// </summary>
    /// <value>An array of tags for this feature flag.</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// The variations for this feature flag.
    /// </summary>
    /// <value>The variations for this feature flag.</value>
    [DataMember(Name="variations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variations")]
    public List<Variation> Variations { get; set; }

    /// <summary>
    /// An array goals from all environments associated with this feature flag
    /// </summary>
    /// <value>An array goals from all environments associated with this feature flag</value>
    [DataMember(Name="goalIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "goalIds")]
    public List<string> GoalIds { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_version")]
    public int? Version { get; set; }

    /// <summary>
    /// A mapping of keys to CustomProperty entries.
    /// </summary>
    /// <value>A mapping of keys to CustomProperty entries.</value>
    [DataMember(Name="customProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customProperties")]
    public Dictionary<string, CustomProperty> CustomProperties { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public Links Links { get; set; }

    /// <summary>
    /// Gets or Sets Maintainer
    /// </summary>
    [DataMember(Name="_maintainer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_maintainer")]
    public Member Maintainer { get; set; }

    /// <summary>
    /// Gets or Sets Environments
    /// </summary>
    [DataMember(Name="environments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environments")]
    public Dictionary<string, FeatureFlagConfig> Environments { get; set; }

    /// <summary>
    /// A unix epoch time in milliseconds specifying the archived time of this flag.
    /// </summary>
    /// <value>A unix epoch time in milliseconds specifying the archived time of this flag.</value>
    [DataMember(Name="archivedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archivedDate")]
    public long? ArchivedDate { get; set; }

    /// <summary>
    /// Whether or not this flag is archived.
    /// </summary>
    /// <value>Whether or not this flag is archived.</value>
    [DataMember(Name="archived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archived")]
    public bool? Archived { get; set; }

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
      sb.Append("class FeatureFlag {\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  IncludeInSnippet: ").Append(IncludeInSnippet).Append("\n");
      sb.Append("  Temporary: ").Append(Temporary).Append("\n");
      sb.Append("  MaintainerId: ").Append(MaintainerId).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Variations: ").Append(Variations).Append("\n");
      sb.Append("  GoalIds: ").Append(GoalIds).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  CustomProperties: ").Append(CustomProperties).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Maintainer: ").Append(Maintainer).Append("\n");
      sb.Append("  Environments: ").Append(Environments).Append("\n");
      sb.Append("  ArchivedDate: ").Append(ArchivedDate).Append("\n");
      sb.Append("  Archived: ").Append(Archived).Append("\n");
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
