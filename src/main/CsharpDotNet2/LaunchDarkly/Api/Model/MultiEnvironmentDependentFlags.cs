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
  public class MultiEnvironmentDependentFlags {
    /// <summary>
    /// Gets or Sets Items
    /// </summary>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<MultiEnvironmentDependentFlag> Items { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public DependentFlagsLinks Links { get; set; }

    /// <summary>
    /// Gets or Sets Site
    /// </summary>
    [DataMember(Name="_site", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_site")]
    public Site Site { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MultiEnvironmentDependentFlags {\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Site: ").Append(Site).Append("\n");
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
