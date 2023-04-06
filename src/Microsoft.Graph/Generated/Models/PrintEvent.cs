using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum PrintEvent {
        [EnumMember(Value = "jobStarted")]
        JobStarted,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
