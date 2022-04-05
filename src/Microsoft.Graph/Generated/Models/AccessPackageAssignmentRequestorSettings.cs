using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class AccessPackageAssignmentRequestorSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If false, the requestor is not permitted to include a schedule in their request.</summary>
        public bool? AllowCustomAssignmentSchedule { get; set; }
        /// <summary>If true, allows on-behalf-of requestors to create a request to add access for another principal.</summary>
        public bool? EnableOnBehalfRequestorsToAddAccess { get; set; }
        /// <summary>If true, allows on-behalf-of requestors to create a request to remove access for another principal.</summary>
        public bool? EnableOnBehalfRequestorsToRemoveAccess { get; set; }
        /// <summary>If true, allows on-behalf-of requestors to create a request to update access for another principal.</summary>
        public bool? EnableOnBehalfRequestorsToUpdateAccess { get; set; }
        /// <summary>If true, allows requestors to create a request to add access for themselves.</summary>
        public bool? EnableTargetsToSelfAddAccess { get; set; }
        /// <summary>If true, allows requestors to create a request to remove their access.</summary>
        public bool? EnableTargetsToSelfRemoveAccess { get; set; }
        /// <summary>If true, allows requestors to create a request to update their access.</summary>
        public bool? EnableTargetsToSelfUpdateAccess { get; set; }
        /// <summary>The principals who can request on-behalf-of others.</summary>
        public List<SubjectSet> OnBehalfRequestors { get; set; }
        /// <summary>
        /// Instantiates a new accessPackageAssignmentRequestorSettings and sets the default values.
        /// </summary>
        public AccessPackageAssignmentRequestorSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessPackageAssignmentRequestorSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentRequestorSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowCustomAssignmentSchedule", (o,n) => { (o as AccessPackageAssignmentRequestorSettings).AllowCustomAssignmentSchedule = n.GetBoolValue(); } },
                {"enableOnBehalfRequestorsToAddAccess", (o,n) => { (o as AccessPackageAssignmentRequestorSettings).EnableOnBehalfRequestorsToAddAccess = n.GetBoolValue(); } },
                {"enableOnBehalfRequestorsToRemoveAccess", (o,n) => { (o as AccessPackageAssignmentRequestorSettings).EnableOnBehalfRequestorsToRemoveAccess = n.GetBoolValue(); } },
                {"enableOnBehalfRequestorsToUpdateAccess", (o,n) => { (o as AccessPackageAssignmentRequestorSettings).EnableOnBehalfRequestorsToUpdateAccess = n.GetBoolValue(); } },
                {"enableTargetsToSelfAddAccess", (o,n) => { (o as AccessPackageAssignmentRequestorSettings).EnableTargetsToSelfAddAccess = n.GetBoolValue(); } },
                {"enableTargetsToSelfRemoveAccess", (o,n) => { (o as AccessPackageAssignmentRequestorSettings).EnableTargetsToSelfRemoveAccess = n.GetBoolValue(); } },
                {"enableTargetsToSelfUpdateAccess", (o,n) => { (o as AccessPackageAssignmentRequestorSettings).EnableTargetsToSelfUpdateAccess = n.GetBoolValue(); } },
                {"onBehalfRequestors", (o,n) => { (o as AccessPackageAssignmentRequestorSettings).OnBehalfRequestors = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowCustomAssignmentSchedule", AllowCustomAssignmentSchedule);
            writer.WriteBoolValue("enableOnBehalfRequestorsToAddAccess", EnableOnBehalfRequestorsToAddAccess);
            writer.WriteBoolValue("enableOnBehalfRequestorsToRemoveAccess", EnableOnBehalfRequestorsToRemoveAccess);
            writer.WriteBoolValue("enableOnBehalfRequestorsToUpdateAccess", EnableOnBehalfRequestorsToUpdateAccess);
            writer.WriteBoolValue("enableTargetsToSelfAddAccess", EnableTargetsToSelfAddAccess);
            writer.WriteBoolValue("enableTargetsToSelfRemoveAccess", EnableTargetsToSelfRemoveAccess);
            writer.WriteBoolValue("enableTargetsToSelfUpdateAccess", EnableTargetsToSelfUpdateAccess);
            writer.WriteCollectionOfObjectValues<SubjectSet>("onBehalfRequestors", OnBehalfRequestors);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
