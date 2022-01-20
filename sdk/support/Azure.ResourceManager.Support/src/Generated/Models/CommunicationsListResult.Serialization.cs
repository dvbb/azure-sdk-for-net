// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Support;

namespace Azure.ResourceManager.Support.Models
{
    internal partial class CommunicationsListResult
    {
        internal static CommunicationsListResult DeserializeCommunicationsListResult(JsonElement element)
        {
            Optional<IReadOnlyList<CommunicationDetailsData>> value = default;
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
                    List<CommunicationDetailsData> array = new List<CommunicationDetailsData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommunicationDetailsData.DeserializeCommunicationDetailsData(item));
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
            return new CommunicationsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
