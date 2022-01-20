// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    public partial class ClusterData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
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
            if (Optional.IsDefined(IsDoubleEncryptionEnabled))
            {
                writer.WritePropertyName("isDoubleEncryptionEnabled");
                writer.WriteBooleanValue(IsDoubleEncryptionEnabled.Value);
            }
            if (Optional.IsDefined(IsAvailabilityZonesEnabled))
            {
                writer.WritePropertyName("isAvailabilityZonesEnabled");
                writer.WriteBooleanValue(IsAvailabilityZonesEnabled.Value);
            }
            if (Optional.IsDefined(BillingType))
            {
                writer.WritePropertyName("billingType");
                writer.WriteStringValue(BillingType.Value.ToString());
            }
            if (Optional.IsDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties");
                writer.WriteObjectValue(KeyVaultProperties);
            }
            if (Optional.IsCollectionDefined(AssociatedWorkspaces))
            {
                writer.WritePropertyName("associatedWorkspaces");
                writer.WriteStartArray();
                foreach (var item in AssociatedWorkspaces)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CapacityReservationProperties))
            {
                writer.WritePropertyName("capacityReservationProperties");
                writer.WriteObjectValue(CapacityReservationProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ClusterData DeserializeClusterData(JsonElement element)
        {
            Optional<Identity> identity = default;
            Optional<ClusterSku> sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> clusterId = default;
            Optional<ClusterEntityStatus> provisioningState = default;
            Optional<bool> isDoubleEncryptionEnabled = default;
            Optional<bool> isAvailabilityZonesEnabled = default;
            Optional<BillingType> billingType = default;
            Optional<KeyVaultProperties> keyVaultProperties = default;
            Optional<string> lastModifiedDate = default;
            Optional<string> createdDate = default;
            Optional<IList<AssociatedWorkspace>> associatedWorkspaces = default;
            Optional<CapacityReservationProperties> capacityReservationProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = Identity.DeserializeIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = ClusterSku.DeserializeClusterSku(property.Value);
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
                        if (property0.NameEquals("clusterId"))
                        {
                            clusterId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ClusterEntityStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isDoubleEncryptionEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isDoubleEncryptionEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isAvailabilityZonesEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isAvailabilityZonesEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("billingType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            billingType = new BillingType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("keyVaultProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            keyVaultProperties = KeyVaultProperties.DeserializeKeyVaultProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedDate"))
                        {
                            lastModifiedDate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdDate"))
                        {
                            createdDate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("associatedWorkspaces"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<AssociatedWorkspace> array = new List<AssociatedWorkspace>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AssociatedWorkspace.DeserializeAssociatedWorkspace(item));
                            }
                            associatedWorkspaces = array;
                            continue;
                        }
                        if (property0.NameEquals("capacityReservationProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            capacityReservationProperties = CapacityReservationProperties.DeserializeCapacityReservationProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ClusterData(id, name, type, tags, location, identity.Value, sku.Value, clusterId.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(isDoubleEncryptionEnabled), Optional.ToNullable(isAvailabilityZonesEnabled), Optional.ToNullable(billingType), keyVaultProperties.Value, lastModifiedDate.Value, createdDate.Value, Optional.ToList(associatedWorkspaces), capacityReservationProperties.Value);
        }
    }
}
