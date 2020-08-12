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
  public class Token {
    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public Links Links { get; set; }

    /// <summary>
    /// The unique resource id.
    /// </summary>
    /// <value>The unique resource id.</value>
    [DataMember(Name="_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_id")]
    public string Id { get; set; }

    /// <summary>
    /// The unique resource id.
    /// </summary>
    /// <value>The unique resource id.</value>
    [DataMember(Name="ownerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerId")]
    public string OwnerId { get; set; }

    /// <summary>
    /// The unique resource id.
    /// </summary>
    /// <value>The unique resource id.</value>
    [DataMember(Name="memberId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memberId")]
    public string MemberId { get; set; }

    /// <summary>
    /// Gets or Sets Member
    /// </summary>
    [DataMember(Name="_member", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_member")]
    public Member Member { get; set; }

    /// <summary>
    /// A unix epoch time in milliseconds specifying the creation time of this access token.
    /// </summary>
    /// <value>A unix epoch time in milliseconds specifying the creation time of this access token.</value>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public long? CreationDate { get; set; }

    /// <summary>
    /// A unix epoch time in milliseconds specifying the last time this access token was modified.
    /// </summary>
    /// <value>A unix epoch time in milliseconds specifying the last time this access token was modified.</value>
    [DataMember(Name="lastModified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastModified")]
    public long? LastModified { get; set; }

    /// <summary>
    /// A unix epoch time in milliseconds specifying the last time this access token was used to authorize access to the LaunchDarkly REST API.
    /// </summary>
    /// <value>A unix epoch time in milliseconds specifying the last time this access token was used to authorize access to the LaunchDarkly REST API.</value>
    [DataMember(Name="lastUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUsed")]
    public long? LastUsed { get; set; }

    /// <summary>
    /// The last 4 digits of the unique secret key for this access token. If creating or resetting the token, this will be the full token secret.
    /// </summary>
    /// <value>The last 4 digits of the unique secret key for this access token. If creating or resetting the token, this will be the full token secret.</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string _Token { get; set; }

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
      sb.Append("class Token {\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  MemberId: ").Append(MemberId).Append("\n");
      sb.Append("  Member: ").Append(Member).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  LastModified: ").Append(LastModified).Append("\n");
      sb.Append("  LastUsed: ").Append(LastUsed).Append("\n");
      sb.Append("  _Token: ").Append(_Token).Append("\n");
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
