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
  public class ApprovalRequest {
    /// <summary>
    /// The unique resource id.
    /// </summary>
    /// <value>The unique resource id.</value>
    [DataMember(Name="_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_version")]
    public int? Version { get; set; }

    /// <summary>
    /// A unix epoch time in milliseconds specifying the date the approval request was requested
    /// </summary>
    /// <value>A unix epoch time in milliseconds specifying the date the approval request was requested</value>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public int? CreationDate { get; set; }

    /// <summary>
    /// The id of the member that requested the change
    /// </summary>
    /// <value>The id of the member that requested the change</value>
    [DataMember(Name="requestorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestorId")]
    public string RequestorId { get; set; }

    /// <summary>
    /// Gets or Sets ReviewStatus
    /// </summary>
    [DataMember(Name="reviewStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reviewStatus")]
    public ApprovalRequestReviewStatus ReviewStatus { get; set; }

    /// <summary>
    /// | Name      | Description | | - -- -- -- --:| - -- -- -- -- -- | | pending   | the approval request has not been applied yet | | completed | the approval request has been applied successfully | | scheduled | the approval request for a scheduled change has been applied successfully | | failed    | the approval request has been applied but the changes were not applied successfully | 
    /// </summary>
    /// <value>| Name      | Description | | - -- -- -- --:| - -- -- -- -- -- | | pending   | the approval request has not been applied yet | | completed | the approval request has been applied successfully | | scheduled | the approval request for a scheduled change has been applied successfully | | failed    | the approval request has been applied but the changes were not applied successfully | </value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The id of the member that applied the approval request
    /// </summary>
    /// <value>The id of the member that applied the approval request</value>
    [DataMember(Name="appliedByMemberID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appliedByMemberID")]
    public string AppliedByMemberID { get; set; }

    /// <summary>
    /// A unix epoch time in milliseconds specifying the date the approval request was applied
    /// </summary>
    /// <value>A unix epoch time in milliseconds specifying the date the approval request was applied</value>
    [DataMember(Name="appliedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appliedDate")]
    public int? AppliedDate { get; set; }

    /// <summary>
    /// Gets or Sets AllReviews
    /// </summary>
    [DataMember(Name="allReviews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allReviews")]
    public List<ApprovalRequestReview> AllReviews { get; set; }

    /// <summary>
    /// Gets or Sets NotifyMemberIds
    /// </summary>
    [DataMember(Name="notifyMemberIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notifyMemberIds")]
    public List<string> NotifyMemberIds { get; set; }

    /// <summary>
    /// Gets or Sets Instructions
    /// </summary>
    [DataMember(Name="instructions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instructions")]
    public SemanticPatchInstruction Instructions { get; set; }

    /// <summary>
    /// Timestamp for when instructions will be executed
    /// </summary>
    /// <value>Timestamp for when instructions will be executed</value>
    [DataMember(Name="executionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "executionDate")]
    public long? ExecutionDate { get; set; }

    /// <summary>
    /// ID of scheduled change to edit or delete
    /// </summary>
    /// <value>ID of scheduled change to edit or delete</value>
    [DataMember(Name="operatingOnId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operatingOnId")]
    public string OperatingOnId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApprovalRequest {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  RequestorId: ").Append(RequestorId).Append("\n");
      sb.Append("  ReviewStatus: ").Append(ReviewStatus).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  AppliedByMemberID: ").Append(AppliedByMemberID).Append("\n");
      sb.Append("  AppliedDate: ").Append(AppliedDate).Append("\n");
      sb.Append("  AllReviews: ").Append(AllReviews).Append("\n");
      sb.Append("  NotifyMemberIds: ").Append(NotifyMemberIds).Append("\n");
      sb.Append("  Instructions: ").Append(Instructions).Append("\n");
      sb.Append("  ExecutionDate: ").Append(ExecutionDate).Append("\n");
      sb.Append("  OperatingOnId: ").Append(OperatingOnId).Append("\n");
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
