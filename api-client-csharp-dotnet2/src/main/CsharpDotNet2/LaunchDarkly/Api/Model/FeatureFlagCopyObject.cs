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
  public class FeatureFlagCopyObject {
    /// <summary>
    /// The environment key to be used.
    /// </summary>
    /// <value>The environment key to be used.</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// If the latest version of the flag matches provided version it will copy, otherwise it will return a conflict.
    /// </summary>
    /// <value>If the latest version of the flag matches provided version it will copy, otherwise it will return a conflict.</value>
    [DataMember(Name="currentVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentVersion")]
    public int? CurrentVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeatureFlagCopyObject {\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  CurrentVersion: ").Append(CurrentVersion).Append("\n");
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
