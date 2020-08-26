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
  public class ClientSideAvailability {
    /// <summary>
    /// When set to true, this flag will be available to SDKs using the client-side id.
    /// </summary>
    /// <value>When set to true, this flag will be available to SDKs using the client-side id.</value>
    [DataMember(Name="usingEnvironmentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usingEnvironmentId")]
    public bool? UsingEnvironmentId { get; set; }

    /// <summary>
    /// When set to true, this flag will be available to SDKS using a mobile key.
    /// </summary>
    /// <value>When set to true, this flag will be available to SDKS using a mobile key.</value>
    [DataMember(Name="usingMobileKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usingMobileKey")]
    public bool? UsingMobileKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClientSideAvailability {\n");
      sb.Append("  UsingEnvironmentId: ").Append(UsingEnvironmentId).Append("\n");
      sb.Append("  UsingMobileKey: ").Append(UsingMobileKey).Append("\n");
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
