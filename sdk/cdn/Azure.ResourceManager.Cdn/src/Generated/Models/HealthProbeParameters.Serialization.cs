// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class HealthProbeParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProbePath))
            {
                writer.WritePropertyName("probePath");
                writer.WriteStringValue(ProbePath);
            }
            if (Optional.IsDefined(ProbeRequestType))
            {
                writer.WritePropertyName("probeRequestType");
                writer.WriteStringValue(ProbeRequestType.Value.ToSerialString());
            }
            if (Optional.IsDefined(ProbeProtocol))
            {
                writer.WritePropertyName("probeProtocol");
                writer.WriteStringValue(ProbeProtocol.Value.ToSerialString());
            }
            if (Optional.IsDefined(ProbeIntervalInSeconds))
            {
                writer.WritePropertyName("probeIntervalInSeconds");
                writer.WriteNumberValue(ProbeIntervalInSeconds.Value);
            }
            writer.WriteEndObject();
        }

        internal static HealthProbeParameters DeserializeHealthProbeParameters(JsonElement element)
        {
            Optional<string> probePath = default;
            Optional<HealthProbeRequestType> probeRequestType = default;
            Optional<ProbeProtocol> probeProtocol = default;
            Optional<int> probeIntervalInSeconds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("probePath"))
                {
                    probePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("probeRequestType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    probeRequestType = property.Value.GetString().ToHealthProbeRequestType();
                    continue;
                }
                if (property.NameEquals("probeProtocol"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    probeProtocol = property.Value.GetString().ToProbeProtocol();
                    continue;
                }
                if (property.NameEquals("probeIntervalInSeconds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    probeIntervalInSeconds = property.Value.GetInt32();
                    continue;
                }
            }
            return new HealthProbeParameters(probePath.Value, Optional.ToNullable(probeRequestType), Optional.ToNullable(probeProtocol), Optional.ToNullable(probeIntervalInSeconds));
        }
    }
}
