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
  public class Statement {
    /// <summary>
    /// Gets or Sets Resources
    /// </summary>
    [DataMember(Name="resources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resources")]
    public Resources Resources { get; set; }

    /// <summary>
    /// Targeted resource will be those resources NOT in this list. The \"resources`\" field must be empty to use this field.
    /// </summary>
    /// <value>Targeted resource will be those resources NOT in this list. The \"resources`\" field must be empty to use this field.</value>
    [DataMember(Name="notresources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notresources")]
    public Resources Notresources { get; set; }

    /// <summary>
    /// Gets or Sets Actions
    /// </summary>
    [DataMember(Name="actions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actions")]
    public Actions Actions { get; set; }

    /// <summary>
    /// Targeted actions will be those actions NOT in this list. The \"actions\" field must be empty to use this field.
    /// </summary>
    /// <value>Targeted actions will be those actions NOT in this list. The \"actions\" field must be empty to use this field.</value>
    [DataMember(Name="notactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notactions")]
    public Actions Notactions { get; set; }

    /// <summary>
    /// Gets or Sets Effect
    /// </summary>
    [DataMember(Name="effect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effect")]
    public string Effect { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Statement {\n");
      sb.Append("  Resources: ").Append(Resources).Append("\n");
      sb.Append("  Notresources: ").Append(Notresources).Append("\n");
      sb.Append("  Actions: ").Append(Actions).Append("\n");
      sb.Append("  Notactions: ").Append(Notactions).Append("\n");
      sb.Append("  Effect: ").Append(Effect).Append("\n");
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
