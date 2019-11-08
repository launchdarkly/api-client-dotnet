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
  public class DestinationAmazonKinesis {
    /// <summary>
    /// Gets or Sets Region
    /// </summary>
    [DataMember(Name="region", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "region")]
    public string Region { get; set; }

    /// <summary>
    /// Gets or Sets RoleArn
    /// </summary>
    [DataMember(Name="roleArn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roleArn")]
    public string RoleArn { get; set; }

    /// <summary>
    /// Gets or Sets StreamName
    /// </summary>
    [DataMember(Name="streamName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "streamName")]
    public string StreamName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinationAmazonKinesis {\n");
      sb.Append("  Region: ").Append(Region).Append("\n");
      sb.Append("  RoleArn: ").Append(RoleArn).Append("\n");
      sb.Append("  StreamName: ").Append(StreamName).Append("\n");
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
