// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class GatewayResourceCollection
    {
        internal static GatewayResourceCollection DeserializeGatewayResourceCollection(JsonElement element)
        {
            Optional<IReadOnlyList<GatewayResourceData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<GatewayResourceData> array = new List<GatewayResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GatewayResourceData.DeserializeGatewayResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new GatewayResourceCollection(Optional.ToList(value), nextLink.Value);
        }
    }
}
