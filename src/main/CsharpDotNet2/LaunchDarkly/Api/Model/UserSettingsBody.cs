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
  public class UserSettingsBody {
    /// <summary>
    /// The variation value to set for the user. Must match the variation type of the flag. 
    /// </summary>
    /// <value>The variation value to set for the user. Must match the variation type of the flag. </value>
    [DataMember(Name="setting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setting")]
    public bool? Setting { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserSettingsBody {\n");
      sb.Append("  Setting: ").Append(Setting).Append("\n");
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
