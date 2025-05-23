/* Code generated by Azure.Iot.Operations.ProtocolCompiler v0.9.0.0; DO NOT EDIT. */

#nullable enable

namespace PtzClient.Ptz
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using PtzClient;

    [System.CodeDom.Compiler.GeneratedCode("Azure.Iot.Operations.ProtocolCompiler", "0.9.0.0")]
    public partial class GetNodesResponsePayload : IJsonOnDeserialized, IJsonOnSerializing
    {
        /// <summary>
        /// The Command response argument.
        /// </summary>
        [JsonPropertyName("GetNodesCommandResponse")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonRequired]
        public GetNodesCommandResponse GetNodesCommandResponse { get; set; } = default!;

        void IJsonOnDeserialized.OnDeserialized()
        {
            if (GetNodesCommandResponse is null)
            {
                throw new ArgumentNullException("GetNodesCommandResponse field cannot be null");
            }
        }

        void IJsonOnSerializing.OnSerializing()
        {
            if (GetNodesCommandResponse is null)
            {
                throw new ArgumentNullException("GetNodesCommandResponse field cannot be null");
            }
        }
    }
}
