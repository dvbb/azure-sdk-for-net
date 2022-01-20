// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Properties of group update. </summary>
    public partial class UpdateGroupBody
    {
        /// <summary> Initializes a new instance of UpdateGroupBody. </summary>
        public UpdateGroupBody()
        {
        }

        /// <summary> For optimistic concurrency control. </summary>
        public string ETag { get; set; }
        /// <summary> Properties of the group. </summary>
        public GroupBodyProperties Properties { get; set; }
    }
}
