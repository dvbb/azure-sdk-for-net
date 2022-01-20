// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ServiceFabric;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterListResult
    {
        internal static ClusterListResult DeserializeClusterListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ClusterData>> value = default;
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
                    List<ClusterData> array = new List<ClusterData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClusterData.DeserializeClusterData(item));
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
            return new ClusterListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
