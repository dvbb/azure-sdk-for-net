// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logz.Models
{
    /// <summary> Response for list of user&apos;s role for Logz.io account. </summary>
    internal partial class UserRoleListResponse
    {
        /// <summary> Initializes a new instance of UserRoleListResponse. </summary>
        internal UserRoleListResponse()
        {
            Value = new ChangeTrackingList<UserRoleResponse>();
        }

        /// <summary> Initializes a new instance of UserRoleListResponse. </summary>
        /// <param name="value"> List of user roles for Logz.io account. </param>
        /// <param name="nextLink"> Link to the next set of results, if any. </param>
        internal UserRoleListResponse(IReadOnlyList<UserRoleResponse> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of user roles for Logz.io account. </summary>
        public IReadOnlyList<UserRoleResponse> Value { get; }
        /// <summary> Link to the next set of results, if any. </summary>
        public string NextLink { get; }
    }
}
