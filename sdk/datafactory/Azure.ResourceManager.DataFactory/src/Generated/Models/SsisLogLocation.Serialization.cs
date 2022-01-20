// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SsisLogLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("logPath");
            writer.WriteObjectValue(LogPath);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AccessCredential))
            {
                writer.WritePropertyName("accessCredential");
                writer.WriteObjectValue(AccessCredential);
            }
            if (Optional.IsDefined(LogRefreshInterval))
            {
                writer.WritePropertyName("logRefreshInterval");
                writer.WriteObjectValue(LogRefreshInterval);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SsisLogLocation DeserializeSsisLogLocation(JsonElement element)
        {
            object logPath = default;
            SsisLogLocationType type = default;
            Optional<SsisAccessCredential> accessCredential = default;
            Optional<object> logRefreshInterval = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logPath"))
                {
                    logPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new SsisLogLocationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("accessCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            accessCredential = SsisAccessCredential.DeserializeSsisAccessCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("logRefreshInterval"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            logRefreshInterval = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SsisLogLocation(logPath, type, accessCredential.Value, logRefreshInterval.Value);
        }
    }
}
