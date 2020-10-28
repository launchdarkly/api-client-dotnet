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
  public class SubscriptionBody {
    /// <summary>
    /// A human-readable name for your subscription configuration.
    /// </summary>
    /// <value>A human-readable name for your subscription configuration.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Statements
    /// </summary>
    [DataMember(Name="statements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statements")]
    public List<Statement> Statements { get; set; }

    /// <summary>
    /// Integration-specific configuration fields.
    /// </summary>
    /// <value>Integration-specific configuration fields.</value>
    [DataMember(Name="config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "config")]
    public Object Config { get; set; }

    /// <summary>
    /// Whether the integration subscription is active or not.
    /// </summary>
    /// <value>Whether the integration subscription is active or not.</value>
    [DataMember(Name="on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "on")]
    public bool? On { get; set; }

    /// <summary>
    /// Tags for the integration subscription.
    /// </summary>
    /// <value>Tags for the integration subscription.</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionBody {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Statements: ").Append(Statements).Append("\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("  On: ").Append(On).Append("\n");
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
