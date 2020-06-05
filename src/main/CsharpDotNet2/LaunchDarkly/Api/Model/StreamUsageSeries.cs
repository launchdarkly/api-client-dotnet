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
  public class StreamUsageSeries {
    /// <summary>
    /// A key corresponding to a time series data point.
    /// </summary>
    /// <value>A key corresponding to a time series data point.</value>
    [DataMember(Name="0", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "0")]
    public long? _0 { get; set; }

    /// <summary>
    /// A unix epoch time in milliseconds specifying the creation time of this flag.
    /// </summary>
    /// <value>A unix epoch time in milliseconds specifying the creation time of this flag.</value>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time")]
    public long? Time { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StreamUsageSeries {\n");
      sb.Append("  _0: ").Append(_0).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
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
