// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Backup status. </summary>
    public partial class BackupStatus
    {
        /// <summary> Initializes a new instance of BackupStatus. </summary>
        internal BackupStatus()
        {
        }

        /// <summary> Initializes a new instance of BackupStatus. </summary>
        /// <param name="healthy"> Backup health status. </param>
        /// <param name="relationshipStatus"> Status of the backup mirror relationship. </param>
        /// <param name="mirrorState"> The status of the backup. </param>
        /// <param name="unhealthyReason"> Reason for the unhealthy backup relationship. </param>
        /// <param name="errorMessage"> Displays error message if the backup is in an error state. </param>
        /// <param name="lastTransferSize"> Displays the last transfer size. </param>
        /// <param name="lastTransferType"> Displays the last transfer type. </param>
        /// <param name="totalTransferBytes"> Displays the total bytes transferred. </param>
        internal BackupStatus(bool? healthy, RelationshipStatus? relationshipStatus, MirrorState? mirrorState, string unhealthyReason, string errorMessage, long? lastTransferSize, string lastTransferType, long? totalTransferBytes)
        {
            Healthy = healthy;
            RelationshipStatus = relationshipStatus;
            MirrorState = mirrorState;
            UnhealthyReason = unhealthyReason;
            ErrorMessage = errorMessage;
            LastTransferSize = lastTransferSize;
            LastTransferType = lastTransferType;
            TotalTransferBytes = totalTransferBytes;
        }

        /// <summary> Backup health status. </summary>
        public bool? Healthy { get; }
        /// <summary> Status of the backup mirror relationship. </summary>
        public RelationshipStatus? RelationshipStatus { get; }
        /// <summary> The status of the backup. </summary>
        public MirrorState? MirrorState { get; }
        /// <summary> Reason for the unhealthy backup relationship. </summary>
        public string UnhealthyReason { get; }
        /// <summary> Displays error message if the backup is in an error state. </summary>
        public string ErrorMessage { get; }
        /// <summary> Displays the last transfer size. </summary>
        public long? LastTransferSize { get; }
        /// <summary> Displays the last transfer type. </summary>
        public string LastTransferType { get; }
        /// <summary> Displays the total bytes transferred. </summary>
        public long? TotalTransferBytes { get; }
    }
}
