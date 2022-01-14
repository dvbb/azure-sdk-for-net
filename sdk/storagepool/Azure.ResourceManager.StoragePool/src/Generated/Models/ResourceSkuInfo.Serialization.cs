// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    public partial class ResourceSkuInfo
    {
        internal static ResourceSkuInfo DeserializeResourceSkuInfo(JsonElement element)
        {
            Optional<string> apiVersion = default;
            Optional<string> resourceType = default;
            Optional<IReadOnlyList<ResourceSkuCapability>> capabilities = default;
            Optional<ResourceSkuLocationInfo> locationInfo = default;
            Optional<string> name = default;
            Optional<string> tier = default;
            Optional<IReadOnlyList<ResourceSkuRestrictions>> restrictions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiVersion"))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capabilities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceSkuCapability> array = new List<ResourceSkuCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceSkuCapability.DeserializeResourceSkuCapability(item));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("locationInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    locationInfo = ResourceSkuLocationInfo.DeserializeResourceSkuLocationInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restrictions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceSkuRestrictions> array = new List<ResourceSkuRestrictions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceSkuRestrictions.DeserializeResourceSkuRestrictions(item));
                    }
                    restrictions = array;
                    continue;
                }
            }
            return new ResourceSkuInfo(apiVersion.Value, resourceType.Value, Optional.ToList(capabilities), locationInfo.Value, name.Value, tier.Value, Optional.ToList(restrictions));
        }
    }
}
