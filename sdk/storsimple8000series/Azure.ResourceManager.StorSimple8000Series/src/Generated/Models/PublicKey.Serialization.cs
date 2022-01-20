// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    public partial class PublicKey
    {
        internal static PublicKey DeserializePublicKey(JsonElement element)
        {
            string key = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"))
                {
                    key = property.Value.GetString();
                    continue;
                }
            }
            return new PublicKey(key);
        }
    }
}
