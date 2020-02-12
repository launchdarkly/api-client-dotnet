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
  public class Policy {
    /// <summary>
    /// Gets or Sets Resources
    /// </summary>
    [DataMember(Name="resources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resources")]
    public List<string> Resources { get; set; }

    /// <summary>
    /// Targeted resource will be those resources NOT in this list. The \"resources`\" field must be empty to use this field.
    /// </summary>
    /// <value>Targeted resource will be those resources NOT in this list. The \"resources`\" field must be empty to use this field.</value>
    [DataMember(Name="notResources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notResources")]
    public List<string> NotResources { get; set; }

    /// <summary>
    /// Gets or Sets Actions
    /// </summary>
    [DataMember(Name="actions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actions")]
    public List<string> Actions { get; set; }

    /// <summary>
    /// Targeted actions will be those actions NOT in this list. The \"actions\" field must be empty to use this field.
    /// </summary>
    /// <value>Targeted actions will be those actions NOT in this list. The \"actions\" field must be empty to use this field.</value>
    [DataMember(Name="notActions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notActions")]
    public List<string> NotActions { get; set; }

    /// <summary>
    /// Effect of the policy - allow or deny.
    /// </summary>
    /// <value>Effect of the policy - allow or deny.</value>
    [DataMember(Name="effect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effect")]
    public string Effect { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Policy {\n");
      sb.Append("  Resources: ").Append(Resources).Append("\n");
      sb.Append("  NotResources: ").Append(NotResources).Append("\n");
      sb.Append("  Actions: ").Append(Actions).Append("\n");
      sb.Append("  NotActions: ").Append(NotActions).Append("\n");
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
