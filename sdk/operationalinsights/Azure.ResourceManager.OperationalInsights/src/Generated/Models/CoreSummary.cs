// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The core summary of a search. </summary>
    public partial class CoreSummary
    {
        /// <summary> Initializes a new instance of CoreSummary. </summary>
        /// <param name="numberOfDocuments"> The number of documents of a core summary. </param>
        internal CoreSummary(long numberOfDocuments)
        {
            NumberOfDocuments = numberOfDocuments;
        }

        /// <summary> Initializes a new instance of CoreSummary. </summary>
        /// <param name="status"> The status of a core summary. </param>
        /// <param name="numberOfDocuments"> The number of documents of a core summary. </param>
        internal CoreSummary(string status, long numberOfDocuments)
        {
            Status = status;
            NumberOfDocuments = numberOfDocuments;
        }

        /// <summary> The status of a core summary. </summary>
        public string Status { get; }
        /// <summary> The number of documents of a core summary. </summary>
        public long NumberOfDocuments { get; }
    }
}
