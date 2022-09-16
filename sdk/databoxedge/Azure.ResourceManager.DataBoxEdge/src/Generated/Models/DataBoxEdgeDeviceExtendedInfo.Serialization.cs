// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeDeviceExtendedInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(EncryptionKeyThumbprint))
            {
                writer.WritePropertyName("encryptionKeyThumbprint");
                writer.WriteStringValue(EncryptionKeyThumbprint);
            }
            if (Optional.IsDefined(EncryptionKey))
            {
                writer.WritePropertyName("encryptionKey");
                writer.WriteStringValue(EncryptionKey);
            }
            if (Optional.IsDefined(ClientSecretStoreId))
            {
                writer.WritePropertyName("clientSecretStoreId");
                writer.WriteStringValue(ClientSecretStoreId);
            }
            if (Optional.IsDefined(ClientSecretStoreUri))
            {
                writer.WritePropertyName("clientSecretStoreUrl");
                writer.WriteStringValue(ClientSecretStoreUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ChannelIntegrityKeyName))
            {
                writer.WritePropertyName("channelIntegrityKeyName");
                writer.WriteStringValue(ChannelIntegrityKeyName);
            }
            if (Optional.IsDefined(ChannelIntegrityKeyVersion))
            {
                writer.WritePropertyName("channelIntegrityKeyVersion");
                writer.WriteStringValue(ChannelIntegrityKeyVersion);
            }
            if (Optional.IsDefined(KeyVaultSyncStatus))
            {
                writer.WritePropertyName("keyVaultSyncStatus");
                writer.WriteStringValue(KeyVaultSyncStatus.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DataBoxEdgeDeviceExtendedInfo DeserializeDataBoxEdgeDeviceExtendedInfo(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> encryptionKeyThumbprint = default;
            Optional<string> encryptionKey = default;
            Optional<string> resourceKey = default;
            Optional<ResourceIdentifier> clientSecretStoreId = default;
            Optional<Uri> clientSecretStoreUrl = default;
            Optional<string> channelIntegrityKeyName = default;
            Optional<string> channelIntegrityKeyVersion = default;
            Optional<KeyVaultSyncStatus> keyVaultSyncStatus = default;
            Optional<IReadOnlyDictionary<string, DataBoxEdgeDeviceSecret>> deviceSecrets = default;
            Optional<ClusterWitnessType> clusterWitnessType = default;
            Optional<string> fileShareWitnessLocation = default;
            Optional<string> fileShareWitnessUsername = default;
            Optional<string> cloudWitnessStorageAccountName = default;
            Optional<string> cloudWitnessContainerName = default;
            Optional<string> cloudWitnessStorageEndpoint = default;
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
                    type = new ResourceType(property.Value.GetString());
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
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("encryptionKeyThumbprint"))
                        {
                            encryptionKeyThumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryptionKey"))
                        {
                            encryptionKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceKey"))
                        {
                            resourceKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientSecretStoreId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clientSecretStoreId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clientSecretStoreUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                clientSecretStoreUrl = null;
                                continue;
                            }
                            clientSecretStoreUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("channelIntegrityKeyName"))
                        {
                            channelIntegrityKeyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("channelIntegrityKeyVersion"))
                        {
                            channelIntegrityKeyVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultSyncStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            keyVaultSyncStatus = new KeyVaultSyncStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deviceSecrets"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, DataBoxEdgeDeviceSecret> dictionary = new Dictionary<string, DataBoxEdgeDeviceSecret>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, DataBoxEdgeDeviceSecret.DeserializeDataBoxEdgeDeviceSecret(property1.Value));
                            }
                            deviceSecrets = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("clusterWitnessType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterWitnessType = new ClusterWitnessType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("fileShareWitnessLocation"))
                        {
                            fileShareWitnessLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fileShareWitnessUsername"))
                        {
                            fileShareWitnessUsername = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloudWitnessStorageAccountName"))
                        {
                            cloudWitnessStorageAccountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloudWitnessContainerName"))
                        {
                            cloudWitnessContainerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cloudWitnessStorageEndpoint"))
                        {
                            cloudWitnessStorageEndpoint = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataBoxEdgeDeviceExtendedInfo(id, name, type, systemData.Value, encryptionKeyThumbprint.Value, encryptionKey.Value, resourceKey.Value, clientSecretStoreId.Value, clientSecretStoreUrl.Value, channelIntegrityKeyName.Value, channelIntegrityKeyVersion.Value, Optional.ToNullable(keyVaultSyncStatus), Optional.ToDictionary(deviceSecrets), Optional.ToNullable(clusterWitnessType), fileShareWitnessLocation.Value, fileShareWitnessUsername.Value, cloudWitnessStorageAccountName.Value, cloudWitnessContainerName.Value, cloudWitnessStorageEndpoint.Value);
        }
    }
}
