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
  public class IntegrationSubscriptionStatus {
    /// <summary>
    /// Gets or Sets SuccessCount
    /// </summary>
    [DataMember(Name="successCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "successCount")]
    public int? SuccessCount { get; set; }

    /// <summary>
    /// A unix epoch time in milliseconds specifying the last time this integration was successfully used.
    /// </summary>
    /// <value>A unix epoch time in milliseconds specifying the last time this integration was successfully used.</value>
    [DataMember(Name="lastSuccess", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastSuccess")]
    public long? LastSuccess { get; set; }

    /// <summary>
    /// Gets or Sets ErrorCount
    /// </summary>
    [DataMember(Name="errorCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorCount")]
    public int? ErrorCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IntegrationSubscriptionStatus {\n");
      sb.Append("  SuccessCount: ").Append(SuccessCount).Append("\n");
      sb.Append("  LastSuccess: ").Append(LastSuccess).Append("\n");
      sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
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
