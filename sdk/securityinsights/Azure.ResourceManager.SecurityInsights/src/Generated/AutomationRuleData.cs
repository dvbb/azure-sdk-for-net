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
    /// <summary> A class representing the AutomationRule data model. </summary>
    public partial class AutomationRuleData : ResourceWithEtag
    {
        /// <summary> Initializes a new instance of AutomationRuleData. </summary>
        public AutomationRuleData()
        {
            Actions = new ChangeTrackingList<AutomationRuleAction>();
        }

        /// <summary> Initializes a new instance of AutomationRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="displayName"> The display name of the automation  rule. </param>
        /// <param name="order"> The order of execution of the automation rule. </param>
        /// <param name="triggeringLogic"> The triggering logic of the automation rule. </param>
        /// <param name="actions"> The actions to execute when the automation rule is triggered. </param>
        /// <param name="createdTimeUtc"> The time the automation rule was created. </param>
        /// <param name="lastModifiedTimeUtc"> The last time the automation rule was updated. </param>
        /// <param name="createdBy"> Describes the client that created the automation rule. </param>
        /// <param name="lastModifiedBy"> Describes the client that last updated the automation rule. </param>
        internal AutomationRuleData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string etag, string displayName, int? order, AutomationRuleTriggeringLogic triggeringLogic, IList<AutomationRuleAction> actions, DateTimeOffset? createdTimeUtc, DateTimeOffset? lastModifiedTimeUtc, ClientInfo createdBy, ClientInfo lastModifiedBy) : base(id, name, type, systemData, etag)
        {
            DisplayName = displayName;
            Order = order;
            TriggeringLogic = triggeringLogic;
            Actions = actions;
            CreatedTimeUtc = createdTimeUtc;
            LastModifiedTimeUtc = lastModifiedTimeUtc;
            CreatedBy = createdBy;
            LastModifiedBy = lastModifiedBy;
        }

        /// <summary> The display name of the automation  rule. </summary>
        public string DisplayName { get; set; }
        /// <summary> The order of execution of the automation rule. </summary>
        public int? Order { get; set; }
        /// <summary> The triggering logic of the automation rule. </summary>
        public AutomationRuleTriggeringLogic TriggeringLogic { get; set; }
        /// <summary> The actions to execute when the automation rule is triggered. </summary>
        public IList<AutomationRuleAction> Actions { get; }
        /// <summary> The time the automation rule was created. </summary>
        public DateTimeOffset? CreatedTimeUtc { get; }
        /// <summary> The last time the automation rule was updated. </summary>
        public DateTimeOffset? LastModifiedTimeUtc { get; }
        /// <summary> Describes the client that created the automation rule. </summary>
        public ClientInfo CreatedBy { get; }
        /// <summary> Describes the client that last updated the automation rule. </summary>
        public ClientInfo LastModifiedBy { get; }
    }
}
