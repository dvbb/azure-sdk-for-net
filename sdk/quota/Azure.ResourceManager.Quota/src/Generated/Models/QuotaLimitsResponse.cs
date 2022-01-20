// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Quota;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> Quota limits request response. </summary>
    internal partial class QuotaLimitsResponse
    {
        /// <summary> Initializes a new instance of QuotaLimitsResponse. </summary>
        internal QuotaLimitsResponse()
        {
            Value = new ChangeTrackingList<CurrentQuotaLimitBaseData>();
        }

        /// <summary> List of quota limits with the quota request status. </summary>
        public IReadOnlyList<CurrentQuotaLimitBaseData> Value { get; }
        /// <summary> The URI used to fetch the next page of quota limits. When there are no more pages, this is null. </summary>
        public string NextLink { get; }
    }
}
