// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Redis.Models;

namespace Azure.ResourceManager.Redis
{
    public partial class RedisLinkedServerWithPropertiesData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedRedisCacheId))
            {
                writer.WritePropertyName("linkedRedisCacheId");
                writer.WriteStringValue(LinkedRedisCacheId);
            }
            if (Optional.IsDefined(LinkedRedisCacheLocation))
            {
                writer.WritePropertyName("linkedRedisCacheLocation");
                writer.WriteStringValue(LinkedRedisCacheLocation);
            }
            if (Optional.IsDefined(ServerRole))
            {
                writer.WritePropertyName("serverRole");
                writer.WriteStringValue(ServerRole.Value.ToSerialString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RedisLinkedServerWithPropertiesData DeserializeRedisLinkedServerWithPropertiesData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> linkedRedisCacheId = default;
            Optional<string> linkedRedisCacheLocation = default;
            Optional<ReplicationRole> serverRole = default;
            Optional<string> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("linkedRedisCacheId"))
                        {
                            linkedRedisCacheId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("linkedRedisCacheLocation"))
                        {
                            linkedRedisCacheLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverRole"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serverRole = property0.Value.GetString().ToReplicationRole();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RedisLinkedServerWithPropertiesData(id, name, type, linkedRedisCacheId.Value, linkedRedisCacheLocation.Value, Optional.ToNullable(serverRole), provisioningState.Value);
        }
    }
}
