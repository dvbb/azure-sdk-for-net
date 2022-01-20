// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> MicrosoftSecurityIncidentCreation rule template properties. </summary>
    internal partial class MicrosoftSecurityIncidentCreationAlertRuleTemplateProperties : AlertRuleTemplatePropertiesBase
    {
        /// <summary> Initializes a new instance of MicrosoftSecurityIncidentCreationAlertRuleTemplateProperties. </summary>
        /// <param name="productFilter"> The alerts&apos; productName on which the cases will be generated. </param>
        internal MicrosoftSecurityIncidentCreationAlertRuleTemplateProperties(MicrosoftSecurityProductName productFilter)
        {
            DisplayNamesFilter = new ChangeTrackingList<string>();
            DisplayNamesExcludeFilter = new ChangeTrackingList<string>();
            ProductFilter = productFilter;
            SeveritiesFilter = new ChangeTrackingList<AlertSeverity>();
        }

        /// <summary> the alerts&apos; displayNames on which the cases will be generated. </summary>
        public IReadOnlyList<string> DisplayNamesFilter { get; }
        /// <summary> the alerts&apos; displayNames on which the cases will not be generated. </summary>
        public IReadOnlyList<string> DisplayNamesExcludeFilter { get; }
        /// <summary> The alerts&apos; productName on which the cases will be generated. </summary>
        public MicrosoftSecurityProductName ProductFilter { get; }
        /// <summary> the alerts&apos; severities on which the cases will be generated. </summary>
        public IReadOnlyList<AlertSeverity> SeveritiesFilter { get; }
    }
}
