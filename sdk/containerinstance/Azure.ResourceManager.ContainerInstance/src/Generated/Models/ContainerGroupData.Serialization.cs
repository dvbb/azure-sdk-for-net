// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerInstance.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ContainerInstance
{
    public partial class ContainerGroupData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones");
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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
            writer.WritePropertyName("containers");
            writer.WriteStartArray();
            foreach (var item in Containers)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(ImageRegistryCredentials))
            {
                writer.WritePropertyName("imageRegistryCredentials");
                writer.WriteStartArray();
                foreach (var item in ImageRegistryCredentials)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RestartPolicy))
            {
                writer.WritePropertyName("restartPolicy");
                writer.WriteStringValue(RestartPolicy.Value.ToString());
            }
            if (Optional.IsDefined(IpAddress))
            {
                writer.WritePropertyName("ipAddress");
                writer.WriteObjectValue(IpAddress);
            }
            writer.WritePropertyName("osType");
            writer.WriteStringValue(OsType.ToString());
            if (Optional.IsCollectionDefined(Volumes))
            {
                writer.WritePropertyName("volumes");
                writer.WriteStartArray();
                foreach (var item in Volumes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Diagnostics))
            {
                writer.WritePropertyName("diagnostics");
                writer.WriteObjectValue(Diagnostics);
            }
            if (Optional.IsCollectionDefined(SubnetIds))
            {
                writer.WritePropertyName("subnetIds");
                writer.WriteStartArray();
                foreach (var item in SubnetIds)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DnsConfig))
            {
                writer.WritePropertyName("dnsConfig");
                writer.WriteObjectValue(DnsConfig);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteStringValue(Sku.Value.ToString());
            }
            if (Optional.IsDefined(EncryptionProperties))
            {
                writer.WritePropertyName("encryptionProperties");
                writer.WriteObjectValue(EncryptionProperties);
            }
            if (Optional.IsCollectionDefined(InitContainers))
            {
                writer.WritePropertyName("initContainers");
                writer.WriteStartArray();
                foreach (var item in InitContainers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ContainerGroupData DeserializeContainerGroupData(JsonElement element)
        {
            Optional<ResourceIdentity> identity = default;
            Optional<IList<string>> zones = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> provisioningState = default;
            IList<Container> containers = default;
            Optional<IList<ImageRegistryCredential>> imageRegistryCredentials = default;
            Optional<ContainerGroupRestartPolicy> restartPolicy = default;
            Optional<IpAddress> ipAddress = default;
            OperatingSystemTypes osType = default;
            Optional<IList<Volume>> volumes = default;
            Optional<ContainerGroupPropertiesInstanceView> instanceView = default;
            Optional<ContainerGroupDiagnostics> diagnostics = default;
            Optional<IList<ContainerGroupSubnetId>> subnetIds = default;
            Optional<DnsConfiguration> dnsConfig = default;
            Optional<ContainerGroupSku> sku = default;
            Optional<EncryptionProperties> encryptionProperties = default;
            Optional<IList<InitContainerDefinition>> initContainers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ResourceIdentity>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("zones"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containers"))
                        {
                            List<Container> array = new List<Container>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Container.DeserializeContainer(item));
                            }
                            containers = array;
                            continue;
                        }
                        if (property0.NameEquals("imageRegistryCredentials"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ImageRegistryCredential> array = new List<ImageRegistryCredential>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ImageRegistryCredential.DeserializeImageRegistryCredential(item));
                            }
                            imageRegistryCredentials = array;
                            continue;
                        }
                        if (property0.NameEquals("restartPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            restartPolicy = new ContainerGroupRestartPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ipAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ipAddress = IpAddress.DeserializeIpAddress(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("osType"))
                        {
                            osType = new OperatingSystemTypes(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("volumes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Volume> array = new List<Volume>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Volume.DeserializeVolume(item));
                            }
                            volumes = array;
                            continue;
                        }
                        if (property0.NameEquals("instanceView"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            instanceView = ContainerGroupPropertiesInstanceView.DeserializeContainerGroupPropertiesInstanceView(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("diagnostics"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            diagnostics = ContainerGroupDiagnostics.DeserializeContainerGroupDiagnostics(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("subnetIds"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ContainerGroupSubnetId> array = new List<ContainerGroupSubnetId>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerGroupSubnetId.DeserializeContainerGroupSubnetId(item));
                            }
                            subnetIds = array;
                            continue;
                        }
                        if (property0.NameEquals("dnsConfig"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dnsConfig = DnsConfiguration.DeserializeDnsConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sku"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sku = new ContainerGroupSku(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryptionProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptionProperties = EncryptionProperties.DeserializeEncryptionProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("initContainers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<InitContainerDefinition> array = new List<InitContainerDefinition>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(InitContainerDefinition.DeserializeInitContainerDefinition(item));
                            }
                            initContainers = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ContainerGroupData(id, name, type, tags, location, Optional.ToList(zones), identity, provisioningState.Value, containers, Optional.ToList(imageRegistryCredentials), Optional.ToNullable(restartPolicy), ipAddress.Value, osType, Optional.ToList(volumes), instanceView.Value, diagnostics.Value, Optional.ToList(subnetIds), dnsConfig.Value, Optional.ToNullable(sku), encryptionProperties.Value, Optional.ToList(initContainers));
        }
    }
}
