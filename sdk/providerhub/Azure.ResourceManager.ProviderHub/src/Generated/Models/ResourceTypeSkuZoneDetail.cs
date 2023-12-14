// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceTypeSkuZoneDetail. </summary>
    public partial class ResourceTypeSkuZoneDetail
    {
        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuZoneDetail"/>. </summary>
        public ResourceTypeSkuZoneDetail()
        {
            Name = new ChangeTrackingList<string>();
            Capabilities = new ChangeTrackingList<ResourceSkuCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuZoneDetail"/>. </summary>
        /// <param name="name"></param>
        /// <param name="capabilities"></param>
        internal ResourceTypeSkuZoneDetail(IList<string> name, IList<ResourceSkuCapability> capabilities)
        {
            Name = name;
            Capabilities = capabilities;
        }

        /// <summary> Gets the name. </summary>
        public IList<string> Name { get; }
        /// <summary> Gets the capabilities. </summary>
        public IList<ResourceSkuCapability> Capabilities { get; }
    }
}
