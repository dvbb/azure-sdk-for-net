// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> IP address for the container group. </summary>
    public partial class IpAddress
    {
        /// <summary> Initializes a new instance of IpAddress. </summary>
        /// <param name="ports"> The list of ports exposed on the container group. </param>
        /// <param name="type"> Specifies if the IP is exposed to the public internet or private VNET. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ports"/> is null. </exception>
        public IpAddress(IEnumerable<Port> ports, ContainerGroupIpAddressType type)
        {
            if (ports == null)
            {
                throw new ArgumentNullException(nameof(ports));
            }

            Ports = ports.ToList();
            Type = type;
        }

        /// <summary> Initializes a new instance of IpAddress. </summary>
        /// <param name="ports"> The list of ports exposed on the container group. </param>
        /// <param name="type"> Specifies if the IP is exposed to the public internet or private VNET. </param>
        /// <param name="ip"> The IP exposed to the public internet. </param>
        /// <param name="dnsNameLabel"> The Dns name label for the IP. </param>
        /// <param name="fqdn"> The FQDN for the IP. </param>
        internal IpAddress(IList<Port> ports, ContainerGroupIpAddressType type, string ip, string dnsNameLabel, string fqdn)
        {
            Ports = ports;
            Type = type;
            Ip = ip;
            DnsNameLabel = dnsNameLabel;
            Fqdn = fqdn;
        }

        /// <summary> The list of ports exposed on the container group. </summary>
        public IList<Port> Ports { get; }
        /// <summary> Specifies if the IP is exposed to the public internet or private VNET. </summary>
        public ContainerGroupIpAddressType Type { get; set; }
        /// <summary> The IP exposed to the public internet. </summary>
        public string Ip { get; set; }
        /// <summary> The Dns name label for the IP. </summary>
        public string DnsNameLabel { get; set; }
        /// <summary> The FQDN for the IP. </summary>
        public string Fqdn { get; }
    }
}
