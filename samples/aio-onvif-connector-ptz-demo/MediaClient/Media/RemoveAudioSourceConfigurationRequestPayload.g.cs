/* Code generated by Azure.Iot.Operations.ProtocolCompiler v0.9.0.0; DO NOT EDIT. */

#nullable enable

namespace MediaClient.Media
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using MediaClient;

    [System.CodeDom.Compiler.GeneratedCode("Azure.Iot.Operations.ProtocolCompiler", "0.9.0.0")]
    public partial class RemoveAudioSourceConfigurationRequestPayload : IJsonOnDeserialized, IJsonOnSerializing
    {
        /// <summary>
        /// The Command request argument.
        /// </summary>
        [JsonPropertyName("RemoveAudioSourceConfiguration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonRequired]
        public RemoveAudioSourceConfiguration RemoveAudioSourceConfiguration { get; set; } = default!;

        void IJsonOnDeserialized.OnDeserialized()
        {
            if (RemoveAudioSourceConfiguration is null)
            {
                throw new ArgumentNullException("RemoveAudioSourceConfiguration field cannot be null");
            }
        }

        void IJsonOnSerializing.OnSerializing()
        {
            if (RemoveAudioSourceConfiguration is null)
            {
                throw new ArgumentNullException("RemoveAudioSourceConfiguration field cannot be null");
            }
        }
    }
}
