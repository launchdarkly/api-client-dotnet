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
  public class IntegrationSubscription {
    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public HierarchicalLinks Links { get; set; }

    /// <summary>
    /// The unique resource id.
    /// </summary>
    /// <value>The unique resource id.</value>
    [DataMember(Name="_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_id")]
    public string Id { get; set; }

    /// <summary>
    /// The type of integration associated with this configuration.
    /// </summary>
    /// <value>The type of integration associated with this configuration.</value>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// The user-defined name associated with this configuration.
    /// </summary>
    /// <value>The user-defined name associated with this configuration.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A key-value mapping of configuration fields.
    /// </summary>
    /// <value>A key-value mapping of configuration fields.</value>
    [DataMember(Name="config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "config")]
    public Object Config { get; set; }

    /// <summary>
    /// Gets or Sets Statements
    /// </summary>
    [DataMember(Name="statements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statements")]
    public List<Statement> Statements { get; set; }

    /// <summary>
    /// Whether or not the integration is currently active.
    /// </summary>
    /// <value>Whether or not the integration is currently active.</value>
    [DataMember(Name="on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "on")]
    public bool? On { get; set; }

    /// <summary>
    /// An array of tags for this integration configuration.
    /// </summary>
    /// <value>An array of tags for this integration configuration.</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_status")]
    public IntegrationSubscriptionStatus Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IntegrationSubscription {\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("  Statements: ").Append(Statements).Append("\n");
      sb.Append("  On: ").Append(On).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
