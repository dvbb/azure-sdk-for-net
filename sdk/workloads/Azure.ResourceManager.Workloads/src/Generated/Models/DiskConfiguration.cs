// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The Disk Configuration Details. </summary>
    internal partial class DiskConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="DiskConfiguration"/>. </summary>
        public DiskConfiguration()
        {
            DiskVolumeConfigurations = new ChangeTrackingDictionary<string, DiskVolumeConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="DiskConfiguration"/>. </summary>
        /// <param name="diskVolumeConfigurations"> The disk configuration for the db volume. For HANA, Required volumes are: ['hana/data', 'hana/log', hana/shared', 'usr/sap', 'os'], Optional volume : ['backup']. </param>
        internal DiskConfiguration(IDictionary<string, DiskVolumeConfiguration> diskVolumeConfigurations)
        {
            DiskVolumeConfigurations = diskVolumeConfigurations;
        }

        /// <summary> The disk configuration for the db volume. For HANA, Required volumes are: ['hana/data', 'hana/log', hana/shared', 'usr/sap', 'os'], Optional volume : ['backup']. </summary>
        public IDictionary<string, DiskVolumeConfiguration> DiskVolumeConfigurations { get; }
    }
}
