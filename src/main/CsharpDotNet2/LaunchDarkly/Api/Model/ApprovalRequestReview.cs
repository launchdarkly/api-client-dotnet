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
  public class ApprovalRequestReview {
    /// <summary>
    /// A unix epoch time in milliseconds specifying the date the approval request was reviewed
    /// </summary>
    /// <value>A unix epoch time in milliseconds specifying the date the approval request was reviewed</value>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public int? CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets Kind
    /// </summary>
    [DataMember(Name="kind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kind")]
    public ApprovalRequestReviewStatus Kind { get; set; }

    /// <summary>
    /// The unique resource id.
    /// </summary>
    /// <value>The unique resource id.</value>
    [DataMember(Name="memberId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memberId")]
    public string MemberId { get; set; }

    /// <summary>
    /// The unique resource id.
    /// </summary>
    /// <value>The unique resource id.</value>
    [DataMember(Name="_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApprovalRequestReview {\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  Kind: ").Append(Kind).Append("\n");
      sb.Append("  MemberId: ").Append(MemberId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
