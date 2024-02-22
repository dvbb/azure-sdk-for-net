// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabVmData : IUtf8JsonSerializable, IJsonModel<DevTestLabVmData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabVmData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabVmData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabVmData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes"u8);
                writer.WriteStringValue(Notes);
            }
            if (Optional.IsDefined(OwnerObjectId))
            {
                writer.WritePropertyName("ownerObjectId"u8);
                writer.WriteStringValue(OwnerObjectId);
            }
            if (Optional.IsDefined(OwnerUserPrincipalName))
            {
                writer.WritePropertyName("ownerUserPrincipalName"u8);
                writer.WriteStringValue(OwnerUserPrincipalName);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedByUserId))
            {
                writer.WritePropertyName("createdByUserId"u8);
                writer.WriteStringValue(CreatedByUserId);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedByUser))
            {
                writer.WritePropertyName("createdByUser"u8);
                writer.WriteStringValue(CreatedByUser);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ComputeId))
            {
                writer.WritePropertyName("computeId"u8);
                writer.WriteStringValue(ComputeId);
            }
            if (Optional.IsDefined(CustomImageId))
            {
                writer.WritePropertyName("customImageId"u8);
                writer.WriteStringValue(CustomImageId);
            }
            if (options.Format != "W" && Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size);
            }
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(SshKey))
            {
                writer.WritePropertyName("sshKey"u8);
                writer.WriteStringValue(SshKey);
            }
            if (Optional.IsDefined(IsAuthenticationWithSshKey))
            {
                writer.WritePropertyName("isAuthenticationWithSshKey"u8);
                writer.WriteBooleanValue(IsAuthenticationWithSshKey.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Fqdn))
            {
                writer.WritePropertyName("fqdn"u8);
                writer.WriteStringValue(Fqdn);
            }
            if (Optional.IsDefined(LabSubnetName))
            {
                writer.WritePropertyName("labSubnetName"u8);
                writer.WriteStringValue(LabSubnetName);
            }
            if (Optional.IsDefined(LabVirtualNetworkId))
            {
                writer.WritePropertyName("labVirtualNetworkId"u8);
                writer.WriteStringValue(LabVirtualNetworkId);
            }
            if (Optional.IsDefined(DisallowPublicIPAddress))
            {
                writer.WritePropertyName("disallowPublicIpAddress"u8);
                writer.WriteBooleanValue(DisallowPublicIPAddress.Value);
            }
            if (Optional.IsCollectionDefined(Artifacts))
            {
                writer.WritePropertyName("artifacts"u8);
                writer.WriteStartArray();
                foreach (var item in Artifacts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ArtifactDeploymentStatus))
            {
                writer.WritePropertyName("artifactDeploymentStatus"u8);
                writer.WriteObjectValue(ArtifactDeploymentStatus);
            }
            if (Optional.IsDefined(GalleryImageReference))
            {
                writer.WritePropertyName("galleryImageReference"u8);
                writer.WriteObjectValue(GalleryImageReference);
            }
            if (Optional.IsDefined(PlanId))
            {
                writer.WritePropertyName("planId"u8);
                writer.WriteStringValue(PlanId);
            }
            if (options.Format != "W" && Optional.IsDefined(ComputeVm))
            {
                writer.WritePropertyName("computeVm"u8);
                writer.WriteObjectValue(ComputeVm);
            }
            if (Optional.IsDefined(NetworkInterface))
            {
                writer.WritePropertyName("networkInterface"u8);
                writer.WriteObjectValue(NetworkInterface);
            }
            if (options.Format != "W" && Optional.IsDefined(ApplicableSchedule))
            {
                writer.WritePropertyName("applicableSchedule"u8);
                writer.WriteObjectValue(ApplicableSchedule);
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(AllowClaim))
            {
                writer.WritePropertyName("allowClaim"u8);
                writer.WriteBooleanValue(AllowClaim.Value);
            }
            if (Optional.IsDefined(StorageType))
            {
                writer.WritePropertyName("storageType"u8);
                writer.WriteStringValue(StorageType);
            }
            if (options.Format != "W" && Optional.IsDefined(VmCreationSource))
            {
                writer.WritePropertyName("virtualMachineCreationSource"u8);
                writer.WriteStringValue(VmCreationSource.Value.ToString());
            }
            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId"u8);
                writer.WriteStringValue(EnvironmentId);
            }
            if (Optional.IsCollectionDefined(DataDiskParameters))
            {
                writer.WritePropertyName("dataDiskParameters"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskParameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ScheduleParameters))
            {
                writer.WritePropertyName("scheduleParameters"u8);
                writer.WriteStartArray();
                foreach (var item in ScheduleParameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(LastKnownPowerState))
            {
                writer.WritePropertyName("lastKnownPowerState"u8);
                writer.WriteStringValue(LastKnownPowerState);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(UniqueIdentifier))
            {
                writer.WritePropertyName("uniqueIdentifier"u8);
                writer.WriteStringValue(UniqueIdentifier.Value);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DevTestLabVmData IJsonModel<DevTestLabVmData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabVmData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabVmData(document.RootElement, options);
        }

        internal static DevTestLabVmData DeserializeDevTestLabVmData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> notes = default;
            Optional<string> ownerObjectId = default;
            Optional<string> ownerUserPrincipalName = default;
            Optional<string> createdByUserId = default;
            Optional<string> createdByUser = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<ResourceIdentifier> computeId = default;
            Optional<string> customImageId = default;
            Optional<string> osType = default;
            Optional<string> size = default;
            Optional<string> userName = default;
            Optional<string> password = default;
            Optional<string> sshKey = default;
            Optional<bool> isAuthenticationWithSshKey = default;
            Optional<string> fqdn = default;
            Optional<string> labSubnetName = default;
            Optional<ResourceIdentifier> labVirtualNetworkId = default;
            Optional<bool> disallowPublicIPAddress = default;
            Optional<IList<DevTestLabArtifactInstallInfo>> artifacts = default;
            Optional<DevTestLabArtifactDeploymentStatus> artifactDeploymentStatus = default;
            Optional<DevTestLabGalleryImageReference> galleryImageReference = default;
            Optional<string> planId = default;
            Optional<ComputeVmProperties> computeVm = default;
            Optional<DevTestLabNetworkInterface> networkInterface = default;
            Optional<DevTestLabApplicableSchedule> applicableSchedule = default;
            Optional<DateTimeOffset> expirationDate = default;
            Optional<bool> allowClaim = default;
            Optional<string> storageType = default;
            Optional<DevTestLabVmCreationSource> vmCreationSource = default;
            Optional<ResourceIdentifier> environmentId = default;
            Optional<IList<DevTestLabDataDiskProperties>> dataDiskParameters = default;
            Optional<IList<DevTestLabScheduleCreationParameter>> scheduleParameters = default;
            Optional<string> lastKnownPowerState = default;
            Optional<string> provisioningState = default;
            Optional<Guid> uniqueIdentifier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("notes"u8))
                        {
                            notes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ownerObjectId"u8))
                        {
                            ownerObjectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ownerUserPrincipalName"u8))
                        {
                            ownerUserPrincipalName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdByUserId"u8))
                        {
                            createdByUserId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdByUser"u8))
                        {
                            createdByUser = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("computeId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customImageId"u8))
                        {
                            customImageId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            osType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("size"u8))
                        {
                            size = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userName"u8))
                        {
                            userName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            password = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sshKey"u8))
                        {
                            sshKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isAuthenticationWithSshKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isAuthenticationWithSshKey = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("fqdn"u8))
                        {
                            fqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("labSubnetName"u8))
                        {
                            labSubnetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("labVirtualNetworkId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            labVirtualNetworkId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("disallowPublicIpAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disallowPublicIPAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("artifacts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabArtifactInstallInfo> array = new List<DevTestLabArtifactInstallInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabArtifactInstallInfo.DeserializeDevTestLabArtifactInstallInfo(item, options));
                            }
                            artifacts = array;
                            continue;
                        }
                        if (property0.NameEquals("artifactDeploymentStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            artifactDeploymentStatus = DevTestLabArtifactDeploymentStatus.DeserializeDevTestLabArtifactDeploymentStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("galleryImageReference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            galleryImageReference = DevTestLabGalleryImageReference.DeserializeDevTestLabGalleryImageReference(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("planId"u8))
                        {
                            planId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("computeVm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeVm = ComputeVmProperties.DeserializeComputeVmProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkInterface"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkInterface = DevTestLabNetworkInterface.DeserializeDevTestLabNetworkInterface(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("applicableSchedule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            applicableSchedule = DevTestLabApplicableSchedule.DeserializeDevTestLabApplicableSchedule(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("expirationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("allowClaim"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowClaim = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("storageType"u8))
                        {
                            storageType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineCreationSource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vmCreationSource = new DevTestLabVmCreationSource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("environmentId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            environmentId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataDiskParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabDataDiskProperties> array = new List<DevTestLabDataDiskProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabDataDiskProperties.DeserializeDevTestLabDataDiskProperties(item, options));
                            }
                            dataDiskParameters = array;
                            continue;
                        }
                        if (property0.NameEquals("scheduleParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabScheduleCreationParameter> array = new List<DevTestLabScheduleCreationParameter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabScheduleCreationParameter.DeserializeDevTestLabScheduleCreationParameter(item, options));
                            }
                            scheduleParameters = array;
                            continue;
                        }
                        if (property0.NameEquals("lastKnownPowerState"u8))
                        {
                            lastKnownPowerState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueIdentifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uniqueIdentifier = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabVmData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, notes.Value, ownerObjectId.Value, ownerUserPrincipalName.Value, createdByUserId.Value, createdByUser.Value, Optional.ToNullable(createdDate), computeId.Value, customImageId.Value, osType.Value, size.Value, userName.Value, password.Value, sshKey.Value, Optional.ToNullable(isAuthenticationWithSshKey), fqdn.Value, labSubnetName.Value, labVirtualNetworkId.Value, Optional.ToNullable(disallowPublicIPAddress), Optional.ToList(artifacts), artifactDeploymentStatus.Value, galleryImageReference.Value, planId.Value, computeVm.Value, networkInterface.Value, applicableSchedule.Value, Optional.ToNullable(expirationDate), Optional.ToNullable(allowClaim), storageType.Value, Optional.ToNullable(vmCreationSource), environmentId.Value, Optional.ToList(dataDiskParameters), Optional.ToList(scheduleParameters), lastKnownPowerState.Value, provisioningState.Value, Optional.ToNullable(uniqueIdentifier), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabVmData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabVmData)} does not support '{options.Format}' format.");
            }
        }

        DevTestLabVmData IPersistableModel<DevTestLabVmData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabVmData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabVmData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabVmData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
