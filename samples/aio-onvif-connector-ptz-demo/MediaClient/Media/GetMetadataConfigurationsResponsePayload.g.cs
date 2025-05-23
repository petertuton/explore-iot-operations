/* Code generated by Azure.Iot.Operations.ProtocolCompiler v0.9.0.0; DO NOT EDIT. */

#nullable enable

namespace MediaClient.Media
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using MediaClient;

    [System.CodeDom.Compiler.GeneratedCode("Azure.Iot.Operations.ProtocolCompiler", "0.9.0.0")]
    public partial class GetMetadataConfigurationsResponsePayload : IJsonOnDeserialized, IJsonOnSerializing
    {
        /// <summary>
        /// The Command response argument.
        /// </summary>
        [JsonPropertyName("GetMetadataConfigurationsCommandResponse")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonRequired]
        public GetMetadataConfigurationsCommandResponse GetMetadataConfigurationsCommandResponse { get; set; } = default!;

        void IJsonOnDeserialized.OnDeserialized()
        {
            if (GetMetadataConfigurationsCommandResponse is null)
            {
                throw new ArgumentNullException("GetMetadataConfigurationsCommandResponse field cannot be null");
            }
        }

        void IJsonOnSerializing.OnSerializing()
        {
            if (GetMetadataConfigurationsCommandResponse is null)
            {
                throw new ArgumentNullException("GetMetadataConfigurationsCommandResponse field cannot be null");
            }
        }
    }
}
