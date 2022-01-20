// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AgriFood;

namespace Azure.ResourceManager.AgriFood.Models
{
    internal partial class FarmBeatsListResponse
    {
        internal static FarmBeatsListResponse DeserializeFarmBeatsListResponse(JsonElement element)
        {
            Optional<IReadOnlyList<FarmBeatsData>> value = default;
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
                    List<FarmBeatsData> array = new List<FarmBeatsData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FarmBeatsData.DeserializeFarmBeatsData(item));
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
            return new FarmBeatsListResponse(Optional.ToList(value), nextLink.Value);
        }
    }
}
