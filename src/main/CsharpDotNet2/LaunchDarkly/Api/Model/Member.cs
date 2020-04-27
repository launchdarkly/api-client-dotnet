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
  public class Member {
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
    /// Gets or Sets Role
    /// </summary>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public Role Role { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets Verified
    /// </summary>
    [DataMember(Name="_verified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_verified")]
    public bool? Verified { get; set; }

    /// <summary>
    /// Gets or Sets PendingInvite
    /// </summary>
    [DataMember(Name="_pendingInvite", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_pendingInvite")]
    public bool? PendingInvite { get; set; }

    /// <summary>
    /// Gets or Sets IsBeta
    /// </summary>
    [DataMember(Name="isBeta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isBeta")]
    public bool? IsBeta { get; set; }

    /// <summary>
    /// Gets or Sets CustomRoles
    /// </summary>
    [DataMember(Name="customRoles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customRoles")]
    public List<string> CustomRoles { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Member {\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Verified: ").Append(Verified).Append("\n");
      sb.Append("  PendingInvite: ").Append(PendingInvite).Append("\n");
      sb.Append("  IsBeta: ").Append(IsBeta).Append("\n");
      sb.Append("  CustomRoles: ").Append(CustomRoles).Append("\n");
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
