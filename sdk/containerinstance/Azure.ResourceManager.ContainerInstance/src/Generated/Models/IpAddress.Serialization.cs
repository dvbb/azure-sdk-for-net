// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class IpAddress : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ports");
            writer.WriteStartArray();
            foreach (var item in Ports)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            if (Optional.IsDefined(Ip))
            {
                writer.WritePropertyName("ip");
                writer.WriteStringValue(Ip);
            }
            if (Optional.IsDefined(DnsNameLabel))
            {
                writer.WritePropertyName("dnsNameLabel");
                writer.WriteStringValue(DnsNameLabel);
            }
            writer.WriteEndObject();
        }

        internal static IpAddress DeserializeIpAddress(JsonElement element)
        {
            IList<Port> ports = default;
            ContainerGroupIpAddressType type = default;
            Optional<string> ip = default;
            Optional<string> dnsNameLabel = default;
            Optional<string> fqdn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ports"))
                {
                    List<Port> array = new List<Port>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Port.DeserializePort(item));
                    }
                    ports = array;
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ContainerGroupIpAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ip"))
                {
                    ip = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsNameLabel"))
                {
                    dnsNameLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fqdn"))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
            }
            return new IpAddress(ports, type, ip.Value, dnsNameLabel.Value, fqdn.Value);
        }
    }
}
