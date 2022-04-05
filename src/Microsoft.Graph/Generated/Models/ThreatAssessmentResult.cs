using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ThreatAssessmentResult : Entity, IParsable {
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The result message for each threat assessment.</summary>
        public string Message { get; set; }
        /// <summary>The threat assessment result type. Possible values are: checkPolicy, rescan.</summary>
        public ThreatAssessmentResultType? ResultType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ThreatAssessmentResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ThreatAssessmentResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as ThreatAssessmentResult).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"message", (o,n) => { (o as ThreatAssessmentResult).Message = n.GetStringValue(); } },
                {"resultType", (o,n) => { (o as ThreatAssessmentResult).ResultType = n.GetEnumValue<ThreatAssessmentResultType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("message", Message);
            writer.WriteEnumValue<ThreatAssessmentResultType>("resultType", ResultType);
        }
    }
}