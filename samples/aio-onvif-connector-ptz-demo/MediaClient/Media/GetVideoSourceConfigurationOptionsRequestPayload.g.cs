/* Code generated by Azure.Iot.Operations.ProtocolCompiler v0.9.0.0; DO NOT EDIT. */

#nullable enable

namespace MediaClient.Media
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using MediaClient;

    [System.CodeDom.Compiler.GeneratedCode("Azure.Iot.Operations.ProtocolCompiler", "0.9.0.0")]
    public partial class GetVideoSourceConfigurationOptionsRequestPayload : IJsonOnDeserialized, IJsonOnSerializing
    {
        /// <summary>
        /// The Command request argument.
        /// </summary>
        [JsonPropertyName("GetVideoSourceConfigurationOptions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonRequired]
        public GetVideoSourceConfigurationOptions GetVideoSourceConfigurationOptions { get; set; } = default!;

        void IJsonOnDeserialized.OnDeserialized()
        {
            if (GetVideoSourceConfigurationOptions is null)
            {
                throw new ArgumentNullException("GetVideoSourceConfigurationOptions field cannot be null");
            }
        }

        void IJsonOnSerializing.OnSerializing()
        {
            if (GetVideoSourceConfigurationOptions is null)
            {
                throw new ArgumentNullException("GetVideoSourceConfigurationOptions field cannot be null");
            }
        }
    }
}
