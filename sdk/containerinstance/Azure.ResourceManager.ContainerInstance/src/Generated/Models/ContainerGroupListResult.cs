// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerInstance;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The container group list response that contains the container group properties. </summary>
    internal partial class ContainerGroupListResult
    {
        /// <summary> Initializes a new instance of <see cref="ContainerGroupListResult"/>. </summary>
        internal ContainerGroupListResult()
        {
            Value = new ChangeTrackingList<ContainerGroupData>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerGroupListResult"/>. </summary>
        /// <param name="value"> The list of container groups. </param>
        /// <param name="nextLink"> The URI to fetch the next page of container groups. </param>
        internal ContainerGroupListResult(IReadOnlyList<ContainerGroupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of container groups. </summary>
        public IReadOnlyList<ContainerGroupData> Value { get; }
        /// <summary> The URI to fetch the next page of container groups. </summary>
        public string NextLink { get; }
    }
}
