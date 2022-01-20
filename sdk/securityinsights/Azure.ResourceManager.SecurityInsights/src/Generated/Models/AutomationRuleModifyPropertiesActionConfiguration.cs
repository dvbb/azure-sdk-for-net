// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The configuration of the modify properties automation rule action. </summary>
    public partial class AutomationRuleModifyPropertiesActionConfiguration
    {
        /// <summary> Initializes a new instance of AutomationRuleModifyPropertiesActionConfiguration. </summary>
        public AutomationRuleModifyPropertiesActionConfiguration()
        {
            Labels = new ChangeTrackingList<IncidentLabel>();
        }

        /// <summary> Initializes a new instance of AutomationRuleModifyPropertiesActionConfiguration. </summary>
        /// <param name="classification"> The reason the incident was closed. </param>
        /// <param name="classificationComment"> Describes the reason the incident was closed. </param>
        /// <param name="classificationReason"> The classification reason the incident was closed with. </param>
        /// <param name="labels"> List of labels to add to the incident. </param>
        /// <param name="owner"> Describes a user that the incident is assigned to. </param>
        /// <param name="severity"> The severity of the incident. </param>
        /// <param name="status"> The status of the incident. </param>
        internal AutomationRuleModifyPropertiesActionConfiguration(IncidentClassification? classification, string classificationComment, IncidentClassificationReason? classificationReason, IList<IncidentLabel> labels, IncidentOwnerInfo owner, IncidentSeverity? severity, IncidentStatus? status)
        {
            Classification = classification;
            ClassificationComment = classificationComment;
            ClassificationReason = classificationReason;
            Labels = labels;
            Owner = owner;
            Severity = severity;
            Status = status;
        }

        /// <summary> The reason the incident was closed. </summary>
        public IncidentClassification? Classification { get; set; }
        /// <summary> Describes the reason the incident was closed. </summary>
        public string ClassificationComment { get; set; }
        /// <summary> The classification reason the incident was closed with. </summary>
        public IncidentClassificationReason? ClassificationReason { get; set; }
        /// <summary> List of labels to add to the incident. </summary>
        public IList<IncidentLabel> Labels { get; }
        /// <summary> Describes a user that the incident is assigned to. </summary>
        public IncidentOwnerInfo Owner { get; set; }
        /// <summary> The severity of the incident. </summary>
        public IncidentSeverity? Severity { get; set; }
        /// <summary> The status of the incident. </summary>
        public IncidentStatus? Status { get; set; }
    }
}
