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
  public class Rule {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Variation
    /// </summary>
    [DataMember(Name="variation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variation")]
    public int? Variation { get; set; }

    /// <summary>
    /// Gets or Sets TrackEvents
    /// </summary>
    [DataMember(Name="trackEvents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trackEvents")]
    public bool? TrackEvents { get; set; }

    /// <summary>
    /// Gets or Sets Rollout
    /// </summary>
    [DataMember(Name="rollout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rollout")]
    public Rollout Rollout { get; set; }

    /// <summary>
    /// Gets or Sets Clauses
    /// </summary>
    [DataMember(Name="clauses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clauses")]
    public List<Clause> Clauses { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Rule {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Variation: ").Append(Variation).Append("\n");
      sb.Append("  TrackEvents: ").Append(TrackEvents).Append("\n");
      sb.Append("  Rollout: ").Append(Rollout).Append("\n");
      sb.Append("  Clauses: ").Append(Clauses).Append("\n");
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
