// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomProviders.Models
{
    public partial class CustomRPResourceTypeRouteDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RoutingType))
            {
                writer.WritePropertyName("routingType");
                writer.WriteStringValue(RoutingType.Value.ToString());
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("endpoint");
            writer.WriteStringValue(Endpoint);
            writer.WriteEndObject();
        }

        internal static CustomRPResourceTypeRouteDefinition DeserializeCustomRPResourceTypeRouteDefinition(JsonElement element)
        {
            Optional<ResourceTypeRouting> routingType = default;
            string name = default;
            string endpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routingType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    routingType = new ResourceTypeRouting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
            }
            return new CustomRPResourceTypeRouteDefinition(name, endpoint, Optional.ToNullable(routingType));
        }
    }
}
