// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logz;

namespace Azure.ResourceManager.Logz.Models
{
    /// <summary> Response of a list operation. </summary>
    internal partial class MonitoringTagRulesListResponse
    {
        /// <summary> Initializes a new instance of MonitoringTagRulesListResponse. </summary>
        internal MonitoringTagRulesListResponse()
        {
            Value = new ChangeTrackingList<MonitoringTagRulesData>();
        }

        /// <summary> Initializes a new instance of MonitoringTagRulesListResponse. </summary>
        /// <param name="value"> Results of a list operation. </param>
        /// <param name="nextLink"> Link to the next set of results, if any. </param>
        internal MonitoringTagRulesListResponse(IReadOnlyList<MonitoringTagRulesData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Results of a list operation. </summary>
        public IReadOnlyList<MonitoringTagRulesData> Value { get; }
        /// <summary> Link to the next set of results, if any. </summary>
        public string NextLink { get; }
    }
}
