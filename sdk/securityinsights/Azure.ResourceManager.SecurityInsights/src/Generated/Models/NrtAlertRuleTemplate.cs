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
    /// <summary> Represents NRT alert rule template. </summary>
    public partial class NrtAlertRuleTemplate : AlertRuleTemplateData
    {
        /// <summary> Initializes a new instance of NrtAlertRuleTemplate. </summary>
        public NrtAlertRuleTemplate()
        {
            RequiredDataConnectors = new ChangeTrackingList<AlertRuleTemplateDataSource>();
            Tactics = new ChangeTrackingList<AttackTactic>();
            CustomDetails = new ChangeTrackingDictionary<string, string>();
            EntityMappings = new ChangeTrackingList<EntityMapping>();
            Kind = AlertRuleKind.NRT;
        }

        /// <summary> Initializes a new instance of NrtAlertRuleTemplate. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="kind"> The kind of the alert rule. </param>
        /// <param name="alertRulesCreatedByTemplateCount"> the number of alert rules that were created by this template. </param>
        /// <param name="lastUpdatedDateUTC"> The last time that this alert rule template has been updated. </param>
        /// <param name="createdDateUTC"> The time that this alert rule template has been added. </param>
        /// <param name="description"> The description of the alert rule template. </param>
        /// <param name="displayName"> The display name for alert rule template. </param>
        /// <param name="requiredDataConnectors"> The required data sources for this template. </param>
        /// <param name="status"> The alert rule template status. </param>
        /// <param name="query"> The query that creates alerts for this rule. </param>
        /// <param name="severity"> The severity for alerts created by this alert rule. </param>
        /// <param name="tactics"> The tactics of the alert rule. </param>
        /// <param name="version"> The version of this template - in format &lt;a.b.c&gt;, where all are numbers. For example &lt;1.0.2&gt;. </param>
        /// <param name="customDetails"> Dictionary of string key-value pairs of columns to be attached to the alert. </param>
        /// <param name="entityMappings"> Array of the entity mappings of the alert rule. </param>
        /// <param name="alertDetailsOverride"> The alert details override settings. </param>
        internal NrtAlertRuleTemplate(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, AlertRuleKind kind, int? alertRulesCreatedByTemplateCount, DateTimeOffset? lastUpdatedDateUTC, DateTimeOffset? createdDateUTC, string description, string displayName, IList<AlertRuleTemplateDataSource> requiredDataConnectors, TemplateStatus? status, string query, AlertSeverity? severity, IList<AttackTactic> tactics, string version, IDictionary<string, string> customDetails, IList<EntityMapping> entityMappings, AlertDetailsOverride alertDetailsOverride) : base(id, name, type, systemData, kind)
        {
            AlertRulesCreatedByTemplateCount = alertRulesCreatedByTemplateCount;
            LastUpdatedDateUTC = lastUpdatedDateUTC;
            CreatedDateUTC = createdDateUTC;
            Description = description;
            DisplayName = displayName;
            RequiredDataConnectors = requiredDataConnectors;
            Status = status;
            Query = query;
            Severity = severity;
            Tactics = tactics;
            Version = version;
            CustomDetails = customDetails;
            EntityMappings = entityMappings;
            AlertDetailsOverride = alertDetailsOverride;
            Kind = kind;
        }

        /// <summary> the number of alert rules that were created by this template. </summary>
        public int? AlertRulesCreatedByTemplateCount { get; set; }
        /// <summary> The last time that this alert rule template has been updated. </summary>
        public DateTimeOffset? LastUpdatedDateUTC { get; }
        /// <summary> The time that this alert rule template has been added. </summary>
        public DateTimeOffset? CreatedDateUTC { get; }
        /// <summary> The description of the alert rule template. </summary>
        public string Description { get; set; }
        /// <summary> The display name for alert rule template. </summary>
        public string DisplayName { get; set; }
        /// <summary> The required data sources for this template. </summary>
        public IList<AlertRuleTemplateDataSource> RequiredDataConnectors { get; }
        /// <summary> The alert rule template status. </summary>
        public TemplateStatus? Status { get; set; }
        /// <summary> The query that creates alerts for this rule. </summary>
        public string Query { get; set; }
        /// <summary> The severity for alerts created by this alert rule. </summary>
        public AlertSeverity? Severity { get; set; }
        /// <summary> The tactics of the alert rule. </summary>
        public IList<AttackTactic> Tactics { get; }
        /// <summary> The version of this template - in format &lt;a.b.c&gt;, where all are numbers. For example &lt;1.0.2&gt;. </summary>
        public string Version { get; set; }
        /// <summary> Dictionary of string key-value pairs of columns to be attached to the alert. </summary>
        public IDictionary<string, string> CustomDetails { get; }
        /// <summary> Array of the entity mappings of the alert rule. </summary>
        public IList<EntityMapping> EntityMappings { get; }
        /// <summary> The alert details override settings. </summary>
        public AlertDetailsOverride AlertDetailsOverride { get; set; }
    }
}
