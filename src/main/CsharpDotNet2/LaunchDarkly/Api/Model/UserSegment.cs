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
  public class UserSegment {
    /// <summary>
    /// Unique identifier for the user segment.
    /// </summary>
    /// <value>Unique identifier for the user segment.</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// Name of the user segment.
    /// </summary>
    /// <value>Name of the user segment.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of the user segment.
    /// </summary>
    /// <value>Description of the user segment.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// An array of tags for this user segment.
    /// </summary>
    /// <value>An array of tags for this user segment.</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// A unix epoch time in milliseconds specifying the creation time of this flag.
    /// </summary>
    /// <value>A unix epoch time in milliseconds specifying the creation time of this flag.</value>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public long? CreationDate { get; set; }

    /// <summary>
    /// An array of user keys that are included in this segment.
    /// </summary>
    /// <value>An array of user keys that are included in this segment.</value>
    [DataMember(Name="included", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "included")]
    public List<string> Included { get; set; }

    /// <summary>
    /// An array of user keys that should not be included in this segment, unless they are also listed in \"included\".
    /// </summary>
    /// <value>An array of user keys that should not be included in this segment, unless they are also listed in \"included\".</value>
    [DataMember(Name="excluded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "excluded")]
    public List<string> Excluded { get; set; }

    /// <summary>
    /// An array of rules that can cause a user to be included in this segment.
    /// </summary>
    /// <value>An array of rules that can cause a user to be included in this segment.</value>
    [DataMember(Name="rules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rules")]
    public List<UserSegmentRule> Rules { get; set; }

    /// <summary>
    /// Controls whether this segment can support unlimited numbers of users. Requires the beta API and additional setup. Include/exclude lists in this payload are not used in unbounded segments.
    /// </summary>
    /// <value>Controls whether this segment can support unlimited numbers of users. Requires the beta API and additional setup. Include/exclude lists in this payload are not used in unbounded segments.</value>
    [DataMember(Name="unbounded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unbounded")]
    public bool? Unbounded { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public int? Version { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public Links Links { get; set; }

    /// <summary>
    /// Gets or Sets Flags
    /// </summary>
    [DataMember(Name="_flags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_flags")]
    public List<FlagListItem> Flags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserSegment {\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  Included: ").Append(Included).Append("\n");
      sb.Append("  Excluded: ").Append(Excluded).Append("\n");
      sb.Append("  Rules: ").Append(Rules).Append("\n");
      sb.Append("  Unbounded: ").Append(Unbounded).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Flags: ").Append(Flags).Append("\n");
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
