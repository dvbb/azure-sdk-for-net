// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.AnalysisServices;

namespace Azure.ResourceManager.AnalysisServices.Models
{
    /// <summary> An array of Analysis Services resources. </summary>
    internal partial class AnalysisServicesServers
    {
        /// <summary> Initializes a new instance of AnalysisServicesServers. </summary>
        /// <param name="value"> An array of Analysis Services resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal AnalysisServicesServers(IEnumerable<AnalysisServicesServerData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of AnalysisServicesServers. </summary>
        /// <param name="value"> An array of Analysis Services resources. </param>
        internal AnalysisServicesServers(IReadOnlyList<AnalysisServicesServerData> value)
        {
            Value = value;
        }

        /// <summary> An array of Analysis Services resources. </summary>
        public IReadOnlyList<AnalysisServicesServerData> Value { get; }
    }
}
