// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Object that includes an array of API portal custom domain resources and a possible link for next set. </summary>
    internal partial class ApiPortalCustomDomainResourceCollection
    {
        /// <summary> Initializes a new instance of ApiPortalCustomDomainResourceCollection. </summary>
        internal ApiPortalCustomDomainResourceCollection()
        {
            Value = new ChangeTrackingList<ApiPortalCustomDomainResourceData>();
        }

        /// <summary> Initializes a new instance of ApiPortalCustomDomainResourceCollection. </summary>
        /// <param name="value"> Collection of API portal custom domain resources. </param>
        /// <param name="nextLink">
        /// URL client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </param>
        internal ApiPortalCustomDomainResourceCollection(IReadOnlyList<ApiPortalCustomDomainResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of API portal custom domain resources. </summary>
        public IReadOnlyList<ApiPortalCustomDomainResourceData> Value { get; }
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It&apos;s null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
