/* Code generated by Azure.Iot.Operations.ProtocolCompiler v0.9.0.0; DO NOT EDIT. */

#nullable enable

namespace MediaClient.Media
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    [System.CodeDom.Compiler.GeneratedCode("Azure.Iot.Operations.ProtocolCompiler", "0.9.0.0")]
    public enum H264profile
    {
        [EnumMember(Value = @"Baseline")]
        Baseline = 0,
        [EnumMember(Value = @"Extended")]
        Extended = 1,
        [EnumMember(Value = @"High")]
        High = 2,
        [EnumMember(Value = @"Main")]
        Main = 3,
        [EnumMember(Value = @"Unknown")]
        Unknown = 4,
    }
}
