/* Code generated by Azure.Iot.Operations.ProtocolCompiler v0.9.0.0; DO NOT EDIT. */

#nullable enable

namespace PtzClient.Ptz
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using PtzClient;

    [System.CodeDom.Compiler.GeneratedCode("Azure.Iot.Operations.ProtocolCompiler", "0.9.0.0")]
    public partial class GetConfigurationOptionsRequestPayload : IJsonOnDeserialized, IJsonOnSerializing
    {
        /// <summary>
        /// The Command request argument.
        /// </summary>
        [JsonPropertyName("GetConfigurationOptions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonRequired]
        public GetConfigurationOptions GetConfigurationOptions { get; set; } = default!;

        void IJsonOnDeserialized.OnDeserialized()
        {
            if (GetConfigurationOptions is null)
            {
                throw new ArgumentNullException("GetConfigurationOptions field cannot be null");
            }
        }

        void IJsonOnSerializing.OnSerializing()
        {
            if (GetConfigurationOptions is null)
            {
                throw new ArgumentNullException("GetConfigurationOptions field cannot be null");
            }
        }
    }
}
