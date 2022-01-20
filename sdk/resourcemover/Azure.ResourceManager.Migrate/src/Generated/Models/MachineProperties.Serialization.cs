// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class MachineProperties
    {
        internal static MachineProperties DeserializeMachineProperties(JsonElement element)
        {
            Optional<MachineBootType> bootType = default;
            Optional<string> datacenterManagementServerArmId = default;
            Optional<string> discoveryMachineArmId = default;
            Optional<string> datacenterManagementServerName = default;
            Optional<string> displayName = default;
            Optional<float> megabytesOfMemory = default;
            Optional<int> numberOfCores = default;
            Optional<string> operatingSystemType = default;
            Optional<string> operatingSystemName = default;
            Optional<string> operatingSystemVersion = default;
            Optional<string> description = default;
            Optional<IReadOnlyList<string>> groups = default;
            Optional<DateTimeOffset> createdTimestamp = default;
            Optional<DateTimeOffset> updatedTimestamp = default;
            Optional<IReadOnlyDictionary<string, Disk>> disks = default;
            Optional<IReadOnlyDictionary<string, NetworkAdapter>> networkAdapters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bootType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bootType = new MachineBootType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("datacenterManagementServerArmId"))
                {
                    datacenterManagementServerArmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("discoveryMachineArmId"))
                {
                    discoveryMachineArmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datacenterManagementServerName"))
                {
                    datacenterManagementServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("megabytesOfMemory"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    megabytesOfMemory = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("numberOfCores"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    numberOfCores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("operatingSystemType"))
                {
                    operatingSystemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operatingSystemName"))
                {
                    operatingSystemName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operatingSystemVersion"))
                {
                    operatingSystemVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groups"))
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
                    groups = array;
                    continue;
                }
                if (property.NameEquals("createdTimestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedTimestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    updatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("disks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, Disk> dictionary = new Dictionary<string, Disk>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, Disk.DeserializeDisk(property0.Value));
                    }
                    disks = dictionary;
                    continue;
                }
                if (property.NameEquals("networkAdapters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, NetworkAdapter> dictionary = new Dictionary<string, NetworkAdapter>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, NetworkAdapter.DeserializeNetworkAdapter(property0.Value));
                    }
                    networkAdapters = dictionary;
                    continue;
                }
            }
            return new MachineProperties(Optional.ToNullable(bootType), datacenterManagementServerArmId.Value, discoveryMachineArmId.Value, datacenterManagementServerName.Value, displayName.Value, Optional.ToNullable(megabytesOfMemory), Optional.ToNullable(numberOfCores), operatingSystemType.Value, operatingSystemName.Value, operatingSystemVersion.Value, description.Value, Optional.ToList(groups), Optional.ToNullable(createdTimestamp), Optional.ToNullable(updatedTimestamp), Optional.ToDictionary(disks), Optional.ToDictionary(networkAdapters));
        }
    }
}
