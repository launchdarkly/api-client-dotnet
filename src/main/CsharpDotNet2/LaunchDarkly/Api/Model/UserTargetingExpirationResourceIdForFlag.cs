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
  public class UserTargetingExpirationResourceIdForFlag {
    /// <summary>
    /// Gets or Sets Kind
    /// </summary>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public string Kind { get; set; }

    /// <summary>
    /// Gets or Sets ProjectKey
    /// </summary>
    [DataMember(Name="projectKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectKey")]
    public string ProjectKey { get; set; }

    /// <summary>
    /// Gets or Sets EnvironmentKey
    /// </summary>
    [DataMember(Name="environmentKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environmentKey")]
    public string EnvironmentKey { get; set; }

    /// <summary>
    /// Gets or Sets FlagKey
    /// </summary>
    [DataMember(Name="flagKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flagKey")]
    public string FlagKey { get; set; }

    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserTargetingExpirationResourceIdForFlag {\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  ProjectKey: ").Append(ProjectKey).Append("\n");
      sb.Append("  EnvironmentKey: ").Append(EnvironmentKey).Append("\n");
      sb.Append("  FlagKey: ").Append(FlagKey).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
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
