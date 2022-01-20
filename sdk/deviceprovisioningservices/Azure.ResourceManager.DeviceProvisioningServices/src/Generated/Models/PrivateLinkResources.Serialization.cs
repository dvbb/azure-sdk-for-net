// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DeviceProvisioningServices;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    public partial class PrivateLinkResources
    {
        internal static PrivateLinkResources DeserializePrivateLinkResources(JsonElement element)
        {
            Optional<IReadOnlyList<GroupIdInformationData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<GroupIdInformationData> array = new List<GroupIdInformationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GroupIdInformationData.DeserializeGroupIdInformationData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PrivateLinkResources(Optional.ToList(value));
        }
    }
}
