using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LaunchDarkly.Api.Model {

  /// <summary>
  /// | Name     | Description | | - -- -- -- -:| - -- -- -- -- -- | | pending  | the feature flag approval request has not been reviewed yet | | approved | the feature flag approval request has been approved and can now be applied | | declined | the feature flag approval request has been declined and cannot be applied | 
  /// </summary>
  [DataContract]
  public class FeatureFlagApprovalRequestReviewStatus {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeatureFlagApprovalRequestReviewStatus {\n");
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
