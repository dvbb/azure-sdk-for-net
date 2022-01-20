// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    internal partial class ExtensionTypeList
    {
        internal static ExtensionTypeList DeserializeExtensionTypeList(JsonElement element)
        {
            Optional<IReadOnlyList<ExtensionType>> value = default;
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
                    List<ExtensionType> array = new List<ExtensionType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExtensionType.DeserializeExtensionType(item));
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
            return new ExtensionTypeList(Optional.ToList(value), nextLink.Value);
        }
    }
}
