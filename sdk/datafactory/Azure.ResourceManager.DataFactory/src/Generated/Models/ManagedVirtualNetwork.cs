// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A managed Virtual Network associated with the Azure Data Factory. </summary>
    public partial class ManagedVirtualNetwork
    {
        /// <summary> Initializes a new instance of ManagedVirtualNetwork. </summary>
        public ManagedVirtualNetwork()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of ManagedVirtualNetwork. </summary>
        /// <param name="vNetId"> Managed Virtual Network ID. </param>
        /// <param name="alias"> Managed Virtual Network alias. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ManagedVirtualNetwork(string vNetId, string @alias, IDictionary<string, object> additionalProperties)
        {
            VNetId = vNetId;
            Alias = @alias;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Managed Virtual Network ID. </summary>
        public string VNetId { get; }
        /// <summary> Managed Virtual Network alias. </summary>
        public string Alias { get; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
