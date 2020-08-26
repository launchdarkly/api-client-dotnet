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
  public class ProjectBody {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// Gets or Sets IncludeInSnippetByDefault
    /// </summary>
    [DataMember(Name="includeInSnippetByDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeInSnippetByDefault")]
    public bool? IncludeInSnippetByDefault { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Gets or Sets Environments
    /// </summary>
    [DataMember(Name="environments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environments")]
    public List<EnvironmentPost> Environments { get; set; }

    /// <summary>
    /// Gets or Sets DefaultClientSideAvailability
    /// </summary>
    [DataMember(Name="defaultClientSideAvailability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultClientSideAvailability")]
    public ClientSideAvailability DefaultClientSideAvailability { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectBody {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  IncludeInSnippetByDefault: ").Append(IncludeInSnippetByDefault).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Environments: ").Append(Environments).Append("\n");
      sb.Append("  DefaultClientSideAvailability: ").Append(DefaultClientSideAvailability).Append("\n");
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
