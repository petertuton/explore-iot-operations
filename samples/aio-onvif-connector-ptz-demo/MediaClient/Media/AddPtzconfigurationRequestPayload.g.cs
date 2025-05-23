/* Code generated by Azure.Iot.Operations.ProtocolCompiler v0.9.0.0; DO NOT EDIT. */

#nullable enable

namespace MediaClient.Media
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using MediaClient;

    [System.CodeDom.Compiler.GeneratedCode("Azure.Iot.Operations.ProtocolCompiler", "0.9.0.0")]
    public partial class AddPtzconfigurationRequestPayload : IJsonOnDeserialized, IJsonOnSerializing
    {
        /// <summary>
        /// The Command request argument.
        /// </summary>
        [JsonPropertyName("AddPTZConfiguration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonRequired]
        public AddPtzconfiguration AddPtzconfiguration { get; set; } = default!;

        void IJsonOnDeserialized.OnDeserialized()
        {
            if (AddPtzconfiguration is null)
            {
                throw new ArgumentNullException("AddPTZConfiguration field cannot be null");
            }
        }

        void IJsonOnSerializing.OnSerializing()
        {
            if (AddPtzconfiguration is null)
            {
                throw new ArgumentNullException("AddPTZConfiguration field cannot be null");
            }
        }
    }
}
