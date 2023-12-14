// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The Data Box Edge/Gateway device patch. </summary>
    public partial class DataBoxEdgeDevicePatch
    {
        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeDevicePatch"/>. </summary>
        public DataBoxEdgeDevicePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeDevicePatch"/>. </summary>
        /// <param name="tags"> The tags attached to the Data Box Edge/Gateway resource. </param>
        /// <param name="identity"> Msi identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="edgeProfile"> Edge Profile property of the Data Box Edge/Gateway device. </param>
        internal DataBoxEdgeDevicePatch(IDictionary<string, string> tags, ManagedServiceIdentity identity, EdgeProfilePatch edgeProfile)
        {
            Tags = tags;
            Identity = identity;
            EdgeProfile = edgeProfile;
        }

        /// <summary> The tags attached to the Data Box Edge/Gateway resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Msi identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Edge Profile property of the Data Box Edge/Gateway device. </summary>
        internal EdgeProfilePatch EdgeProfile { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubscriptionId
        {
            get => EdgeProfile is null ? default : EdgeProfile.SubscriptionId;
            set
            {
                if (EdgeProfile is null)
                    EdgeProfile = new EdgeProfilePatch();
                EdgeProfile.SubscriptionId = value;
            }
        }
    }
}
