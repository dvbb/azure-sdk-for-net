// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list source control sync job streams operation. </summary>
    internal partial class SourceControlSyncJobStreamListResult
    {
        /// <summary> Initializes a new instance of <see cref="SourceControlSyncJobStreamListResult"/>. </summary>
        internal SourceControlSyncJobStreamListResult()
        {
            Value = new ChangeTrackingList<SourceControlSyncJobStream>();
        }

        /// <summary> Initializes a new instance of <see cref="SourceControlSyncJobStreamListResult"/>. </summary>
        /// <param name="value"> The list of source control sync job streams. </param>
        /// <param name="nextLink"> The next link. </param>
        internal SourceControlSyncJobStreamListResult(IReadOnlyList<SourceControlSyncJobStream> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of source control sync job streams. </summary>
        public IReadOnlyList<SourceControlSyncJobStream> Value { get; }
        /// <summary> The next link. </summary>
        public string NextLink { get; }
    }
}
