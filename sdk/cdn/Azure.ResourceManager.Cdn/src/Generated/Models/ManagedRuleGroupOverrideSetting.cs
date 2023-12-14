// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines a managed rule group override setting. </summary>
    public partial class ManagedRuleGroupOverrideSetting
    {
        /// <summary> Initializes a new instance of <see cref="ManagedRuleGroupOverrideSetting"/>. </summary>
        /// <param name="ruleGroupName"> Describes the managed rule group within the rule set to override. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleGroupName"/> is null. </exception>
        public ManagedRuleGroupOverrideSetting(string ruleGroupName)
        {
            Argument.AssertNotNull(ruleGroupName, nameof(ruleGroupName));

            RuleGroupName = ruleGroupName;
            Rules = new ChangeTrackingList<ManagedRuleOverrideSetting>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRuleGroupOverrideSetting"/>. </summary>
        /// <param name="ruleGroupName"> Describes the managed rule group within the rule set to override. </param>
        /// <param name="rules"> List of rules that will be disabled. If none specified, all rules in the group will be disabled. </param>
        internal ManagedRuleGroupOverrideSetting(string ruleGroupName, IList<ManagedRuleOverrideSetting> rules)
        {
            RuleGroupName = ruleGroupName;
            Rules = rules;
        }

        /// <summary> Describes the managed rule group within the rule set to override. </summary>
        public string RuleGroupName { get; set; }
        /// <summary> List of rules that will be disabled. If none specified, all rules in the group will be disabled. </summary>
        public IList<ManagedRuleOverrideSetting> Rules { get; }
    }
}
