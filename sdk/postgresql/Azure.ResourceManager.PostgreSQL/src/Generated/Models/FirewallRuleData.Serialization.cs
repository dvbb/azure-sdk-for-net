// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PostgreSQL
{
    public partial class FirewallRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("startIpAddress");
            writer.WriteStringValue(StartIpAddress);
            writer.WritePropertyName("endIpAddress");
            writer.WriteStringValue(EndIpAddress);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FirewallRuleData DeserializeFirewallRuleData(JsonElement element)
        {
            Optional<SystemData> systemData = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            string startIpAddress = default;
            string endIpAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("startIpAddress"))
                        {
                            startIpAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endIpAddress"))
                        {
                            endIpAddress = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FirewallRuleData(id, name, type, systemData, startIpAddress, endIpAddress);
        }
    }
}
