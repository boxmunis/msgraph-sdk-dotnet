using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the educationRoot singleton.</summary>
    public class OpenShift : ChangeTrackedEntity, IParsable {
        /// <summary>An unpublished open shift.</summary>
        public OpenShiftItem DraftOpenShift { get; set; }
        /// <summary>ID for the scheduling group that the open shift belongs to.</summary>
        public string SchedulingGroupId { get; set; }
        /// <summary>A published open shift.</summary>
        public OpenShiftItem SharedOpenShift { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OpenShift CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OpenShift();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"draftOpenShift", (o,n) => { (o as OpenShift).DraftOpenShift = n.GetObjectValue<OpenShiftItem>(OpenShiftItem.CreateFromDiscriminatorValue); } },
                {"schedulingGroupId", (o,n) => { (o as OpenShift).SchedulingGroupId = n.GetStringValue(); } },
                {"sharedOpenShift", (o,n) => { (o as OpenShift).SharedOpenShift = n.GetObjectValue<OpenShiftItem>(OpenShiftItem.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<OpenShiftItem>("draftOpenShift", DraftOpenShift);
            writer.WriteStringValue("schedulingGroupId", SchedulingGroupId);
            writer.WriteObjectValue<OpenShiftItem>("sharedOpenShift", SharedOpenShift);
        }
    }
}
