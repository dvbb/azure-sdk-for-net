// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class AvailableOperations
    {
        internal static AvailableOperations DeserializeAvailableOperations(JsonElement element)
        {
            Optional<IReadOnlyList<ResourceOperation>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResourceOperation> array = new List<ResourceOperation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceOperation.DeserializeResourceOperation(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AvailableOperations(Optional.ToList(value));
        }
    }
}
