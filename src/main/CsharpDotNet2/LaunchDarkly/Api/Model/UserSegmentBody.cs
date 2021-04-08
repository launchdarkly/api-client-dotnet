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
  public class UserSegmentBody {
    /// <summary>
    /// A human-friendly name for the user segment.
    /// </summary>
    /// <value>A human-friendly name for the user segment.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A unique key that will be used to reference the user segment in feature flags.
    /// </summary>
    /// <value>A unique key that will be used to reference the user segment in feature flags.</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// A description for the user segment.
    /// </summary>
    /// <value>A description for the user segment.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Controls whether this is considered a \"big segment\" which can support an unlimited numbers of users. Include/exclude lists sent with this payload are not used in big segments. Contact your account manager for early access to this feature.
    /// </summary>
    /// <value>Controls whether this is considered a \"big segment\" which can support an unlimited numbers of users. Include/exclude lists sent with this payload are not used in big segments. Contact your account manager for early access to this feature.</value>
    [DataMember(Name="unbounded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unbounded")]
    public bool? Unbounded { get; set; }

    /// <summary>
    /// Tags for the user segment.
    /// </summary>
    /// <value>Tags for the user segment.</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserSegmentBody {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Unbounded: ").Append(Unbounded).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
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
