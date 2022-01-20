// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class SearchSort
    {
        internal static SearchSort DeserializeSearchSort(JsonElement element)
        {
            Optional<string> name = default;
            Optional<SearchSortEnum> order = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("order"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    order = new SearchSortEnum(property.Value.GetString());
                    continue;
                }
            }
            return new SearchSort(name.Value, Optional.ToNullable(order));
        }
    }
}
