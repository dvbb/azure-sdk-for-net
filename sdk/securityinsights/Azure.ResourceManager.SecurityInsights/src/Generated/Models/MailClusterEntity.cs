// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a mail cluster entity. </summary>
    public partial class MailClusterEntity : EntityData
    {
        /// <summary> Initializes a new instance of MailClusterEntity. </summary>
        public MailClusterEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, object>();
            NetworkMessageIds = new ChangeTrackingList<string>();
            Threats = new ChangeTrackingList<string>();
            Kind = EntityKind.MailCluster;
        }

        /// <summary> Initializes a new instance of MailClusterEntity. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="networkMessageIds"> The mail message IDs that are part of the mail cluster. </param>
        /// <param name="countByDeliveryStatus"> Count of mail messages by DeliveryStatus string representation. </param>
        /// <param name="countByThreatType"> Count of mail messages by ThreatType string representation. </param>
        /// <param name="countByProtectionStatus"> Count of mail messages by ProtectionStatus string representation. </param>
        /// <param name="threats"> The threats of mail messages that are part of the mail cluster. </param>
        /// <param name="query"> The query that was used to identify the messages of the mail cluster. </param>
        /// <param name="queryTime"> The query time. </param>
        /// <param name="mailCount"> The number of mail messages that are part of the mail cluster. </param>
        /// <param name="isVolumeAnomaly"> Is this a volume anomaly mail cluster. </param>
        /// <param name="source"> The source of the mail cluster (default is &apos;O365 ATP&apos;). </param>
        /// <param name="clusterSourceIdentifier"> The id of the cluster source. </param>
        /// <param name="clusterSourceType"> The type of the cluster source. </param>
        /// <param name="clusterQueryStartTime"> The cluster query start time. </param>
        /// <param name="clusterQueryEndTime"> The cluster query end time. </param>
        /// <param name="clusterGroup"> The cluster group. </param>
        internal MailClusterEntity(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, EntityKind kind, IReadOnlyDictionary<string, object> additionalData, string friendlyName, IReadOnlyList<string> networkMessageIds, object countByDeliveryStatus, object countByThreatType, object countByProtectionStatus, IReadOnlyList<string> threats, string query, DateTimeOffset? queryTime, int? mailCount, bool? isVolumeAnomaly, string source, string clusterSourceIdentifier, string clusterSourceType, DateTimeOffset? clusterQueryStartTime, DateTimeOffset? clusterQueryEndTime, string clusterGroup) : base(id, name, type, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            NetworkMessageIds = networkMessageIds;
            CountByDeliveryStatus = countByDeliveryStatus;
            CountByThreatType = countByThreatType;
            CountByProtectionStatus = countByProtectionStatus;
            Threats = threats;
            Query = query;
            QueryTime = queryTime;
            MailCount = mailCount;
            IsVolumeAnomaly = isVolumeAnomaly;
            Source = source;
            ClusterSourceIdentifier = clusterSourceIdentifier;
            ClusterSourceType = clusterSourceType;
            ClusterQueryStartTime = clusterQueryStartTime;
            ClusterQueryEndTime = clusterQueryEndTime;
            ClusterGroup = clusterGroup;
            Kind = kind;
        }

        /// <summary> A bag of custom fields that should be part of the entity and will be presented to the user. </summary>
        public IReadOnlyDictionary<string, object> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> The mail message IDs that are part of the mail cluster. </summary>
        public IReadOnlyList<string> NetworkMessageIds { get; }
        /// <summary> Count of mail messages by DeliveryStatus string representation. </summary>
        public object CountByDeliveryStatus { get; }
        /// <summary> Count of mail messages by ThreatType string representation. </summary>
        public object CountByThreatType { get; }
        /// <summary> Count of mail messages by ProtectionStatus string representation. </summary>
        public object CountByProtectionStatus { get; }
        /// <summary> The threats of mail messages that are part of the mail cluster. </summary>
        public IReadOnlyList<string> Threats { get; }
        /// <summary> The query that was used to identify the messages of the mail cluster. </summary>
        public string Query { get; }
        /// <summary> The query time. </summary>
        public DateTimeOffset? QueryTime { get; }
        /// <summary> The number of mail messages that are part of the mail cluster. </summary>
        public int? MailCount { get; }
        /// <summary> Is this a volume anomaly mail cluster. </summary>
        public bool? IsVolumeAnomaly { get; }
        /// <summary> The source of the mail cluster (default is &apos;O365 ATP&apos;). </summary>
        public string Source { get; }
        /// <summary> The id of the cluster source. </summary>
        public string ClusterSourceIdentifier { get; }
        /// <summary> The type of the cluster source. </summary>
        public string ClusterSourceType { get; }
        /// <summary> The cluster query start time. </summary>
        public DateTimeOffset? ClusterQueryStartTime { get; }
        /// <summary> The cluster query end time. </summary>
        public DateTimeOffset? ClusterQueryEndTime { get; }
        /// <summary> The cluster group. </summary>
        public string ClusterGroup { get; }
    }
}
