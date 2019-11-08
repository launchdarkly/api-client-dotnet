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
  public class DestinationBody {
    /// <summary>
    /// A human-readable name for your data export destination.
    /// </summary>
    /// <value>A human-readable name for your data export destination.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The data export destination type. Available choices are kinesis, google-pubsub, mparticle, or segment.
    /// </summary>
    /// <value>The data export destination type. Available choices are kinesis, google-pubsub, mparticle, or segment.</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// destination-specific configuration.
    /// </summary>
    /// <value>destination-specific configuration.</value>
    [DataMember(Name="config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "config")]
    public Object Config { get; set; }

    /// <summary>
    /// Whether the data export destination is on or not.
    /// </summary>
    /// <value>Whether the data export destination is on or not.</value>
    [DataMember(Name="on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "on")]
    public bool? On { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinationBody {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("  On: ").Append(On).Append("\n");
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
