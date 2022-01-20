// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.StorSimple8000Series;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    internal partial class StorageAccountCredentialList
    {
        internal static StorageAccountCredentialList DeserializeStorageAccountCredentialList(JsonElement element)
        {
            IReadOnlyList<StorageAccountCredentialData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<StorageAccountCredentialData> array = new List<StorageAccountCredentialData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageAccountCredentialData.DeserializeStorageAccountCredentialData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new StorageAccountCredentialList(value);
        }
    }
}
