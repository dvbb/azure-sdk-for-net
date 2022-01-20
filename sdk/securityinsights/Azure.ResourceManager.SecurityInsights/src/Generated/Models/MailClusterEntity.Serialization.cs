// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class MailClusterEntity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MailClusterEntity DeserializeMailClusterEntity(JsonElement element)
        {
            EntityKind kind = default;
            Optional<SystemData> systemData = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<IReadOnlyDictionary<string, object>> additionalData = default;
            Optional<string> friendlyName = default;
            Optional<IReadOnlyList<string>> networkMessageIds = default;
            Optional<object> countByDeliveryStatus = default;
            Optional<object> countByThreatType = default;
            Optional<object> countByProtectionStatus = default;
            Optional<IReadOnlyList<string>> threats = default;
            Optional<string> query = default;
            Optional<DateTimeOffset> queryTime = default;
            Optional<int> mailCount = default;
            Optional<bool> isVolumeAnomaly = default;
            Optional<string> source = default;
            Optional<string> clusterSourceIdentifier = default;
            Optional<string> clusterSourceType = default;
            Optional<DateTimeOffset> clusterQueryStartTime = default;
            Optional<DateTimeOffset> clusterQueryEndTime = default;
            Optional<string> clusterGroup = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new EntityKind(property.Value.GetString());
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
                        if (property0.NameEquals("additionalData"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetObject());
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkMessageIds"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            networkMessageIds = array;
                            continue;
                        }
                        if (property0.NameEquals("countByDeliveryStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            countByDeliveryStatus = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("countByThreatType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            countByThreatType = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("countByProtectionStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            countByProtectionStatus = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("threats"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            threats = array;
                            continue;
                        }
                        if (property0.NameEquals("query"))
                        {
                            query = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("queryTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            queryTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("mailCount"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            mailCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isVolumeAnomaly"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isVolumeAnomaly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("source"))
                        {
                            source = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterSourceIdentifier"))
                        {
                            clusterSourceIdentifier = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterSourceType"))
                        {
                            clusterSourceType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterQueryStartTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterQueryStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("clusterQueryEndTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterQueryEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("clusterGroup"))
                        {
                            clusterGroup = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MailClusterEntity(id, name, type, systemData, kind, Optional.ToDictionary(additionalData), friendlyName.Value, Optional.ToList(networkMessageIds), countByDeliveryStatus.Value, countByThreatType.Value, countByProtectionStatus.Value, Optional.ToList(threats), query.Value, Optional.ToNullable(queryTime), Optional.ToNullable(mailCount), Optional.ToNullable(isVolumeAnomaly), source.Value, clusterSourceIdentifier.Value, clusterSourceType.Value, Optional.ToNullable(clusterQueryStartTime), Optional.ToNullable(clusterQueryEndTime), clusterGroup.Value);
        }
    }
}
