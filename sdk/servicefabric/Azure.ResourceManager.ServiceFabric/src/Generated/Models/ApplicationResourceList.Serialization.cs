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
    public partial class ApplicationResourceList
    {
        internal static ApplicationResourceList DeserializeApplicationResourceList(JsonElement element)
        {
            Optional<IReadOnlyList<ApplicationResourceData>> value = default;
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
                    List<ApplicationResourceData> array = new List<ApplicationResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationResourceData.DeserializeApplicationResourceData(item));
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
            return new ApplicationResourceList(Optional.ToList(value), nextLink.Value);
        }
    }
}
