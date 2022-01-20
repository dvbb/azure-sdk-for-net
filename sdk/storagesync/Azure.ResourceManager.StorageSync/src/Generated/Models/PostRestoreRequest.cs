// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Post Restore Request. </summary>
    public partial class PostRestoreRequest
    {
        /// <summary> Initializes a new instance of PostRestoreRequest. </summary>
        public PostRestoreRequest()
        {
            RestoreFileSpec = new ChangeTrackingList<RestoreFileSpec>();
        }

        /// <summary> Post Restore partition. </summary>
        public string Partition { get; set; }
        /// <summary> Post Restore replica group. </summary>
        public string ReplicaGroup { get; set; }
        /// <summary> Post Restore request id. </summary>
        public string RequestId { get; set; }
        /// <summary> Post Restore Azure file share uri. </summary>
        public string AzureFileShareUri { get; set; }
        /// <summary> Post Restore Azure status. </summary>
        public string Status { get; set; }
        /// <summary> Post Restore Azure source azure file share uri. </summary>
        public string SourceAzureFileShareUri { get; set; }
        /// <summary> Post Restore Azure failed file list. </summary>
        public string FailedFileList { get; set; }
        /// <summary> Post Restore restore file spec array. </summary>
        public IList<RestoreFileSpec> RestoreFileSpec { get; }
    }
}
