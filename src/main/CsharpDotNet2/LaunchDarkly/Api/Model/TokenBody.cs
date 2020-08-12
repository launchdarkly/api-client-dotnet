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
  public class TokenBody {
    /// <summary>
    /// A human-friendly name for the access token
    /// </summary>
    /// <value>A human-friendly name for the access token</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The name of a built-in role for the token
    /// </summary>
    /// <value>The name of a built-in role for the token</value>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; }

    /// <summary>
    /// A list of custom role IDs to use as access limits for the access token
    /// </summary>
    /// <value>A list of custom role IDs to use as access limits for the access token</value>
    [DataMember(Name="customRoleIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customRoleIds")]
    public List<string> CustomRoleIds { get; set; }

    /// <summary>
    /// Gets or Sets InlineRole
    /// </summary>
    [DataMember(Name="inlineRole", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inlineRole")]
    public List<Statement> InlineRole { get; set; }

    /// <summary>
    /// Whether the token will be a service token https://docs.launchdarkly.com/home/account-security/api-access-tokens#service-tokens
    /// </summary>
    /// <value>Whether the token will be a service token https://docs.launchdarkly.com/home/account-security/api-access-tokens#service-tokens</value>
    [DataMember(Name="serviceToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceToken")]
    public bool? ServiceToken { get; set; }

    /// <summary>
    /// The default API version for this token
    /// </summary>
    /// <value>The default API version for this token</value>
    [DataMember(Name="defaultApiVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultApiVersion")]
    public int? DefaultApiVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TokenBody {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
      sb.Append("  CustomRoleIds: ").Append(CustomRoleIds).Append("\n");
      sb.Append("  InlineRole: ").Append(InlineRole).Append("\n");
      sb.Append("  ServiceToken: ").Append(ServiceToken).Append("\n");
      sb.Append("  DefaultApiVersion: ").Append(DefaultApiVersion).Append("\n");
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
