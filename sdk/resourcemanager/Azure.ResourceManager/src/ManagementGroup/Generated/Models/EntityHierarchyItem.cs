// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Management.Models
{
    /// <summary> The management group details for the hierarchy view. </summary>
    internal partial class EntityHierarchyItem : Resource
    {
        /// <summary> Initializes a new instance of EntityHierarchyItem. </summary>
        internal EntityHierarchyItem()
        {
            Children = new ChangeTrackingList<EntityHierarchyItem>();
        }

        /// <summary> The friendly name of the management group. </summary>
        public string DisplayName { get; }
        /// <summary> The users specific permissions to this item. </summary>
        public Permissions? Permissions { get; }
        /// <summary> The list of children. </summary>
        public IReadOnlyList<EntityHierarchyItem> Children { get; }
    }
}
