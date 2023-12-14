// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The List incidents operation response. </summary>
    internal partial class IncidentListResult
    {
        /// <summary> Initializes a new instance of <see cref="IncidentListResult"/>. </summary>
        internal IncidentListResult()
        {
            Value = new ChangeTrackingList<MonitorIncident>();
        }

        /// <summary> Initializes a new instance of <see cref="IncidentListResult"/>. </summary>
        /// <param name="value"> the incident collection. </param>
        internal IncidentListResult(IReadOnlyList<MonitorIncident> value)
        {
            Value = value;
        }

        /// <summary> the incident collection. </summary>
        public IReadOnlyList<MonitorIncident> Value { get; }
    }
}
