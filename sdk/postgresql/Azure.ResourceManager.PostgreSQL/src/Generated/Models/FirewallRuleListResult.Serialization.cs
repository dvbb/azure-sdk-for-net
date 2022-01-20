// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PostgreSQL;

namespace Azure.ResourceManager.PostgreSQL.Models
{
    internal partial class FirewallRuleListResult
    {
        internal static FirewallRuleListResult DeserializeFirewallRuleListResult(JsonElement element)
        {
            Optional<IReadOnlyList<FirewallRuleData>> value = default;
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
                    List<FirewallRuleData> array = new List<FirewallRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FirewallRuleData.DeserializeFirewallRuleData(item));
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
            return new FirewallRuleListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
