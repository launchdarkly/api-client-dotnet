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
  public class DestinationMParticle {
    /// <summary>
    /// Gets or Sets ApiKey
    /// </summary>
    [DataMember(Name="apiKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiKey")]
    public string ApiKey { get; set; }

    /// <summary>
    /// Gets or Sets Secret
    /// </summary>
    [DataMember(Name="secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret")]
    public string Secret { get; set; }

    /// <summary>
    /// Gets or Sets UserIdentity
    /// </summary>
    [DataMember(Name="userIdentity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userIdentity")]
    public string UserIdentity { get; set; }

    /// <summary>
    /// Gets or Sets Environment
    /// </summary>
    [DataMember(Name="environment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environment")]
    public string Environment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DestinationMParticle {\n");
      sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
      sb.Append("  UserIdentity: ").Append(UserIdentity).Append("\n");
      sb.Append("  Environment: ").Append(Environment).Append("\n");
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
