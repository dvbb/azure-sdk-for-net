// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricMesh.Models
{
    public partial class NetworkRef : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(EndpointRefs))
            {
                writer.WritePropertyName("endpointRefs");
                writer.WriteStartArray();
                foreach (var item in EndpointRefs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static NetworkRef DeserializeNetworkRef(JsonElement element)
        {
            Optional<string> name = default;
            Optional<IList<EndpointRef>> endpointRefs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointRefs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EndpointRef> array = new List<EndpointRef>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EndpointRef.DeserializeEndpointRef(item));
                    }
                    endpointRefs = array;
                    continue;
                }
            }
            return new NetworkRef(name.Value, Optional.ToList(endpointRefs));
        }
    }
}
