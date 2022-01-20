// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AnalysisServices.Models
{
    /// <summary> An array of firewall rules. </summary>
    public partial class IPv4FirewallSettings
    {
        /// <summary> Initializes a new instance of IPv4FirewallSettings. </summary>
        public IPv4FirewallSettings()
        {
            FirewallRules = new ChangeTrackingList<IPv4FirewallRule>();
        }

        /// <summary> Initializes a new instance of IPv4FirewallSettings. </summary>
        /// <param name="firewallRules"> An array of firewall rules. </param>
        /// <param name="enablePowerBIService"> The indicator of enabling PBI service. </param>
        internal IPv4FirewallSettings(IList<IPv4FirewallRule> firewallRules, bool? enablePowerBIService)
        {
            FirewallRules = firewallRules;
            EnablePowerBIService = enablePowerBIService;
        }

        /// <summary> An array of firewall rules. </summary>
        public IList<IPv4FirewallRule> FirewallRules { get; }
        /// <summary> The indicator of enabling PBI service. </summary>
        public bool? EnablePowerBIService { get; set; }
    }
}
