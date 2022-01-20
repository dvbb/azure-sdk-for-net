// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IpFilterRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("filterName");
            writer.WriteStringValue(FilterName);
            writer.WritePropertyName("action");
            writer.WriteStringValue(Action.ToSerialString());
            writer.WritePropertyName("ipMask");
            writer.WriteStringValue(IpMask);
            writer.WriteEndObject();
        }

        internal static IpFilterRule DeserializeIpFilterRule(JsonElement element)
        {
            string filterName = default;
            IpFilterActionType action = default;
            string ipMask = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filterName"))
                {
                    filterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"))
                {
                    action = property.Value.GetString().ToIpFilterActionType();
                    continue;
                }
                if (property.NameEquals("ipMask"))
                {
                    ipMask = property.Value.GetString();
                    continue;
                }
            }
            return new IpFilterRule(filterName, action, ipMask);
        }
    }
}
