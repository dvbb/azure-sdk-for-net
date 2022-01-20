// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ActionRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(LogicAppResourceId))
            {
                writer.WritePropertyName("logicAppResourceId");
                writer.WriteStringValue(LogicAppResourceId);
            }
            if (Optional.IsDefined(TriggerUri))
            {
                writer.WritePropertyName("triggerUri");
                writer.WriteStringValue(TriggerUri);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ActionRequest DeserializeActionRequest(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<SystemData> systemData = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> logicAppResourceId = default;
            Optional<string> triggerUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("logicAppResourceId"))
                        {
                            logicAppResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("triggerUri"))
                        {
                            triggerUri = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ActionRequest(id, name, type, systemData, etag.Value, logicAppResourceId.Value, triggerUri.Value);
        }
    }
}
