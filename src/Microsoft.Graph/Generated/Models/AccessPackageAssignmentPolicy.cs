using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class AccessPackageAssignmentPolicy : Entity, IParsable {
        /// <summary>The access package with this policy. Read-only. Nullable. Supports $expand.</summary>
        public Microsoft.Graph.Models.AccessPackage AccessPackage { get; set; }
        /// <summary>The allowedTargetScope property</summary>
        public Microsoft.Graph.Models.AllowedTargetScope? AllowedTargetScope { get; set; }
        /// <summary>The catalog property</summary>
        public AccessPackageCatalog Catalog { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of the policy.</summary>
        public string Description { get; set; }
        /// <summary>The display name of the policy. Supports $filter (eq).</summary>
        public string DisplayName { get; set; }
        /// <summary>The expiration property</summary>
        public ExpirationPattern Expiration { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>Who must approve requests for access package in this policy.</summary>
        public AccessPackageAssignmentApprovalSettings RequestApprovalSettings { get; set; }
        /// <summary>Who can request this access package from this policy.</summary>
        public AccessPackageAssignmentRequestorSettings RequestorSettings { get; set; }
        /// <summary>The reviewSettings property</summary>
        public AccessPackageAssignmentReviewSettings ReviewSettings { get; set; }
        /// <summary>The specificAllowedTargets property</summary>
        public List<SubjectSet> SpecificAllowedTargets { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessPackageAssignmentPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"accessPackage", (o,n) => { (o as AccessPackageAssignmentPolicy).AccessPackage = n.GetObjectValue<Microsoft.Graph.Models.AccessPackage>(Microsoft.Graph.Models.AccessPackage.CreateFromDiscriminatorValue); } },
                {"allowedTargetScope", (o,n) => { (o as AccessPackageAssignmentPolicy).AllowedTargetScope = n.GetEnumValue<AllowedTargetScope>(); } },
                {"catalog", (o,n) => { (o as AccessPackageAssignmentPolicy).Catalog = n.GetObjectValue<AccessPackageCatalog>(AccessPackageCatalog.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as AccessPackageAssignmentPolicy).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as AccessPackageAssignmentPolicy).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AccessPackageAssignmentPolicy).DisplayName = n.GetStringValue(); } },
                {"expiration", (o,n) => { (o as AccessPackageAssignmentPolicy).Expiration = n.GetObjectValue<ExpirationPattern>(ExpirationPattern.CreateFromDiscriminatorValue); } },
                {"modifiedDateTime", (o,n) => { (o as AccessPackageAssignmentPolicy).ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"requestApprovalSettings", (o,n) => { (o as AccessPackageAssignmentPolicy).RequestApprovalSettings = n.GetObjectValue<AccessPackageAssignmentApprovalSettings>(AccessPackageAssignmentApprovalSettings.CreateFromDiscriminatorValue); } },
                {"requestorSettings", (o,n) => { (o as AccessPackageAssignmentPolicy).RequestorSettings = n.GetObjectValue<AccessPackageAssignmentRequestorSettings>(AccessPackageAssignmentRequestorSettings.CreateFromDiscriminatorValue); } },
                {"reviewSettings", (o,n) => { (o as AccessPackageAssignmentPolicy).ReviewSettings = n.GetObjectValue<AccessPackageAssignmentReviewSettings>(AccessPackageAssignmentReviewSettings.CreateFromDiscriminatorValue); } },
                {"specificAllowedTargets", (o,n) => { (o as AccessPackageAssignmentPolicy).SpecificAllowedTargets = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteEnumValue<AllowedTargetScope>("allowedTargetScope", AllowedTargetScope);
            writer.WriteObjectValue<AccessPackageCatalog>("catalog", Catalog);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<ExpirationPattern>("expiration", Expiration);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteObjectValue<AccessPackageAssignmentApprovalSettings>("requestApprovalSettings", RequestApprovalSettings);
            writer.WriteObjectValue<AccessPackageAssignmentRequestorSettings>("requestorSettings", RequestorSettings);
            writer.WriteObjectValue<AccessPackageAssignmentReviewSettings>("reviewSettings", ReviewSettings);
            writer.WriteCollectionOfObjectValues<SubjectSet>("specificAllowedTargets", SpecificAllowedTargets);
        }
    }
}