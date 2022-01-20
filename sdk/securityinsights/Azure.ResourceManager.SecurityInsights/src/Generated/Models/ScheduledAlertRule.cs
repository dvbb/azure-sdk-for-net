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
    /// <summary> Represents scheduled alert rule. </summary>
    public partial class ScheduledAlertRule : AlertRuleData
    {
        /// <summary> Initializes a new instance of ScheduledAlertRule. </summary>
        public ScheduledAlertRule()
        {
            Tactics = new ChangeTrackingList<AttackTactic>();
            CustomDetails = new ChangeTrackingDictionary<string, string>();
            EntityMappings = new ChangeTrackingList<EntityMapping>();
            Kind = AlertRuleKind.Scheduled;
        }

        /// <summary> Initializes a new instance of ScheduledAlertRule. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="kind"> The kind of the alert rule. </param>
        /// <param name="queryFrequency"> The frequency (in ISO 8601 duration format) for this alert rule to run. </param>
        /// <param name="queryPeriod"> The period (in ISO 8601 duration format) that this alert rule looks at. </param>
        /// <param name="triggerOperator"> The operation against the threshold that triggers alert rule. </param>
        /// <param name="triggerThreshold"> The threshold triggers this alert rule. </param>
        /// <param name="eventGroupingSettings"> The event grouping settings. </param>
        /// <param name="alertRuleTemplateName"> The Name of the alert rule template used to create this rule. </param>
        /// <param name="templateVersion"> The version of the alert rule template used to create this rule - in format &lt;a.b.c&gt;, where all are numbers, for example 0 &lt;1.0.2&gt;. </param>
        /// <param name="description"> The description of the alert rule. </param>
        /// <param name="query"> The query that creates alerts for this rule. </param>
        /// <param name="displayName"> The display name for alerts created by this alert rule. </param>
        /// <param name="enabled"> Determines whether this alert rule is enabled or disabled. </param>
        /// <param name="lastModifiedUtc"> The last time that this alert rule has been modified. </param>
        /// <param name="suppressionDuration"> The suppression (in ISO 8601 duration format) to wait since last time this alert rule been triggered. </param>
        /// <param name="suppressionEnabled"> Determines whether the suppression for this alert rule is enabled or disabled. </param>
        /// <param name="severity"> The severity for alerts created by this alert rule. </param>
        /// <param name="tactics"> The tactics of the alert rule. </param>
        /// <param name="incidentConfiguration"> The settings of the incidents that created from alerts triggered by this analytics rule. </param>
        /// <param name="customDetails"> Dictionary of string key-value pairs of columns to be attached to the alert. </param>
        /// <param name="entityMappings"> Array of the entity mappings of the alert rule. </param>
        /// <param name="alertDetailsOverride"> The alert details override settings. </param>
        internal ScheduledAlertRule(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string etag, AlertRuleKind kind, TimeSpan? queryFrequency, TimeSpan? queryPeriod, TriggerOperator? triggerOperator, int? triggerThreshold, EventGroupingSettings eventGroupingSettings, string alertRuleTemplateName, string templateVersion, string description, string query, string displayName, bool? enabled, DateTimeOffset? lastModifiedUtc, TimeSpan? suppressionDuration, bool? suppressionEnabled, AlertSeverity? severity, IList<AttackTactic> tactics, IncidentConfiguration incidentConfiguration, IDictionary<string, string> customDetails, IList<EntityMapping> entityMappings, AlertDetailsOverride alertDetailsOverride) : base(id, name, type, systemData, etag, kind)
        {
            QueryFrequency = queryFrequency;
            QueryPeriod = queryPeriod;
            TriggerOperator = triggerOperator;
            TriggerThreshold = triggerThreshold;
            EventGroupingSettings = eventGroupingSettings;
            AlertRuleTemplateName = alertRuleTemplateName;
            TemplateVersion = templateVersion;
            Description = description;
            Query = query;
            DisplayName = displayName;
            Enabled = enabled;
            LastModifiedUtc = lastModifiedUtc;
            SuppressionDuration = suppressionDuration;
            SuppressionEnabled = suppressionEnabled;
            Severity = severity;
            Tactics = tactics;
            IncidentConfiguration = incidentConfiguration;
            CustomDetails = customDetails;
            EntityMappings = entityMappings;
            AlertDetailsOverride = alertDetailsOverride;
            Kind = kind;
        }

        /// <summary> The frequency (in ISO 8601 duration format) for this alert rule to run. </summary>
        public TimeSpan? QueryFrequency { get; set; }
        /// <summary> The period (in ISO 8601 duration format) that this alert rule looks at. </summary>
        public TimeSpan? QueryPeriod { get; set; }
        /// <summary> The operation against the threshold that triggers alert rule. </summary>
        public TriggerOperator? TriggerOperator { get; set; }
        /// <summary> The threshold triggers this alert rule. </summary>
        public int? TriggerThreshold { get; set; }
        /// <summary> The event grouping settings. </summary>
        public EventGroupingSettings EventGroupingSettings { get; set; }
        /// <summary> The Name of the alert rule template used to create this rule. </summary>
        public string AlertRuleTemplateName { get; set; }
        /// <summary> The version of the alert rule template used to create this rule - in format &lt;a.b.c&gt;, where all are numbers, for example 0 &lt;1.0.2&gt;. </summary>
        public string TemplateVersion { get; set; }
        /// <summary> The description of the alert rule. </summary>
        public string Description { get; set; }
        /// <summary> The query that creates alerts for this rule. </summary>
        public string Query { get; set; }
        /// <summary> The display name for alerts created by this alert rule. </summary>
        public string DisplayName { get; set; }
        /// <summary> Determines whether this alert rule is enabled or disabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The last time that this alert rule has been modified. </summary>
        public DateTimeOffset? LastModifiedUtc { get; }
        /// <summary> The suppression (in ISO 8601 duration format) to wait since last time this alert rule been triggered. </summary>
        public TimeSpan? SuppressionDuration { get; set; }
        /// <summary> Determines whether the suppression for this alert rule is enabled or disabled. </summary>
        public bool? SuppressionEnabled { get; set; }
        /// <summary> The severity for alerts created by this alert rule. </summary>
        public AlertSeverity? Severity { get; set; }
        /// <summary> The tactics of the alert rule. </summary>
        public IList<AttackTactic> Tactics { get; }
        /// <summary> The settings of the incidents that created from alerts triggered by this analytics rule. </summary>
        public IncidentConfiguration IncidentConfiguration { get; set; }
        /// <summary> Dictionary of string key-value pairs of columns to be attached to the alert. </summary>
        public IDictionary<string, string> CustomDetails { get; }
        /// <summary> Array of the entity mappings of the alert rule. </summary>
        public IList<EntityMapping> EntityMappings { get; }
        /// <summary> The alert details override settings. </summary>
        public AlertDetailsOverride AlertDetailsOverride { get; set; }
    }
}
