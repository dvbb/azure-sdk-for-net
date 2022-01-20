// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Migrate;

namespace Azure.ResourceManager.Migrate.Models
{
    internal partial class ImportCollectorList
    {
        internal static ImportCollectorList DeserializeImportCollectorList(JsonElement element)
        {
            Optional<IReadOnlyList<ImportCollectorData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ImportCollectorData> array = new List<ImportCollectorData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImportCollectorData.DeserializeImportCollectorData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ImportCollectorList(Optional.ToList(value));
        }
    }
}
