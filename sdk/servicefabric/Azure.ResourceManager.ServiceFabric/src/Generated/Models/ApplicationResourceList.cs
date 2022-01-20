// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceFabric;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The list of application resources. </summary>
    public partial class ApplicationResourceList
    {
        /// <summary> Initializes a new instance of ApplicationResourceList. </summary>
        internal ApplicationResourceList()
        {
            Value = new ChangeTrackingList<ApplicationResourceData>();
        }

        /// <summary> Initializes a new instance of ApplicationResourceList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> URL to get the next set of application list results if there are any. </param>
        internal ApplicationResourceList(IReadOnlyList<ApplicationResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ApplicationResourceData> Value { get; }
        /// <summary> URL to get the next set of application list results if there are any. </summary>
        public string NextLink { get; }
    }
}
