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
    public partial class ApplicationTypeVersionResourceList
    {
        internal static ApplicationTypeVersionResourceList DeserializeApplicationTypeVersionResourceList(JsonElement element)
        {
            Optional<IReadOnlyList<ApplicationTypeVersionResourceData>> value = default;
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
                    List<ApplicationTypeVersionResourceData> array = new List<ApplicationTypeVersionResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationTypeVersionResourceData.DeserializeApplicationTypeVersionResourceData(item));
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
            return new ApplicationTypeVersionResourceList(Optional.ToList(value), nextLink.Value);
        }
    }
}
