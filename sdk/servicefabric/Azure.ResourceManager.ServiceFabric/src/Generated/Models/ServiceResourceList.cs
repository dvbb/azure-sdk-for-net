// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceFabric;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The list of service resources. </summary>
    public partial class ServiceResourceList
    {
        /// <summary> Initializes a new instance of ServiceResourceList. </summary>
        internal ServiceResourceList()
        {
            Value = new ChangeTrackingList<ServiceResourceData>();
        }

        /// <summary> Initializes a new instance of ServiceResourceList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> URL to get the next set of service list results if there are any. </param>
        internal ServiceResourceList(IReadOnlyList<ServiceResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ServiceResourceData> Value { get; }
        /// <summary> URL to get the next set of service list results if there are any. </summary>
        public string NextLink { get; }
    }
}
