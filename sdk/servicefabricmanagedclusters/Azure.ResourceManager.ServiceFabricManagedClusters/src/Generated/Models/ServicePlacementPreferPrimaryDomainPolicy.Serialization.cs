// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ServicePlacementPreferPrimaryDomainPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("domainName");
            writer.WriteStringValue(DomainName);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WriteEndObject();
        }

        internal static ServicePlacementPreferPrimaryDomainPolicy DeserializeServicePlacementPreferPrimaryDomainPolicy(JsonElement element)
        {
            string domainName = default;
            ServicePlacementPolicyType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ServicePlacementPolicyType(property.Value.GetString());
                    continue;
                }
            }
            return new ServicePlacementPreferPrimaryDomainPolicy(type, domainName);
        }
    }
}
