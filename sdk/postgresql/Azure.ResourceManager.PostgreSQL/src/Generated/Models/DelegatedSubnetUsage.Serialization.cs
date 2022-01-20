// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSQL.Models
{
    public partial class DelegatedSubnetUsage
    {
        internal static DelegatedSubnetUsage DeserializeDelegatedSubnetUsage(JsonElement element)
        {
            Optional<string> subnetName = default;
            Optional<long> usage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetName"))
                {
                    subnetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("usage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    usage = property.Value.GetInt64();
                    continue;
                }
            }
            return new DelegatedSubnetUsage(subnetName.Value, Optional.ToNullable(usage));
        }
    }
}
