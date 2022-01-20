// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    public partial class HardwareComponent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("componentId");
            writer.WriteStringValue(ComponentId);
            writer.WritePropertyName("displayName");
            writer.WriteStringValue(DisplayName);
            writer.WritePropertyName("status");
            writer.WriteStringValue(Status.ToSerialString());
            writer.WritePropertyName("statusDisplayName");
            writer.WriteStringValue(StatusDisplayName);
            writer.WriteEndObject();
        }

        internal static HardwareComponent DeserializeHardwareComponent(JsonElement element)
        {
            string componentId = default;
            string displayName = default;
            HardwareComponentStatus status = default;
            string statusDisplayName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("componentId"))
                {
                    componentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToHardwareComponentStatus();
                    continue;
                }
                if (property.NameEquals("statusDisplayName"))
                {
                    statusDisplayName = property.Value.GetString();
                    continue;
                }
            }
            return new HardwareComponent(componentId, displayName, status, statusDisplayName);
        }
    }
}
