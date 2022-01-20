// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class InsightQueryItemPropertiesReferenceTimeRange
    {
        internal static InsightQueryItemPropertiesReferenceTimeRange DeserializeInsightQueryItemPropertiesReferenceTimeRange(JsonElement element)
        {
            Optional<string> beforeRange = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("beforeRange"))
                {
                    beforeRange = property.Value.GetString();
                    continue;
                }
            }
            return new InsightQueryItemPropertiesReferenceTimeRange(beforeRange.Value);
        }
    }
}
