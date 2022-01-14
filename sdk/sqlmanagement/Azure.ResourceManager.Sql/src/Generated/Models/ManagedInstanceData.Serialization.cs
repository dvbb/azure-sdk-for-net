// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedInstanceData : IUtf8JsonSerializable
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
            if (Optional.IsDefined(ManagedInstanceCreateMode))
            {
                writer.WritePropertyName("managedInstanceCreateMode");
                writer.WriteStringValue(ManagedInstanceCreateMode.Value.ToString());
            }
            if (Optional.IsDefined(AdministratorLogin))
            {
                writer.WritePropertyName("administratorLogin");
                writer.WriteStringValue(AdministratorLogin);
            }
            if (Optional.IsDefined(AdministratorLoginPassword))
            {
                writer.WritePropertyName("administratorLoginPassword");
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId");
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType");
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(VCores))
            {
                writer.WritePropertyName("vCores");
                writer.WriteNumberValue(VCores.Value);
            }
            if (Optional.IsDefined(StorageSizeInGB))
            {
                writer.WritePropertyName("storageSizeInGB");
                writer.WriteNumberValue(StorageSizeInGB.Value);
            }
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation");
                writer.WriteStringValue(Collation);
            }
            if (Optional.IsDefined(DnsZonePartner))
            {
                writer.WritePropertyName("dnsZonePartner");
                writer.WriteStringValue(DnsZonePartner);
            }
            if (Optional.IsDefined(PublicDataEndpointEnabled))
            {
                writer.WritePropertyName("publicDataEndpointEnabled");
                writer.WriteBooleanValue(PublicDataEndpointEnabled.Value);
            }
            if (Optional.IsDefined(SourceManagedInstanceId))
            {
                writer.WritePropertyName("sourceManagedInstanceId");
                writer.WriteStringValue(SourceManagedInstanceId);
            }
            if (Optional.IsDefined(RestorePointInTime))
            {
                writer.WritePropertyName("restorePointInTime");
                writer.WriteStringValue(RestorePointInTime.Value, "O");
            }
            if (Optional.IsDefined(ProxyOverride))
            {
                writer.WritePropertyName("proxyOverride");
                writer.WriteStringValue(ProxyOverride.Value.ToString());
            }
            if (Optional.IsDefined(TimezoneId))
            {
                writer.WritePropertyName("timezoneId");
                writer.WriteStringValue(TimezoneId);
            }
            if (Optional.IsDefined(InstancePoolId))
            {
                writer.WritePropertyName("instancePoolId");
                writer.WriteStringValue(InstancePoolId);
            }
            if (Optional.IsDefined(MaintenanceConfigurationId))
            {
                writer.WritePropertyName("maintenanceConfigurationId");
                writer.WriteStringValue(MaintenanceConfigurationId);
            }
            if (Optional.IsDefined(MinimalTlsVersion))
            {
                writer.WritePropertyName("minimalTlsVersion");
                writer.WriteStringValue(MinimalTlsVersion);
            }
            if (Optional.IsDefined(StorageAccountType))
            {
                writer.WritePropertyName("storageAccountType");
                writer.WriteStringValue(StorageAccountType.Value.ToString());
            }
            if (Optional.IsDefined(ZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant");
                writer.WriteBooleanValue(ZoneRedundant.Value);
            }
            if (Optional.IsDefined(PrimaryUserAssignedIdentityId))
            {
                writer.WritePropertyName("primaryUserAssignedIdentityId");
                writer.WriteStringValue(PrimaryUserAssignedIdentityId);
            }
            if (Optional.IsDefined(KeyId))
            {
                writer.WritePropertyName("keyId");
                writer.WriteStringValue(KeyId);
            }
            if (Optional.IsDefined(Administrators))
            {
                writer.WritePropertyName("administrators");
                writer.WriteObjectValue(Administrators);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ManagedInstanceData DeserializeManagedInstanceData(JsonElement element)
        {
            Optional<ResourceIdentity> identity = default;
            Optional<Sku> sku = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<ManagedInstancePropertiesProvisioningState> provisioningState = default;
            Optional<ManagedServerCreateMode> managedInstanceCreateMode = default;
            Optional<string> fullyQualifiedDomainName = default;
            Optional<string> administratorLogin = default;
            Optional<string> administratorLoginPassword = default;
            Optional<string> subnetId = default;
            Optional<string> state = default;
            Optional<ManagedInstanceLicenseType> licenseType = default;
            Optional<int> vCores = default;
            Optional<int> storageSizeInGB = default;
            Optional<string> collation = default;
            Optional<string> dnsZone = default;
            Optional<string> dnsZonePartner = default;
            Optional<bool> publicDataEndpointEnabled = default;
            Optional<string> sourceManagedInstanceId = default;
            Optional<DateTimeOffset> restorePointInTime = default;
            Optional<ManagedInstanceProxyOverride> proxyOverride = default;
            Optional<string> timezoneId = default;
            Optional<string> instancePoolId = default;
            Optional<string> maintenanceConfigurationId = default;
            Optional<IReadOnlyList<ManagedInstancePecProperty>> privateEndpointConnections = default;
            Optional<string> minimalTlsVersion = default;
            Optional<StorageAccountType> storageAccountType = default;
            Optional<bool> zoneRedundant = default;
            Optional<string> primaryUserAssignedIdentityId = default;
            Optional<string> keyId = default;
            Optional<ManagedInstanceExternalAdministrator> administrators = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = ResourceIdentity.DeserializeResourceIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = Sku.DeserializeSku(property.Value);
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
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ManagedInstancePropertiesProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("managedInstanceCreateMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            managedInstanceCreateMode = new ManagedServerCreateMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("fullyQualifiedDomainName"))
                        {
                            fullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("administratorLogin"))
                        {
                            administratorLogin = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("administratorLoginPassword"))
                        {
                            administratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subnetId"))
                        {
                            subnetId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("licenseType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            licenseType = new ManagedInstanceLicenseType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vCores"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vCores = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("storageSizeInGB"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            storageSizeInGB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("collation"))
                        {
                            collation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dnsZone"))
                        {
                            dnsZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dnsZonePartner"))
                        {
                            dnsZonePartner = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicDataEndpointEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicDataEndpointEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("sourceManagedInstanceId"))
                        {
                            sourceManagedInstanceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("restorePointInTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            restorePointInTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("proxyOverride"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            proxyOverride = new ManagedInstanceProxyOverride(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("timezoneId"))
                        {
                            timezoneId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("instancePoolId"))
                        {
                            instancePoolId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maintenanceConfigurationId"))
                        {
                            maintenanceConfigurationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ManagedInstancePecProperty> array = new List<ManagedInstancePecProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedInstancePecProperty.DeserializeManagedInstancePecProperty(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("minimalTlsVersion"))
                        {
                            minimalTlsVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            storageAccountType = new StorageAccountType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("primaryUserAssignedIdentityId"))
                        {
                            primaryUserAssignedIdentityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyId"))
                        {
                            keyId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("administrators"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            administrators = ManagedInstanceExternalAdministrator.DeserializeManagedInstanceExternalAdministrator(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagedInstanceData(id, name, type, tags, location, identity.Value, sku.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(managedInstanceCreateMode), fullyQualifiedDomainName.Value, administratorLogin.Value, administratorLoginPassword.Value, subnetId.Value, state.Value, Optional.ToNullable(licenseType), Optional.ToNullable(vCores), Optional.ToNullable(storageSizeInGB), collation.Value, dnsZone.Value, dnsZonePartner.Value, Optional.ToNullable(publicDataEndpointEnabled), sourceManagedInstanceId.Value, Optional.ToNullable(restorePointInTime), Optional.ToNullable(proxyOverride), timezoneId.Value, instancePoolId.Value, maintenanceConfigurationId.Value, Optional.ToList(privateEndpointConnections), minimalTlsVersion.Value, Optional.ToNullable(storageAccountType), Optional.ToNullable(zoneRedundant), primaryUserAssignedIdentityId.Value, keyId.Value, administrators.Value);
        }
    }
}
