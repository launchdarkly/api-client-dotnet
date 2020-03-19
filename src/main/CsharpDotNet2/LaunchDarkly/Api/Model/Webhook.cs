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
  public class Webhook {
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
    /// The URL of the remote webhook.
    /// </summary>
    /// <value>The URL of the remote webhook.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// If defined, the webhooks post request will include a X-LD-Signature header whose value will contain an HMAC SHA256 hex digest of the webhook payload, using the secret as the key.
    /// </summary>
    /// <value>If defined, the webhooks post request will include a X-LD-Signature header whose value will contain an HMAC SHA256 hex digest of the webhook payload, using the secret as the key.</value>
    [DataMember(Name="secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret")]
    public string Secret { get; set; }

    /// <summary>
    /// Whether this webhook is enabled or not.
    /// </summary>
    /// <value>Whether this webhook is enabled or not.</value>
    [DataMember(Name="on", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "on")]
    public bool? On { get; set; }

    /// <summary>
    /// The name of the webhook.
    /// </summary>
    /// <value>The name of the webhook.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Statements
    /// </summary>
    [DataMember(Name="statements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statements")]
    public List<Statement> Statements { get; set; }

    /// <summary>
    /// Tags assigned to this webhook.
    /// </summary>
    /// <value>Tags assigned to this webhook.</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Webhook {\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
      sb.Append("  On: ").Append(On).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Statements: ").Append(Statements).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
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
