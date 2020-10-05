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
  public class RelayProxyConfig {
    /// <summary>
    /// The unique resource id.
    /// </summary>
    /// <value>The unique resource id.</value>
    [DataMember(Name="_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Creator
    /// </summary>
    [DataMember(Name="_creator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_creator")]
    public Member Creator { get; set; }

    /// <summary>
    /// A human-friendly name for the relay proxy configuration
    /// </summary>
    /// <value>A human-friendly name for the relay proxy configuration</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Policy
    /// </summary>
    [DataMember(Name="policy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "policy")]
    public List<Policy> Policy { get; set; }

    /// <summary>
    /// Full secret key. Only included if creating or resetting the relay proxy configuration
    /// </summary>
    /// <value>Full secret key. Only included if creating or resetting the relay proxy configuration</value>
    [DataMember(Name="fullKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullKey")]
    public string FullKey { get; set; }

    /// <summary>
    /// The last 4 digits of the unique secret key for this relay proxy configuration
    /// </summary>
    /// <value>The last 4 digits of the unique secret key for this relay proxy configuration</value>
    [DataMember(Name="displayKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayKey")]
    public string DisplayKey { get; set; }

    /// <summary>
    /// A unix epoch time in milliseconds specifying the creation time of this relay proxy configuration
    /// </summary>
    /// <value>A unix epoch time in milliseconds specifying the creation time of this relay proxy configuration</value>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public long? CreationDate { get; set; }

    /// <summary>
    /// A unix epoch time in milliseconds specifying the last time this relay proxy configuration was modified
    /// </summary>
    /// <value>A unix epoch time in milliseconds specifying the last time this relay proxy configuration was modified</value>
    [DataMember(Name="lastModified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastModified")]
    public long? LastModified { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RelayProxyConfig {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Creator: ").Append(Creator).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Policy: ").Append(Policy).Append("\n");
      sb.Append("  FullKey: ").Append(FullKey).Append("\n");
      sb.Append("  DisplayKey: ").Append(DisplayKey).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  LastModified: ").Append(LastModified).Append("\n");
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
