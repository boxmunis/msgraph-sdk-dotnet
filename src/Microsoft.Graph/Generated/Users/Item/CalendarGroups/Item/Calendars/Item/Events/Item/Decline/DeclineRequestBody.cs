using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Users.Item.CalendarGroups.Item.Calendars.Item.Events.Item.Decline {
    /// <summary>Provides operations to call the decline method.</summary>
    public class DeclineRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Comment { get; set; }
        public TimeSlot ProposedNewTime { get; set; }
        public bool? SendResponse { get; set; }
        /// <summary>
        /// Instantiates a new declineRequestBody and sets the default values.
        /// </summary>
        public DeclineRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeclineRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeclineRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"comment", (o,n) => { (o as DeclineRequestBody).Comment = n.GetStringValue(); } },
                {"proposedNewTime", (o,n) => { (o as DeclineRequestBody).ProposedNewTime = n.GetObjectValue<TimeSlot>(TimeSlot.CreateFromDiscriminatorValue); } },
                {"sendResponse", (o,n) => { (o as DeclineRequestBody).SendResponse = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("comment", Comment);
            writer.WriteObjectValue<TimeSlot>("proposedNewTime", ProposedNewTime);
            writer.WriteBoolValue("sendResponse", SendResponse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}