// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    /// <summary> A class representing the ServerEndpoint data model. </summary>
    public partial class ServerEndpointData : Resource
    {
        /// <summary> Initializes a new instance of ServerEndpointData. </summary>
        public ServerEndpointData()
        {
        }

        /// <summary> Initializes a new instance of ServerEndpointData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="serverLocalPath"> Server Local path. </param>
        /// <param name="cloudTiering"> Cloud Tiering. </param>
        /// <param name="volumeFreeSpacePercent"> Level of free space to be maintained by Cloud Tiering if it is enabled. </param>
        /// <param name="tierFilesOlderThanDays"> Tier files older than days. </param>
        /// <param name="friendlyName"> Friendly Name. </param>
        /// <param name="serverResourceId"> Server Resource Id. </param>
        /// <param name="provisioningState"> ServerEndpoint Provisioning State. </param>
        /// <param name="lastWorkflowId"> ServerEndpoint lastWorkflowId. </param>
        /// <param name="lastOperationName"> Resource Last Operation Name. </param>
        /// <param name="syncStatus"> Server Endpoint sync status. </param>
        /// <param name="offlineDataTransfer"> Offline data transfer. </param>
        /// <param name="offlineDataTransferStorageAccountResourceId"> Offline data transfer storage account resource ID. </param>
        /// <param name="offlineDataTransferStorageAccountTenantId"> Offline data transfer storage account tenant ID. </param>
        /// <param name="offlineDataTransferShareName"> Offline data transfer share name. </param>
        /// <param name="cloudTieringStatus"> Cloud tiering status. Only populated if cloud tiering is enabled. </param>
        /// <param name="recallStatus"> Recall status. Only populated if cloud tiering is enabled. </param>
        /// <param name="initialDownloadPolicy"> Policy for how namespace and files are recalled during FastDr. </param>
        /// <param name="localCacheMode"> Policy for enabling follow-the-sun business models: link local cache to cloud behavior to pre-populate before local access. </param>
        /// <param name="initialUploadPolicy"> Policy for how the initial upload sync session is performed. </param>
        /// <param name="serverName"> Server name. </param>
        internal ServerEndpointData(ResourceIdentifier id, string name, ResourceType type, string serverLocalPath, FeatureStatus? cloudTiering, int? volumeFreeSpacePercent, int? tierFilesOlderThanDays, string friendlyName, string serverResourceId, string provisioningState, string lastWorkflowId, string lastOperationName, ServerEndpointSyncStatus syncStatus, FeatureStatus? offlineDataTransfer, string offlineDataTransferStorageAccountResourceId, string offlineDataTransferStorageAccountTenantId, string offlineDataTransferShareName, ServerEndpointCloudTieringStatus cloudTieringStatus, ServerEndpointRecallStatus recallStatus, InitialDownloadPolicy? initialDownloadPolicy, LocalCacheMode? localCacheMode, InitialUploadPolicy? initialUploadPolicy, string serverName) : base(id, name, type)
        {
            ServerLocalPath = serverLocalPath;
            CloudTiering = cloudTiering;
            VolumeFreeSpacePercent = volumeFreeSpacePercent;
            TierFilesOlderThanDays = tierFilesOlderThanDays;
            FriendlyName = friendlyName;
            ServerResourceId = serverResourceId;
            ProvisioningState = provisioningState;
            LastWorkflowId = lastWorkflowId;
            LastOperationName = lastOperationName;
            SyncStatus = syncStatus;
            OfflineDataTransfer = offlineDataTransfer;
            OfflineDataTransferStorageAccountResourceId = offlineDataTransferStorageAccountResourceId;
            OfflineDataTransferStorageAccountTenantId = offlineDataTransferStorageAccountTenantId;
            OfflineDataTransferShareName = offlineDataTransferShareName;
            CloudTieringStatus = cloudTieringStatus;
            RecallStatus = recallStatus;
            InitialDownloadPolicy = initialDownloadPolicy;
            LocalCacheMode = localCacheMode;
            InitialUploadPolicy = initialUploadPolicy;
            ServerName = serverName;
        }

        /// <summary> Server Local path. </summary>
        public string ServerLocalPath { get; set; }
        /// <summary> Cloud Tiering. </summary>
        public FeatureStatus? CloudTiering { get; set; }
        /// <summary> Level of free space to be maintained by Cloud Tiering if it is enabled. </summary>
        public int? VolumeFreeSpacePercent { get; set; }
        /// <summary> Tier files older than days. </summary>
        public int? TierFilesOlderThanDays { get; set; }
        /// <summary> Friendly Name. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Server Resource Id. </summary>
        public string ServerResourceId { get; set; }
        /// <summary> ServerEndpoint Provisioning State. </summary>
        public string ProvisioningState { get; }
        /// <summary> ServerEndpoint lastWorkflowId. </summary>
        public string LastWorkflowId { get; }
        /// <summary> Resource Last Operation Name. </summary>
        public string LastOperationName { get; }
        /// <summary> Server Endpoint sync status. </summary>
        public ServerEndpointSyncStatus SyncStatus { get; }
        /// <summary> Offline data transfer. </summary>
        public FeatureStatus? OfflineDataTransfer { get; set; }
        /// <summary> Offline data transfer storage account resource ID. </summary>
        public string OfflineDataTransferStorageAccountResourceId { get; }
        /// <summary> Offline data transfer storage account tenant ID. </summary>
        public string OfflineDataTransferStorageAccountTenantId { get; }
        /// <summary> Offline data transfer share name. </summary>
        public string OfflineDataTransferShareName { get; set; }
        /// <summary> Cloud tiering status. Only populated if cloud tiering is enabled. </summary>
        public ServerEndpointCloudTieringStatus CloudTieringStatus { get; }
        /// <summary> Recall status. Only populated if cloud tiering is enabled. </summary>
        public ServerEndpointRecallStatus RecallStatus { get; }
        /// <summary> Policy for how namespace and files are recalled during FastDr. </summary>
        public InitialDownloadPolicy? InitialDownloadPolicy { get; set; }
        /// <summary> Policy for enabling follow-the-sun business models: link local cache to cloud behavior to pre-populate before local access. </summary>
        public LocalCacheMode? LocalCacheMode { get; set; }
        /// <summary> Policy for how the initial upload sync session is performed. </summary>
        public InitialUploadPolicy? InitialUploadPolicy { get; set; }
        /// <summary> Server name. </summary>
        public string ServerName { get; }
    }
}
