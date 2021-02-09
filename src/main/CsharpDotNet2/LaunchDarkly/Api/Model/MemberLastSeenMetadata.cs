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
  public class MemberLastSeenMetadata {
    /// <summary>
    /// If the last time this member accessed LaunchDarkly was using the REST API, this value will be set to the ID of the personal access token used.
    /// </summary>
    /// <value>If the last time this member accessed LaunchDarkly was using the REST API, this value will be set to the ID of the personal access token used.</value>
    [DataMember(Name="tokenId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tokenId")]
    public string TokenId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MemberLastSeenMetadata {\n");
      sb.Append("  TokenId: ").Append(TokenId).Append("\n");
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
