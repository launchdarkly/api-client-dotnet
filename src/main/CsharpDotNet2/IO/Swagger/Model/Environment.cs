using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Environment {
    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public Links Links { get; set; }

    /// <summary>
    /// The unique id for the environment.
    /// </summary>
    /// <value>The unique id for the environment.</value>
    [DataMember(Name="_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_id")]
    public string Id { get; set; }

    /// <summary>
    /// The key for the environment.
    /// </summary>
    /// <value>The key for the environment.</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// The name of the environment.
    /// </summary>
    /// <value>The name of the environment.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The SDK key for backend LaunchDarkly SDKs.
    /// </summary>
    /// <value>The SDK key for backend LaunchDarkly SDKs.</value>
    [DataMember(Name="apiKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiKey")]
    public string ApiKey { get; set; }

    /// <summary>
    /// The SDK key for mobile LaunchDarkly SDKs.
    /// </summary>
    /// <value>The SDK key for mobile LaunchDarkly SDKs.</value>
    [DataMember(Name="mobileKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobileKey")]
    public string MobileKey { get; set; }

    /// <summary>
    /// The swatch color for the environment.
    /// </summary>
    /// <value>The swatch color for the environment.</value>
    [DataMember(Name="color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color")]
    public string Color { get; set; }

    /// <summary>
    /// The default TTL.
    /// </summary>
    /// <value>The default TTL.</value>
    [DataMember(Name="defaultTtl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultTtl")]
    public decimal? DefaultTtl { get; set; }

    /// <summary>
    /// Determines if this environment is in safe mode.
    /// </summary>
    /// <value>Determines if this environment is in safe mode.</value>
    [DataMember(Name="secureMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secureMode")]
    public bool? SecureMode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Environment {\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
      sb.Append("  MobileKey: ").Append(MobileKey).Append("\n");
      sb.Append("  Color: ").Append(Color).Append("\n");
      sb.Append("  DefaultTtl: ").Append(DefaultTtl).Append("\n");
      sb.Append("  SecureMode: ").Append(SecureMode).Append("\n");
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
