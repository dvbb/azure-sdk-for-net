// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmDataProtectionBackupModelFactory
    {
        /// <summary>
        /// Initializes a new instance of DataProtectionBackupVaultProperties.
        /// </summary>
        /// <param name="alertSettingsForAllJobFailures"></param>
        /// <param name="provisioningState"></param>
        /// <param name="resourceMoveState"></param>
        /// <param name="resourceMoveDetails"></param>
        /// <param name="securitySettings"></param>
        /// <param name="storageSettings"></param>
        /// <param name="isVaultProtectedByResourceGuard"></param>
        /// <param name="crossSubscriptionRestoreState"></param>
        /// <returns></returns>
        public static DataProtectionBackupVaultProperties DataProtectionBackupVaultProperties(AzureMonitorAlertsState? alertSettingsForAllJobFailures = null, DataProtectionBackupProvisioningState? provisioningState = null, BackupVaultResourceMoveState? resourceMoveState = null, BackupVaultResourceMoveDetails resourceMoveDetails = null, BackupVaultSecuritySettings securitySettings = null, IEnumerable<DataProtectionBackupStorageSetting> storageSettings = null, bool? isVaultProtectedByResourceGuard = null, DataProtectionBackupCrossSubscriptionRestoreState? crossSubscriptionRestoreState = null)
        {
            storageSettings ??= new List<DataProtectionBackupStorageSetting>();
            BackupVaultFeatureSettings featureSettings = null;

            if (crossSubscriptionRestoreState != null)
            {
                featureSettings = new BackupVaultFeatureSettings();
                featureSettings.CrossSubscriptionRestoreState = crossSubscriptionRestoreState;
            }

            return new DataProtectionBackupVaultProperties(alertSettingsForAllJobFailures != null ? new MonitoringSettings(new AzureMonitorAlertSettings(alertSettingsForAllJobFailures)) : null, provisioningState, resourceMoveState, resourceMoveDetails, securitySettings, storageSettings?.ToList(), isVaultProtectedByResourceGuard, featureSettings, null, null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DataProtectionBackupVaultProperties"/>. </summary>
        /// <param name="alertSettingsForAllJobFailures"> Monitoring Settings. </param>
        /// <param name="provisioningState"> Provisioning state of the BackupVault resource. </param>
        /// <param name="resourceMoveState"> Resource move state for backup vault. </param>
        /// <param name="resourceMoveDetails"> Resource move details for backup vault. </param>
        /// <param name="securitySettings"> Security Settings. </param>
        /// <param name="storageSettings"> Storage Settings. </param>
        /// <param name="isVaultProtectedByResourceGuard"> Is vault protected by resource guard. </param>
        /// <param name="featureSettings"> Feature Settings. </param>
        /// <param name="secureScore"> Secure Score of Backup Vault. </param>
        /// <returns> A new <see cref="Models.DataProtectionBackupVaultProperties"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static DataProtectionBackupVaultProperties DataProtectionBackupVaultProperties(AzureMonitorAlertsState? alertSettingsForAllJobFailures = null, DataProtectionBackupProvisioningState? provisioningState = null, BackupVaultResourceMoveState? resourceMoveState = null, BackupVaultResourceMoveDetails resourceMoveDetails = null, BackupVaultSecuritySettings securitySettings = null, IEnumerable<DataProtectionBackupStorageSetting> storageSettings = null, bool? isVaultProtectedByResourceGuard = null, BackupVaultFeatureSettings featureSettings = null, BackupVaultSecureScoreLevel? secureScore = null)
        {
            return DataProtectionBackupVaultProperties(alertSettingsForAllJobFailures, provisioningState, resourceMoveState, resourceMoveDetails, securitySettings, storageSettings, isVaultProtectedByResourceGuard, featureSettings, secureScore, null);
        }

        /// <summary>
        /// Initializes a new instance of DataProtectionBackupInstanceProperties.
        /// </summary>
        /// <param name="friendlyName"></param>
        /// <param name="dataSourceInfo"></param>
        /// <param name="dataSourceSetInfo"></param>
        /// <param name="policyInfo"></param>
        /// <param name="protectionStatus"></param>
        /// <param name="currentProtectionState"></param>
        /// <param name="protectionErrorDetails"></param>
        /// <param name="provisioningState"></param>
        /// <param name="dataSourceAuthCredentials"></param>
        /// <param name="validationType"></param>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public static DataProtectionBackupInstanceProperties DataProtectionBackupInstanceProperties(string friendlyName = null, DataSourceInfo dataSourceInfo = null, DataSourceSetInfo dataSourceSetInfo = null, BackupInstancePolicyInfo policyInfo = null, BackupInstanceProtectionStatusDetails protectionStatus = null, CurrentProtectionState? currentProtectionState = null, ResponseError protectionErrorDetails = null, string provisioningState = null, DataProtectionBackupAuthCredentials dataSourceAuthCredentials = null, BackupValidationType? validationType = null, string objectType = null)
        {
            return new DataProtectionBackupInstanceProperties(friendlyName, dataSourceInfo, dataSourceSetInfo, policyInfo, protectionStatus, currentProtectionState, protectionErrorDetails, provisioningState, dataSourceAuthCredentials, validationType, null, objectType);
        }

        /// <summary>
        /// Initializes a new instance of DataProtectionBackupJobProperties.
        /// </summary>
        /// <param name="activityId"></param>
        /// <param name="backupInstanceFriendlyName"></param>
        /// <param name="backupInstanceId"></param>
        /// <param name="dataSourceId"></param>
        /// <param name="dataSourceLocation"></param>
        /// <param name="dataSourceName"></param>
        /// <param name="dataSourceSetName"></param>
        /// <param name="dataSourceType"></param>
        /// <param name="duration"></param>
        /// <param name="endOn"></param>
        /// <param name="errorDetails"></param>
        /// <param name="extendedInfo"></param>
        /// <param name="isUserTriggered"></param>
        /// <param name="operation"></param>
        /// <param name="operationCategory"></param>
        /// <param name="policyId"></param>
        /// <param name="policyName"></param>
        /// <param name="isProgressEnabled"></param>
        /// <param name="progressUri"></param>
        /// <param name="restoreType"></param>
        /// <param name="sourceResourceGroup"></param>
        /// <param name="sourceSubscriptionId"></param>
        /// <param name="startOn"></param>
        /// <param name="status"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="supportedActions"></param>
        /// <param name="vaultName"></param>
        /// <param name="eTag"></param>
        /// <param name="sourceDataStoreName"></param>
        /// <param name="destinationDataStoreName"></param>
        /// <returns></returns>
        public static DataProtectionBackupJobProperties DataProtectionBackupJobProperties(string activityId = null, string backupInstanceFriendlyName = null, ResourceIdentifier backupInstanceId = null, ResourceIdentifier dataSourceId = null, AzureLocation dataSourceLocation = default, string dataSourceName = null, string dataSourceSetName = null, string dataSourceType = null, TimeSpan? duration = null, DateTimeOffset? endOn = null, IEnumerable<ResponseError> errorDetails = null, BackupJobExtendedInfo extendedInfo = null, bool isUserTriggered = default, string operation = null, string operationCategory = null, ResourceIdentifier policyId = null, string policyName = null, bool isProgressEnabled = default, Uri progressUri = null, string restoreType = null, string sourceResourceGroup = null, string sourceSubscriptionId = null, DateTimeOffset startOn = default, string status = null, string subscriptionId = null, IEnumerable<string> supportedActions = null, string vaultName = null, ETag? eTag = null, string sourceDataStoreName = null, string destinationDataStoreName = null)
        {
            errorDetails ??= new List<ResponseError>();
            supportedActions ??= new List<string>();

            return new DataProtectionBackupJobProperties(activityId, backupInstanceFriendlyName, backupInstanceId, dataSourceId, dataSourceLocation, dataSourceName, dataSourceSetName, dataSourceType, duration, endOn, errorDetails?.ToList(), extendedInfo, isUserTriggered, operation, operationCategory, policyId, policyName, isProgressEnabled, progressUri, null, restoreType, sourceResourceGroup, sourceSubscriptionId, startOn, status, subscriptionId, supportedActions?.ToList(), vaultName, eTag, sourceDataStoreName, destinationDataStoreName);
        }

        /// <summary>
        /// Initializes a new instance of DataProtectionBackupDataSourceProperties.
        /// </summary>
        /// <param name="friendlyName"></param>
        /// <param name="dataSourceInfo"></param>
        /// <param name="dataSourceSetInfo"></param>
        /// <param name="policyInfo"></param>
        /// <param name="protectionStatus"></param>
        /// <param name="currentProtectionState"></param>
        /// <param name="protectionErrorDetails"></param>
        /// <param name="provisioningState"></param>
        /// <param name="dataSourceAuthCredentials"></param>
        /// <param name="validationType"></param>
        /// <param name="objectType"></param>
        /// <param name="deletionInfo"></param>
        /// <returns></returns>
        public static DeletedDataProtectionBackupInstanceProperties DeletedDataProtectionBackupInstanceProperties(string friendlyName = null, DataSourceInfo dataSourceInfo = null, DataSourceSetInfo dataSourceSetInfo = null, BackupInstancePolicyInfo policyInfo = null, BackupInstanceProtectionStatusDetails protectionStatus = null, CurrentProtectionState? currentProtectionState = null, ResponseError protectionErrorDetails = null, string provisioningState = null, DataProtectionBackupAuthCredentials dataSourceAuthCredentials = null, BackupValidationType? validationType = null, string objectType = null, BackupInstanceDeletionInfo deletionInfo = null)
        {
            return new DeletedDataProtectionBackupInstanceProperties(friendlyName, dataSourceInfo, dataSourceSetInfo, policyInfo, protectionStatus, currentProtectionState, protectionErrorDetails, provisioningState, dataSourceAuthCredentials, validationType, null, objectType, deletionInfo);
        }

        /// <summary> Initializes a new instance of BackupJobExtendedInfo. </summary>
        /// <param name="additionalDetails"> Job's Additional Details. </param>
        /// <param name="backupInstanceState"> State of the Backup Instance. </param>
        /// <param name="dataTransferredInBytes"> Number of bytes transferred. </param>
        /// <param name="recoveryDestination"> Destination where restore is done. </param>
        /// <param name="sourceRecoverPoint"> Details of the Source Recovery Point. </param>
        /// <param name="subTasks"> List of Sub Tasks of the job. </param>
        /// <param name="targetRecoverPoint"> Details of the Target Recovery Point. </param>
        /// <returns> A new <see cref="Models.BackupJobExtendedInfo"/> instance for mocking. </returns>
        public static BackupJobExtendedInfo BackupJobExtendedInfo(IReadOnlyDictionary<string, string> additionalDetails = null, string backupInstanceState = null, double? dataTransferredInBytes = null, string recoveryDestination = null, RestoreJobRecoveryPointDetails sourceRecoverPoint = null, IEnumerable<BackupJobSubTask> subTasks = null, RestoreJobRecoveryPointDetails targetRecoverPoint = null)
        {
            return BackupJobExtendedInfo(additionalDetails, backupInstanceState, dataTransferredInBytes, recoveryDestination, sourceRecoverPoint, subTasks, targetRecoverPoint, null);
        }

        /// <summary> Initializes a new instance of DataProtectionBackupDiscreteRecoveryPointProperties. </summary>
        /// <param name="friendlyName"></param>
        /// <param name="recoveryPointDataStoresDetails"></param>
        /// <param name="recoverOn"></param>
        /// <param name="policyName"></param>
        /// <param name="policyVersion"></param>
        /// <param name="recoveryPointId"></param>
        /// <param name="recoveryPointType"></param>
        /// <param name="retentionTagName"></param>
        /// <param name="retentionTagVersion"></param>
        /// <param name="expireOn"></param>
        /// <returns> A new <see cref="Models.DataProtectionBackupDiscreteRecoveryPointProperties"/> instance for mocking. </returns>
        public static DataProtectionBackupDiscreteRecoveryPointProperties DataProtectionBackupDiscreteRecoveryPointProperties(string friendlyName = null, IEnumerable<RecoveryPointDataStoreDetail> recoveryPointDataStoresDetails = null, DateTimeOffset recoverOn = default, string policyName = null, string policyVersion = null, string recoveryPointId = null, string recoveryPointType = null, string retentionTagName = null, string retentionTagVersion = null, DateTimeOffset? expireOn = null)
        {
            return DataProtectionBackupDiscreteRecoveryPointProperties(friendlyName, recoveryPointDataStoresDetails, recoverOn, policyName, policyVersion, recoveryPointId, recoveryPointType, retentionTagName, retentionTagVersion, expireOn, null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.DataProtectionOperationJobExtendedInfo"/>. </summary>
        /// <param name="jobResourceId"> Arm Id of the job created for this operation. </param>
        /// <returns> A new <see cref="Models.DataProtectionOperationJobExtendedInfo"/> instance for mocking. </returns>
        public static DataProtectionOperationJobExtendedInfo DataProtectionOperationJobExtendedInfo(Azure.Core.ResourceIdentifier jobResourceId = null)
        {
            return DataProtectionOperationJobExtendedInfo(jobResourceId.ToString());
        }
    }
}
