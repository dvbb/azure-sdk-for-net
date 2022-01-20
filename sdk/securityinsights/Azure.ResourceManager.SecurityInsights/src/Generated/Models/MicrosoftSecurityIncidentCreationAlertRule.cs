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
    /// <summary> Represents MicrosoftSecurityIncidentCreation rule. </summary>
    public partial class MicrosoftSecurityIncidentCreationAlertRule : AlertRuleData
    {
        /// <summary> Initializes a new instance of MicrosoftSecurityIncidentCreationAlertRule. </summary>
        public MicrosoftSecurityIncidentCreationAlertRule()
        {
            DisplayNamesFilter = new ChangeTrackingList<string>();
            DisplayNamesExcludeFilter = new ChangeTrackingList<string>();
            SeveritiesFilter = new ChangeTrackingList<AlertSeverity>();
            Kind = AlertRuleKind.MicrosoftSecurityIncidentCreation;
        }

        /// <summary> Initializes a new instance of MicrosoftSecurityIncidentCreationAlertRule. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="kind"> The kind of the alert rule. </param>
        /// <param name="displayNamesFilter"> the alerts&apos; displayNames on which the cases will be generated. </param>
        /// <param name="displayNamesExcludeFilter"> the alerts&apos; displayNames on which the cases will not be generated. </param>
        /// <param name="productFilter"> The alerts&apos; productName on which the cases will be generated. </param>
        /// <param name="severitiesFilter"> the alerts&apos; severities on which the cases will be generated. </param>
        /// <param name="alertRuleTemplateName"> The Name of the alert rule template used to create this rule. </param>
        /// <param name="description"> The description of the alert rule. </param>
        /// <param name="displayName"> The display name for alerts created by this alert rule. </param>
        /// <param name="enabled"> Determines whether this alert rule is enabled or disabled. </param>
        /// <param name="lastModifiedUtc"> The last time that this alert has been modified. </param>
        internal MicrosoftSecurityIncidentCreationAlertRule(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string etag, AlertRuleKind kind, IList<string> displayNamesFilter, IList<string> displayNamesExcludeFilter, MicrosoftSecurityProductName? productFilter, IList<AlertSeverity> severitiesFilter, string alertRuleTemplateName, string description, string displayName, bool? enabled, DateTimeOffset? lastModifiedUtc) : base(id, name, type, systemData, etag, kind)
        {
            DisplayNamesFilter = displayNamesFilter;
            DisplayNamesExcludeFilter = displayNamesExcludeFilter;
            ProductFilter = productFilter;
            SeveritiesFilter = severitiesFilter;
            AlertRuleTemplateName = alertRuleTemplateName;
            Description = description;
            DisplayName = displayName;
            Enabled = enabled;
            LastModifiedUtc = lastModifiedUtc;
            Kind = kind;
        }

        /// <summary> the alerts&apos; displayNames on which the cases will be generated. </summary>
        public IList<string> DisplayNamesFilter { get; }
        /// <summary> the alerts&apos; displayNames on which the cases will not be generated. </summary>
        public IList<string> DisplayNamesExcludeFilter { get; }
        /// <summary> The alerts&apos; productName on which the cases will be generated. </summary>
        public MicrosoftSecurityProductName? ProductFilter { get; set; }
        /// <summary> the alerts&apos; severities on which the cases will be generated. </summary>
        public IList<AlertSeverity> SeveritiesFilter { get; }
        /// <summary> The Name of the alert rule template used to create this rule. </summary>
        public string AlertRuleTemplateName { get; set; }
        /// <summary> The description of the alert rule. </summary>
        public string Description { get; set; }
        /// <summary> The display name for alerts created by this alert rule. </summary>
        public string DisplayName { get; set; }
        /// <summary> Determines whether this alert rule is enabled or disabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The last time that this alert has been modified. </summary>
        public DateTimeOffset? LastModifiedUtc { get; }
    }
}
