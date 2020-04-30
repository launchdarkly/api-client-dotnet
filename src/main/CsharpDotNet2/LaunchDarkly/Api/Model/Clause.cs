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
  public class Clause {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Attribute
    /// </summary>
    [DataMember(Name="attribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attribute")]
    public string Attribute { get; set; }

    /// <summary>
    /// Gets or Sets Op
    /// </summary>
    [DataMember(Name="op", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "op")]
    public string Op { get; set; }

    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    [DataMember(Name="values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "values")]
    public List<Object> Values { get; set; }

    /// <summary>
    /// Gets or Sets Negate
    /// </summary>
    [DataMember(Name="negate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "negate")]
    public bool? Negate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Clause {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Attribute: ").Append(Attribute).Append("\n");
      sb.Append("  Op: ").Append(Op).Append("\n");
      sb.Append("  Values: ").Append(Values).Append("\n");
      sb.Append("  Negate: ").Append(Negate).Append("\n");
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
