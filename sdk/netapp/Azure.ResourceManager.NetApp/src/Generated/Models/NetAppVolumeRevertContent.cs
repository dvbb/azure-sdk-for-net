// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> revert a volume to the snapshot. </summary>
    public partial class NetAppVolumeRevertContent
    {
        /// <summary> Initializes a new instance of NetAppVolumeRevertContent. </summary>
        public NetAppVolumeRevertContent()
        {
        }

        /// <summary> Resource id of the snapshot. </summary>
        public string SnapshotId { get; set; }
    }
}
