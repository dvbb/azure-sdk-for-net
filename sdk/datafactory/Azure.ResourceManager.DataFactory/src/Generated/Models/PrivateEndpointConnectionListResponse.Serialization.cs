// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class PrivateEndpointConnectionListResponse
    {
        internal static PrivateEndpointConnectionListResponse DeserializePrivateEndpointConnectionListResponse(JsonElement element)
        {
            IReadOnlyList<PrivateEndpointConnectionResourceData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<PrivateEndpointConnectionResourceData> array = new List<PrivateEndpointConnectionResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateEndpointConnectionResourceData.DeserializePrivateEndpointConnectionResourceData(item));
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
            return new PrivateEndpointConnectionListResponse(value, nextLink.Value);
        }
    }
}
