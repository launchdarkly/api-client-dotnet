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
  public class User {
    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// Gets or Sets Secondary
    /// </summary>
    [DataMember(Name="secondary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secondary")]
    public string Secondary { get; set; }

    /// <summary>
    /// Gets or Sets Ip
    /// </summary>
    [DataMember(Name="ip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ip")]
    public string Ip { get; set; }

    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

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
    /// Gets or Sets Avatar
    /// </summary>
    [DataMember(Name="avatar", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatar")]
    public string Avatar { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Anonymous
    /// </summary>
    [DataMember(Name="anonymous", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "anonymous")]
    public bool? Anonymous { get; set; }

    /// <summary>
    /// Gets or Sets Custom
    /// </summary>
    [DataMember(Name="custom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom")]
    public Object Custom { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class User {\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Secondary: ").Append(Secondary).Append("\n");
      sb.Append("  Ip: ").Append(Ip).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Avatar: ").Append(Avatar).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Anonymous: ").Append(Anonymous).Append("\n");
      sb.Append("  Custom: ").Append(Custom).Append("\n");
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
