// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ApplicationResourceUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(TypeVersion))
            {
                writer.WritePropertyName("typeVersion");
                writer.WriteStringValue(TypeVersion);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(UpgradePolicy))
            {
                writer.WritePropertyName("upgradePolicy");
                writer.WriteObjectValue(UpgradePolicy);
            }
            if (Optional.IsDefined(MinimumNodes))
            {
                writer.WritePropertyName("minimumNodes");
                writer.WriteNumberValue(MinimumNodes.Value);
            }
            if (Optional.IsDefined(MaximumNodes))
            {
                writer.WritePropertyName("maximumNodes");
                writer.WriteNumberValue(MaximumNodes.Value);
            }
            if (Optional.IsDefined(RemoveApplicationCapacity))
            {
                writer.WritePropertyName("removeApplicationCapacity");
                writer.WriteBooleanValue(RemoveApplicationCapacity.Value);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics");
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ManagedIdentities))
            {
                writer.WritePropertyName("managedIdentities");
                writer.WriteStartArray();
                foreach (var item in ManagedIdentities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationResourceUpdate DeserializeApplicationResourceUpdate(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<SystemData> systemData = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> typeVersion = default;
            Optional<IDictionary<string, string>> parameters = default;
            Optional<ApplicationUpgradePolicy> upgradePolicy = default;
            Optional<long> minimumNodes = default;
            Optional<long> maximumNodes = default;
            Optional<bool> removeApplicationCapacity = default;
            Optional<IList<ApplicationMetricDescription>> metrics = default;
            Optional<IList<ApplicationUserAssignedIdentity>> managedIdentities = default;
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
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
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
                        if (property0.NameEquals("typeVersion"))
                        {
                            typeVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parameters"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("upgradePolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            upgradePolicy = ApplicationUpgradePolicy.DeserializeApplicationUpgradePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("minimumNodes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            minimumNodes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("maximumNodes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maximumNodes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("removeApplicationCapacity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            removeApplicationCapacity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("metrics"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationMetricDescription> array = new List<ApplicationMetricDescription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationMetricDescription.DeserializeApplicationMetricDescription(item));
                            }
                            metrics = array;
                            continue;
                        }
                        if (property0.NameEquals("managedIdentities"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationUserAssignedIdentity> array = new List<ApplicationUserAssignedIdentity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationUserAssignedIdentity.DeserializeApplicationUserAssignedIdentity(item));
                            }
                            managedIdentities = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationResourceUpdate(id, name, type, tags, location, etag.Value, systemData, typeVersion.Value, Optional.ToDictionary(parameters), upgradePolicy.Value, Optional.ToNullable(minimumNodes), Optional.ToNullable(maximumNodes), Optional.ToNullable(removeApplicationCapacity), Optional.ToList(metrics), Optional.ToList(managedIdentities));
        }
    }
}
