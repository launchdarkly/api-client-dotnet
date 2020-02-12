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
  public class FeatureFlagStatus {
    /// <summary>
    /// | Name     | Description | | - -- -- -- -:| - -- -- -- -- -- | | new      | the feature flag was created within the last 7 days, and has not been requested yet | | active   | the feature flag was requested by your servers or clients within the last 7 days | | inactive | the feature flag was created more than 7 days ago, and hasn't been requested by your servers or clients within the past 7 days | | launched | one variation of the feature flag has been rolled out to all your users for at least 7 days | 
    /// </summary>
    /// <value>| Name     | Description | | - -- -- -- -:| - -- -- -- -- -- | | new      | the feature flag was created within the last 7 days, and has not been requested yet | | active   | the feature flag was requested by your servers or clients within the last 7 days | | inactive | the feature flag was created more than 7 days ago, and hasn't been requested by your servers or clients within the past 7 days | | launched | one variation of the feature flag has been rolled out to all your users for at least 7 days | </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets LastRequested
    /// </summary>
    [DataMember(Name="lastRequested", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastRequested")]
    public string LastRequested { get; set; }

    /// <summary>
    /// Gets or Sets Default
    /// </summary>
    [DataMember(Name="default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default")]
    public Object Default { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public Links Links { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeatureFlagStatus {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  LastRequested: ").Append(LastRequested).Append("\n");
      sb.Append("  Default: ").Append(Default).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
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
