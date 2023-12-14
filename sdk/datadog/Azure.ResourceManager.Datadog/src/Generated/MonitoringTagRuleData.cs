// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Datadog.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Datadog
{
    /// <summary>
    /// A class representing the MonitoringTagRule data model.
    /// Capture logs and metrics of Azure resources based on ARM tags.
    /// </summary>
    public partial class MonitoringTagRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="MonitoringTagRuleData"/>. </summary>
        public MonitoringTagRuleData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MonitoringTagRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Definition of the properties for a TagRules resource. </param>
        internal MonitoringTagRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MonitoringTagRulesProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Definition of the properties for a TagRules resource. </summary>
        public MonitoringTagRulesProperties Properties { get; set; }
    }
}
