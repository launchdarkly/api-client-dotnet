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
  public class EnvironmentBody {
    /// <summary>
    /// The name of the new environment
    /// </summary>
    /// <value>The name of the new environment</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A project-unique key for the new environment
    /// </summary>
    /// <value>A project-unique key for the new environment</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// A color swatch (as an RGB hex value with no leading '#', e.g. C8C8C8)
    /// </summary>
    /// <value>A color swatch (as an RGB hex value with no leading '#', e.g. C8C8C8)</value>
    [DataMember(Name="color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color")]
    public string Color { get; set; }

    /// <summary>
    /// The default TTL for the new environment
    /// </summary>
    /// <value>The default TTL for the new environment</value>
    [DataMember(Name="defaultTtl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultTtl")]
    public decimal? DefaultTtl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnvironmentBody {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Color: ").Append(Color).Append("\n");
      sb.Append("  DefaultTtl: ").Append(DefaultTtl).Append("\n");
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
