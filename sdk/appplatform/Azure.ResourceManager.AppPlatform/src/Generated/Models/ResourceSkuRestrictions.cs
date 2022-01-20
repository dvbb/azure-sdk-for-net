// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Restrictions where the SKU cannot be used. </summary>
    public partial class ResourceSkuRestrictions
    {
        /// <summary> Initializes a new instance of ResourceSkuRestrictions. </summary>
        internal ResourceSkuRestrictions()
        {
            Values = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ResourceSkuRestrictions. </summary>
        /// <param name="type"> Gets the type of restrictions. Possible values include: &apos;Location&apos;, &apos;Zone&apos;. </param>
        /// <param name="values">
        /// Gets the value of restrictions. If the restriction type is set to
        /// location. This would be different locations where the SKU is restricted.
        /// </param>
        /// <param name="restrictionInfo"> Gets the information about the restriction where the SKU cannot be used. </param>
        /// <param name="reasonCode"> Gets the reason for restriction. Possible values include: &apos;QuotaId&apos;, &apos;NotAvailableForSubscription&apos;. </param>
        internal ResourceSkuRestrictions(ResourceSkuRestrictionsType? type, IReadOnlyList<string> values, ResourceSkuRestrictionInfo restrictionInfo, ResourceSkuRestrictionsReasonCode? reasonCode)
        {
            Type = type;
            Values = values;
            RestrictionInfo = restrictionInfo;
            ReasonCode = reasonCode;
        }

        /// <summary> Gets the type of restrictions. Possible values include: &apos;Location&apos;, &apos;Zone&apos;. </summary>
        public ResourceSkuRestrictionsType? Type { get; }
        /// <summary>
        /// Gets the value of restrictions. If the restriction type is set to
        /// location. This would be different locations where the SKU is restricted.
        /// </summary>
        public IReadOnlyList<string> Values { get; }
        /// <summary> Gets the information about the restriction where the SKU cannot be used. </summary>
        public ResourceSkuRestrictionInfo RestrictionInfo { get; }
        /// <summary> Gets the reason for restriction. Possible values include: &apos;QuotaId&apos;, &apos;NotAvailableForSubscription&apos;. </summary>
        public ResourceSkuRestrictionsReasonCode? ReasonCode { get; }
    }
}
