// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Query parameters for listing runs. </summary>
    public partial class RunFilterParameters
    {
        /// <summary> Initializes a new instance of RunFilterParameters. </summary>
        /// <param name="lastUpdatedAfter"> The time at or after which the run event was updated in &apos;ISO 8601&apos; format. </param>
        /// <param name="lastUpdatedBefore"> The time at or before which the run event was updated in &apos;ISO 8601&apos; format. </param>
        public RunFilterParameters(DateTimeOffset lastUpdatedAfter, DateTimeOffset lastUpdatedBefore)
        {
            LastUpdatedAfter = lastUpdatedAfter;
            LastUpdatedBefore = lastUpdatedBefore;
            Filters = new ChangeTrackingList<RunQueryFilter>();
            OrderBy = new ChangeTrackingList<RunQueryOrderBy>();
        }

        /// <summary> The continuation token for getting the next page of results. Null for first page. </summary>
        public string ContinuationToken { get; set; }
        /// <summary> The time at or after which the run event was updated in &apos;ISO 8601&apos; format. </summary>
        public DateTimeOffset LastUpdatedAfter { get; }
        /// <summary> The time at or before which the run event was updated in &apos;ISO 8601&apos; format. </summary>
        public DateTimeOffset LastUpdatedBefore { get; }
        /// <summary> List of filters. </summary>
        public IList<RunQueryFilter> Filters { get; }
        /// <summary> List of OrderBy option. </summary>
        public IList<RunQueryOrderBy> OrderBy { get; }
    }
}
