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
  public class UserTargetingExpirationForSegment {
    /// <summary>
    /// Unix epoch time in milliseconds specifying the expiration date
    /// </summary>
    /// <value>Unix epoch time in milliseconds specifying the expiration date</value>
    [DataMember(Name="expirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationDate")]
    public long? ExpirationDate { get; set; }

    /// <summary>
    /// either the included or excluded variation that the user is targeted on a segment
    /// </summary>
    /// <value>either the included or excluded variation that the user is targeted on a segment</value>
    [DataMember(Name="targetType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetType")]
    public string TargetType { get; set; }

    /// <summary>
    /// Unique identifier for the user
    /// </summary>
    /// <value>Unique identifier for the user</value>
    [DataMember(Name="userKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userKey")]
    public string UserKey { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ResourceId
    /// </summary>
    [DataMember(Name="_resourceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_resourceId")]
    public UserTargetingExpirationResourceIdForFlag ResourceId { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public Links Links { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_version")]
    public int? Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserTargetingExpirationForSegment {\n");
      sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
      sb.Append("  TargetType: ").Append(TargetType).Append("\n");
      sb.Append("  UserKey: ").Append(UserKey).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
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
