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
  public class UserRecord {
    /// <summary>
    /// Gets or Sets LastPing
    /// </summary>
    [DataMember(Name="lastPing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastPing")]
    public string LastPing { get; set; }

    /// <summary>
    /// Gets or Sets EnvironmentId
    /// </summary>
    [DataMember(Name="environmentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environmentId")]
    public string EnvironmentId { get; set; }

    /// <summary>
    /// The unique resource id.
    /// </summary>
    /// <value>The unique resource id.</value>
    [DataMember(Name="ownerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerId")]
    public string OwnerId { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public User User { get; set; }

    /// <summary>
    /// Gets or Sets Avatar
    /// </summary>
    [DataMember(Name="avatar", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatar")]
    public string Avatar { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserRecord {\n");
      sb.Append("  LastPing: ").Append(LastPing).Append("\n");
      sb.Append("  EnvironmentId: ").Append(EnvironmentId).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Avatar: ").Append(Avatar).Append("\n");
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
