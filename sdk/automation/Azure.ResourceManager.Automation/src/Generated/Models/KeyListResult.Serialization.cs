// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class KeyListResult
    {
        internal static KeyListResult DeserializeKeyListResult(JsonElement element)
        {
            Optional<IReadOnlyList<Key>> keys = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Key> array = new List<Key>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Key.DeserializeKey(item));
                    }
                    keys = array;
                    continue;
                }
            }
            return new KeyListResult(Optional.ToList(keys));
        }
    }
}
