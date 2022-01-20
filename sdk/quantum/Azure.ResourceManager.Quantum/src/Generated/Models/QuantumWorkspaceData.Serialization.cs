// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Quantum.Models;

namespace Azure.ResourceManager.Quantum
{
    public partial class QuantumWorkspaceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
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
            if (Optional.IsCollectionDefined(Providers))
            {
                writer.WritePropertyName("providers");
                writer.WriteStartArray();
                foreach (var item in Providers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StorageAccount))
            {
                writer.WritePropertyName("storageAccount");
                writer.WriteStringValue(StorageAccount);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static QuantumWorkspaceData DeserializeQuantumWorkspaceData(JsonElement element)
        {
            Optional<QuantumWorkspaceIdentity> identity = default;
            Optional<SystemData> systemData = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<IList<Provider>> providers = default;
            Optional<UsableStatus> usable = default;
            Optional<ProvisioningStatus> provisioningState = default;
            Optional<string> storageAccount = default;
            Optional<string> endpointUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = QuantumWorkspaceIdentity.DeserializeQuantumWorkspaceIdentity(property.Value);
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
                        if (property0.NameEquals("providers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Provider> array = new List<Provider>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Provider.DeserializeProvider(item));
                            }
                            providers = array;
                            continue;
                        }
                        if (property0.NameEquals("usable"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            usable = new UsableStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageAccount"))
                        {
                            storageAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endpointUri"))
                        {
                            endpointUri = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new QuantumWorkspaceData(id, name, type, tags, location, identity.Value, systemData, Optional.ToList(providers), Optional.ToNullable(usable), Optional.ToNullable(provisioningState), storageAccount.Value, endpointUri.Value);
        }
    }
}
