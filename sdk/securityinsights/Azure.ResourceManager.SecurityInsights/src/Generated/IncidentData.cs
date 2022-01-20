// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary> A class representing the Incident data model. </summary>
    public partial class IncidentData : ResourceWithEtag
    {
        /// <summary> Initializes a new instance of IncidentData. </summary>
        public IncidentData()
        {
            Labels = new ChangeTrackingList<IncidentLabel>();
            RelatedAnalyticRuleIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of IncidentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="additionalData"> Additional data on the incident. </param>
        /// <param name="classification"> The reason the incident was closed. </param>
        /// <param name="classificationComment"> Describes the reason the incident was closed. </param>
        /// <param name="classificationReason"> The classification reason the incident was closed with. </param>
        /// <param name="createdTimeUtc"> The time the incident was created. </param>
        /// <param name="description"> The description of the incident. </param>
        /// <param name="firstActivityTimeUtc"> The time of the first activity in the incident. </param>
        /// <param name="incidentUrl"> The deep-link url to the incident in Azure portal. </param>
        /// <param name="incidentNumber"> A sequential number. </param>
        /// <param name="labels"> List of labels relevant to this incident. </param>
        /// <param name="providerName"> The name of the source provider that generated the incident. </param>
        /// <param name="providerIncidentId"> The incident ID assigned by the incident provider. </param>
        /// <param name="lastActivityTimeUtc"> The time of the last activity in the incident. </param>
        /// <param name="lastModifiedTimeUtc"> The last time the incident was updated. </param>
        /// <param name="owner"> Describes a user that the incident is assigned to. </param>
        /// <param name="relatedAnalyticRuleIds"> List of resource ids of Analytic rules related to the incident. </param>
        /// <param name="severity"> The severity of the incident. </param>
        /// <param name="status"> The status of the incident. </param>
        /// <param name="teamInformation"> Describes a team for the incident. </param>
        /// <param name="title"> The title of the incident. </param>
        internal IncidentData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string etag, IncidentAdditionalData additionalData, IncidentClassification? classification, string classificationComment, IncidentClassificationReason? classificationReason, DateTimeOffset? createdTimeUtc, string description, DateTimeOffset? firstActivityTimeUtc, string incidentUrl, int? incidentNumber, IList<IncidentLabel> labels, string providerName, string providerIncidentId, DateTimeOffset? lastActivityTimeUtc, DateTimeOffset? lastModifiedTimeUtc, IncidentOwnerInfo owner, IReadOnlyList<string> relatedAnalyticRuleIds, IncidentSeverity? severity, IncidentStatus? status, TeamInformation teamInformation, string title) : base(id, name, type, systemData, etag)
        {
            AdditionalData = additionalData;
            Classification = classification;
            ClassificationComment = classificationComment;
            ClassificationReason = classificationReason;
            CreatedTimeUtc = createdTimeUtc;
            Description = description;
            FirstActivityTimeUtc = firstActivityTimeUtc;
            IncidentUrl = incidentUrl;
            IncidentNumber = incidentNumber;
            Labels = labels;
            ProviderName = providerName;
            ProviderIncidentId = providerIncidentId;
            LastActivityTimeUtc = lastActivityTimeUtc;
            LastModifiedTimeUtc = lastModifiedTimeUtc;
            Owner = owner;
            RelatedAnalyticRuleIds = relatedAnalyticRuleIds;
            Severity = severity;
            Status = status;
            TeamInformation = teamInformation;
            Title = title;
        }

        /// <summary> Additional data on the incident. </summary>
        public IncidentAdditionalData AdditionalData { get; }
        /// <summary> The reason the incident was closed. </summary>
        public IncidentClassification? Classification { get; set; }
        /// <summary> Describes the reason the incident was closed. </summary>
        public string ClassificationComment { get; set; }
        /// <summary> The classification reason the incident was closed with. </summary>
        public IncidentClassificationReason? ClassificationReason { get; set; }
        /// <summary> The time the incident was created. </summary>
        public DateTimeOffset? CreatedTimeUtc { get; }
        /// <summary> The description of the incident. </summary>
        public string Description { get; set; }
        /// <summary> The time of the first activity in the incident. </summary>
        public DateTimeOffset? FirstActivityTimeUtc { get; set; }
        /// <summary> The deep-link url to the incident in Azure portal. </summary>
        public string IncidentUrl { get; }
        /// <summary> A sequential number. </summary>
        public int? IncidentNumber { get; }
        /// <summary> List of labels relevant to this incident. </summary>
        public IList<IncidentLabel> Labels { get; }
        /// <summary> The name of the source provider that generated the incident. </summary>
        public string ProviderName { get; set; }
        /// <summary> The incident ID assigned by the incident provider. </summary>
        public string ProviderIncidentId { get; set; }
        /// <summary> The time of the last activity in the incident. </summary>
        public DateTimeOffset? LastActivityTimeUtc { get; set; }
        /// <summary> The last time the incident was updated. </summary>
        public DateTimeOffset? LastModifiedTimeUtc { get; }
        /// <summary> Describes a user that the incident is assigned to. </summary>
        public IncidentOwnerInfo Owner { get; set; }
        /// <summary> List of resource ids of Analytic rules related to the incident. </summary>
        public IReadOnlyList<string> RelatedAnalyticRuleIds { get; }
        /// <summary> The severity of the incident. </summary>
        public IncidentSeverity? Severity { get; set; }
        /// <summary> The status of the incident. </summary>
        public IncidentStatus? Status { get; set; }
        /// <summary> Describes a team for the incident. </summary>
        public TeamInformation TeamInformation { get; set; }
        /// <summary> The title of the incident. </summary>
        public string Title { get; set; }
    }
}
