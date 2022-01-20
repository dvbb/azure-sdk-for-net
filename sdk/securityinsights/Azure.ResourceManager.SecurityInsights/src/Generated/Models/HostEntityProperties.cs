// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Host entity property bag. </summary>
    internal partial class HostEntityProperties : EntityCommonProperties
    {
        /// <summary> Initializes a new instance of HostEntityProperties. </summary>
        internal HostEntityProperties()
        {
        }

        /// <summary> The azure resource id of the VM. </summary>
        public string AzureID { get; }
        /// <summary> The DNS domain that this host belongs to. Should contain the compete DNS suffix for the domain. </summary>
        public string DnsDomain { get; }
        /// <summary> The hostname without the domain suffix. </summary>
        public string HostName { get; }
        /// <summary> Determines whether this host belongs to a domain. </summary>
        public bool? IsDomainJoined { get; }
        /// <summary> The host name (pre-windows2000). </summary>
        public string NetBiosName { get; }
        /// <summary> The NT domain that this host belongs to. </summary>
        public string NtDomain { get; }
        /// <summary> The OMS agent id, if the host has OMS agent installed. </summary>
        public string OmsAgentID { get; }
        /// <summary> The operating system type. </summary>
        public OSFamily? OsFamily { get; }
        /// <summary> A free text representation of the operating system. This field is meant to hold specific versions the are more fine grained than OSFamily or future values not supported by OSFamily enumeration. </summary>
        public string OsVersion { get; }
    }
}
