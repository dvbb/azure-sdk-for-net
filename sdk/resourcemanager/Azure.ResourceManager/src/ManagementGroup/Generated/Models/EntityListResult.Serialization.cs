// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Management.Models
{
    internal partial class EntityListResult
    {
        internal static EntityListResult DeserializeEntityListResult(JsonElement element)
        {
            Optional<IReadOnlyList<EntityInfo>> value = default;
            Optional<int> count = default;
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
                    List<EntityInfo> array = new List<EntityInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EntityInfo.DeserializeEntityInfo(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new EntityListResult(Optional.ToList(value), Optional.ToNullable(count), nextLink.Value);
        }
    }
}
