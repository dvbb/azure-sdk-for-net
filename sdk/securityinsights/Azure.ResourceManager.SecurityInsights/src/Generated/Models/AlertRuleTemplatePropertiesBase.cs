// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Base alert rule template property bag. </summary>
    internal partial class AlertRuleTemplatePropertiesBase
    {
        /// <summary> Initializes a new instance of AlertRuleTemplatePropertiesBase. </summary>
        internal AlertRuleTemplatePropertiesBase()
        {
            RequiredDataConnectors = new ChangeTrackingList<AlertRuleTemplateDataSource>();
        }

        /// <summary> the number of alert rules that were created by this template. </summary>
        public int? AlertRulesCreatedByTemplateCount { get; }
        /// <summary> The last time that this alert rule template has been updated. </summary>
        public DateTimeOffset? LastUpdatedDateUTC { get; }
        /// <summary> The time that this alert rule template has been added. </summary>
        public DateTimeOffset? CreatedDateUTC { get; }
        /// <summary> The description of the alert rule template. </summary>
        public string Description { get; }
        /// <summary> The display name for alert rule template. </summary>
        public string DisplayName { get; }
        /// <summary> The required data sources for this template. </summary>
        public IReadOnlyList<AlertRuleTemplateDataSource> RequiredDataConnectors { get; }
        /// <summary> The alert rule template status. </summary>
        public TemplateStatus? Status { get; }
    }
}
