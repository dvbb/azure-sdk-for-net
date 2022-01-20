// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AgriFood.Models
{
    public partial class DetailedInformation
    {
        internal static DetailedInformation DeserializeDetailedInformation(JsonElement element)
        {
            Optional<string> apiName = default;
            Optional<IReadOnlyList<string>> customParameters = default;
            Optional<IReadOnlyList<string>> platformParameters = default;
            Optional<UnitSystemsInfo> unitsSupported = default;
            Optional<IReadOnlyList<string>> apiInputParameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiName"))
                {
                    apiName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customParameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    customParameters = array;
                    continue;
                }
                if (property.NameEquals("platformParameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    platformParameters = array;
                    continue;
                }
                if (property.NameEquals("unitsSupported"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unitsSupported = UnitSystemsInfo.DeserializeUnitSystemsInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("apiInputParameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    apiInputParameters = array;
                    continue;
                }
            }
            return new DetailedInformation(apiName.Value, Optional.ToList(customParameters), Optional.ToList(platformParameters), unitsSupported.Value, Optional.ToList(apiInputParameters));
        }
    }
}
