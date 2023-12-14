// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Application gateway BackendHealth pool. </summary>
    public partial class ApplicationGatewayBackendHealthPool
    {
        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayBackendHealthPool"/>. </summary>
        internal ApplicationGatewayBackendHealthPool()
        {
            BackendHttpSettingsCollection = new ChangeTrackingList<ApplicationGatewayBackendHealthHttpSettings>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayBackendHealthPool"/>. </summary>
        /// <param name="backendAddressPool"> Reference to an ApplicationGatewayBackendAddressPool resource. </param>
        /// <param name="backendHttpSettingsCollection"> List of ApplicationGatewayBackendHealthHttpSettings resources. </param>
        internal ApplicationGatewayBackendHealthPool(ApplicationGatewayBackendAddressPool backendAddressPool, IReadOnlyList<ApplicationGatewayBackendHealthHttpSettings> backendHttpSettingsCollection)
        {
            BackendAddressPool = backendAddressPool;
            BackendHttpSettingsCollection = backendHttpSettingsCollection;
        }

        /// <summary> Reference to an ApplicationGatewayBackendAddressPool resource. </summary>
        public ApplicationGatewayBackendAddressPool BackendAddressPool { get; }
        /// <summary> List of ApplicationGatewayBackendHealthHttpSettings resources. </summary>
        public IReadOnlyList<ApplicationGatewayBackendHealthHttpSettings> BackendHttpSettingsCollection { get; }
    }
}
