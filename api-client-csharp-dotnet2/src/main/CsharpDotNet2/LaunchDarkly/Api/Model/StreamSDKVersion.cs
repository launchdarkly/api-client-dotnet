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
  public class StreamSDKVersion {
    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public StreamBySDKLinks Links { get; set; }

    /// <summary>
    /// Gets or Sets SdkVersions
    /// </summary>
    [DataMember(Name="sdkVersions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sdkVersions")]
    public List<StreamSDKVersionData> SdkVersions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StreamSDKVersion {\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  SdkVersions: ").Append(SdkVersions).Append("\n");
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
