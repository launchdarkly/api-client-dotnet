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
  public class BigSegmentTargetsBody {
    /// <summary>
    /// Gets or Sets Included
    /// </summary>
    [DataMember(Name="included", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "included")]
    public BigSegmentTargetChanges Included { get; set; }

    /// <summary>
    /// Gets or Sets Excluded
    /// </summary>
    [DataMember(Name="excluded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "excluded")]
    public BigSegmentTargetChanges Excluded { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BigSegmentTargetsBody {\n");
      sb.Append("  Included: ").Append(Included).Append("\n");
      sb.Append("  Excluded: ").Append(Excluded).Append("\n");
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
