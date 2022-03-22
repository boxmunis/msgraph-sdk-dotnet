using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class WorkbookTableColumn : Entity, IParsable {
        /// <summary>Retrieve the filter applied to the column. Read-only.</summary>
        public WorkbookFilter Filter { get; set; }
        /// <summary>Returns the index number of the column within the columns collection of the table. Zero-indexed. Read-only.</summary>
        public int? Index { get; set; }
        /// <summary>Returns the name of the table column.</summary>
        public string Name { get; set; }
        /// <summary>Represents the raw values of the specified range. The data returned could be of type string, number, or a boolean. Cell that contain an error will return the error string.</summary>
        public Json Values { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkbookTableColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookTableColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"filter", (o,n) => { (o as WorkbookTableColumn).Filter = n.GetObjectValue<WorkbookFilter>(WorkbookFilter.CreateFromDiscriminatorValue); } },
                {"index", (o,n) => { (o as WorkbookTableColumn).Index = n.GetIntValue(); } },
                {"name", (o,n) => { (o as WorkbookTableColumn).Name = n.GetStringValue(); } },
                {"values", (o,n) => { (o as WorkbookTableColumn).Values = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookFilter>("filter", Filter);
            writer.WriteIntValue("index", Index);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<Json>("values", Values);
        }
    }
}