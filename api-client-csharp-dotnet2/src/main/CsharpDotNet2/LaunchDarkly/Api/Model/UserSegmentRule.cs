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
  public class UserSegmentRule {
    /// <summary>
    /// Gets or Sets Clauses
    /// </summary>
    [DataMember(Name="clauses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clauses")]
    public List<Clause> Clauses { get; set; }

    /// <summary>
    /// Gets or Sets Weight
    /// </summary>
    [DataMember(Name="weight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "weight")]
    public int? Weight { get; set; }

    /// <summary>
    /// Gets or Sets BucketBy
    /// </summary>
    [DataMember(Name="bucketBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bucketBy")]
    public string BucketBy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserSegmentRule {\n");
      sb.Append("  Clauses: ").Append(Clauses).Append("\n");
      sb.Append("  Weight: ").Append(Weight).Append("\n");
      sb.Append("  BucketBy: ").Append(BucketBy).Append("\n");
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
