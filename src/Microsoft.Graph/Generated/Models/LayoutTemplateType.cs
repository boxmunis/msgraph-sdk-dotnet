using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum LayoutTemplateType {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "verticalSplit")]
        VerticalSplit,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
