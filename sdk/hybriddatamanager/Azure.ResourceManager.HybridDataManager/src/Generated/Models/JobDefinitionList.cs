// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridDataManager;

namespace Azure.ResourceManager.HybridDataManager.Models
{
    /// <summary> Job Definition Collection. </summary>
    internal partial class JobDefinitionList
    {
        /// <summary> Initializes a new instance of JobDefinitionList. </summary>
        internal JobDefinitionList()
        {
            Value = new ChangeTrackingList<JobDefinitionData>();
        }

        /// <summary> Initializes a new instance of JobDefinitionList. </summary>
        /// <param name="value"> List of job definitions. </param>
        /// <param name="nextLink"> Link for the next set of job definitions. </param>
        internal JobDefinitionList(IReadOnlyList<JobDefinitionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of job definitions. </summary>
        public IReadOnlyList<JobDefinitionData> Value { get; }
        /// <summary> Link for the next set of job definitions. </summary>
        public string NextLink { get; }
    }
}
