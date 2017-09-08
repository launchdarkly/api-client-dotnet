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
  public class FeatureFlag {
    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Kind
    /// </summary>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public decimal? CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets IncludeInSnippet
    /// </summary>
    [DataMember(Name="includeInSnippet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeInSnippet")]
    public bool? IncludeInSnippet { get; set; }

    /// <summary>
    /// Gets or Sets Temporary
    /// </summary>
    [DataMember(Name="temporary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "temporary")]
    public bool? Temporary { get; set; }

    /// <summary>
    /// Gets or Sets MaintainerId
    /// </summary>
    [DataMember(Name="maintainerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maintainerId")]
    public string MaintainerId { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Gets or Sets Variations
    /// </summary>
    [DataMember(Name="variations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variations")]
    public List<Variation> Variations { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeatureFlag {\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  IncludeInSnippet: ").Append(IncludeInSnippet).Append("\n");
      sb.Append("  Temporary: ").Append(Temporary).Append("\n");
      sb.Append("  MaintainerId: ").Append(MaintainerId).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Variations: ").Append(Variations).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Maintainer: ").Append(Maintainer).Append("\n");
      sb.Append("  Environments: ").Append(Environments).Append("\n");
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
