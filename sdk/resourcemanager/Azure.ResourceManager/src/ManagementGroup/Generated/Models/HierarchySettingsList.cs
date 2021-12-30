// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Management.Models
{
    /// <summary> Lists all hierarchy settings. </summary>
    public partial class HierarchySettingsList
    {
        /// <summary> Initializes a new instance of HierarchySettingsList. </summary>
        internal HierarchySettingsList()
        {
            Value = new ChangeTrackingList<HierarchySettingsInfo>();
        }

        /// <summary> Initializes a new instance of HierarchySettingsList. </summary>
        /// <param name="value"> The list of hierarchy settings. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal HierarchySettingsList(IReadOnlyList<HierarchySettingsInfo> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of hierarchy settings. </summary>
        public IReadOnlyList<HierarchySettingsInfo> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
