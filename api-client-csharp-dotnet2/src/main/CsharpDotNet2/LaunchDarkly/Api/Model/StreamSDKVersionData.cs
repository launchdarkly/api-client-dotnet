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
  public class StreamSDKVersionData {
    /// <summary>
    /// The language of the sdk
    /// </summary>
    /// <value>The language of the sdk</value>
    [DataMember(Name="sdk", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sdk")]
    public string Sdk { get; set; }

    /// <summary>
    /// The version of the sdk
    /// </summary>
    /// <value>The version of the sdk</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StreamSDKVersionData {\n");
      sb.Append("  Sdk: ").Append(Sdk).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
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
