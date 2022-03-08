using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getApplicablePolicyRequirements method.</summary>
    public class AccessPackageAssignmentRequestRequirements : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether the requestor is allowed to set a custom schedule.</summary>
        public bool? AllowCustomAssignmentSchedule { get; set; }
        /// <summary>Indicates whether a request to add must be approved by an approver.</summary>
        public bool? IsApprovalRequiredForAdd { get; set; }
        /// <summary>Indicates whether a request to update must be approved by an approver.</summary>
        public bool? IsApprovalRequiredForUpdate { get; set; }
        /// <summary>The description of the policy that the user is trying to request access using.</summary>
        public string PolicyDescription { get; set; }
        /// <summary>The display name of the policy that the user is trying to request access using.</summary>
        public string PolicyDisplayName { get; set; }
        /// <summary>The identifier of the policy that these requirements are associated with. This identifier can be used when creating a new assignment request.</summary>
        public string PolicyId { get; set; }
        /// <summary>Schedule restrictions enforced, if any.</summary>
        public EntitlementManagementSchedule Schedule { get; set; }
        /// <summary>
        /// Instantiates a new accessPackageAssignmentRequestRequirements and sets the default values.
        /// </summary>
        public AccessPackageAssignmentRequestRequirements() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessPackageAssignmentRequestRequirements CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentRequestRequirements();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowCustomAssignmentSchedule", (o,n) => { (o as AccessPackageAssignmentRequestRequirements).AllowCustomAssignmentSchedule = n.GetBoolValue(); } },
                {"isApprovalRequiredForAdd", (o,n) => { (o as AccessPackageAssignmentRequestRequirements).IsApprovalRequiredForAdd = n.GetBoolValue(); } },
                {"isApprovalRequiredForUpdate", (o,n) => { (o as AccessPackageAssignmentRequestRequirements).IsApprovalRequiredForUpdate = n.GetBoolValue(); } },
                {"policyDescription", (o,n) => { (o as AccessPackageAssignmentRequestRequirements).PolicyDescription = n.GetStringValue(); } },
                {"policyDisplayName", (o,n) => { (o as AccessPackageAssignmentRequestRequirements).PolicyDisplayName = n.GetStringValue(); } },
                {"policyId", (o,n) => { (o as AccessPackageAssignmentRequestRequirements).PolicyId = n.GetStringValue(); } },
                {"schedule", (o,n) => { (o as AccessPackageAssignmentRequestRequirements).Schedule = n.GetObjectValue<EntitlementManagementSchedule>(EntitlementManagementSchedule.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowCustomAssignmentSchedule", AllowCustomAssignmentSchedule);
            writer.WriteBoolValue("isApprovalRequiredForAdd", IsApprovalRequiredForAdd);
            writer.WriteBoolValue("isApprovalRequiredForUpdate", IsApprovalRequiredForUpdate);
            writer.WriteStringValue("policyDescription", PolicyDescription);
            writer.WriteStringValue("policyDisplayName", PolicyDisplayName);
            writer.WriteStringValue("policyId", PolicyId);
            writer.WriteObjectValue<EntitlementManagementSchedule>("schedule", Schedule);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
