// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Execute power query data flow activity properties. </summary>
    internal partial class ExecutePowerQueryActivityTypeProperties : ExecuteDataFlowActivityTypeProperties
    {
        /// <summary> Initializes a new instance of ExecutePowerQueryActivityTypeProperties. </summary>
        /// <param name="dataFlow"> Data flow reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataFlow"/> is null. </exception>
        internal ExecutePowerQueryActivityTypeProperties(DataFlowReference dataFlow) : base(dataFlow)
        {
            if (dataFlow == null)
            {
                throw new ArgumentNullException(nameof(dataFlow));
            }

            Sinks = new ChangeTrackingDictionary<string, PowerQuerySink>();
            Queries = new ChangeTrackingList<PowerQuerySinkMapping>();
        }

        /// <summary> (Deprecated. Please use Queries). List of Power Query activity sinks mapped to a queryName. </summary>
        public IReadOnlyDictionary<string, PowerQuerySink> Sinks { get; }
        /// <summary> List of mapping for Power Query mashup query to sink dataset(s). </summary>
        public IReadOnlyList<PowerQuerySinkMapping> Queries { get; }
    }
}
