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
  public class ScheduledChangesFeatureFlagConflict {
    /// <summary>
    /// Feature flag scheduled change id this change will conflict with
    /// </summary>
    /// <value>Feature flag scheduled change id this change will conflict with</value>
    [DataMember(Name="_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_id")]
    public string Id { get; set; }

    /// <summary>
    /// Feature flag scheduled change conflict reason
    /// </summary>
    /// <value>Feature flag scheduled change conflict reason</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScheduledChangesFeatureFlagConflict {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
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
