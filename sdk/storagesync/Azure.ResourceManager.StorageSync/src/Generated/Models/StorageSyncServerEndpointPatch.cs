// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Parameters for updating an Server Endpoint. </summary>
    public partial class StorageSyncServerEndpointPatch
    {
        /// <summary> Initializes a new instance of <see cref="StorageSyncServerEndpointPatch"/>. </summary>
        public StorageSyncServerEndpointPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageSyncServerEndpointPatch"/>. </summary>
        /// <param name="cloudTiering"> Cloud Tiering. </param>
        /// <param name="volumeFreeSpacePercent"> Level of free space to be maintained by Cloud Tiering if it is enabled. </param>
        /// <param name="tierFilesOlderThanDays"> Tier files older than days. </param>
        /// <param name="offlineDataTransfer"> Offline data transfer. </param>
        /// <param name="offlineDataTransferShareName"> Offline data transfer share name. </param>
        /// <param name="localCacheMode"> Policy for enabling follow-the-sun business models: link local cache to cloud behavior to pre-populate before local access. </param>
        internal StorageSyncServerEndpointPatch(StorageSyncFeatureStatus? cloudTiering, int? volumeFreeSpacePercent, int? tierFilesOlderThanDays, StorageSyncFeatureStatus? offlineDataTransfer, string offlineDataTransferShareName, LocalCacheMode? localCacheMode)
        {
            CloudTiering = cloudTiering;
            VolumeFreeSpacePercent = volumeFreeSpacePercent;
            TierFilesOlderThanDays = tierFilesOlderThanDays;
            OfflineDataTransfer = offlineDataTransfer;
            OfflineDataTransferShareName = offlineDataTransferShareName;
            LocalCacheMode = localCacheMode;
        }

        /// <summary> Cloud Tiering. </summary>
        public StorageSyncFeatureStatus? CloudTiering { get; set; }
        /// <summary> Level of free space to be maintained by Cloud Tiering if it is enabled. </summary>
        public int? VolumeFreeSpacePercent { get; set; }
        /// <summary> Tier files older than days. </summary>
        public int? TierFilesOlderThanDays { get; set; }
        /// <summary> Offline data transfer. </summary>
        public StorageSyncFeatureStatus? OfflineDataTransfer { get; set; }
        /// <summary> Offline data transfer share name. </summary>
        public string OfflineDataTransferShareName { get; set; }
        /// <summary> Policy for enabling follow-the-sun business models: link local cache to cloud behavior to pre-populate before local access. </summary>
        public LocalCacheMode? LocalCacheMode { get; set; }
    }
}
