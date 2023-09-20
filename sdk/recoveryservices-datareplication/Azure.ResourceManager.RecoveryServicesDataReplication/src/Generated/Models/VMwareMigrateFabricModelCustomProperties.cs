// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> VMware migrate fabric model custom properties. </summary>
    public partial class VMwareMigrateFabricModelCustomProperties : FabricModelCustomProperties
    {
        /// <summary> Initializes a new instance of VMwareMigrateFabricModelCustomProperties. </summary>
        /// <param name="vMwareSiteId"> Gets or sets the ARM Id of the VMware site. </param>
        /// <param name="migrationSolutionId"> Gets or sets the ARM Id of the migration solution. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vMwareSiteId"/> or <paramref name="migrationSolutionId"/> is null. </exception>
        public VMwareMigrateFabricModelCustomProperties(ResourceIdentifier vMwareSiteId, ResourceIdentifier migrationSolutionId)
        {
            Argument.AssertNotNull(vMwareSiteId, nameof(vMwareSiteId));
            Argument.AssertNotNull(migrationSolutionId, nameof(migrationSolutionId));

            VMwareSiteId = vMwareSiteId;
            MigrationSolutionId = migrationSolutionId;
            InstanceType = "VMwareMigrate";
        }

        /// <summary> Initializes a new instance of VMwareMigrateFabricModelCustomProperties. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        /// <param name="vMwareSiteId"> Gets or sets the ARM Id of the VMware site. </param>
        /// <param name="migrationSolutionId"> Gets or sets the ARM Id of the migration solution. </param>
        internal VMwareMigrateFabricModelCustomProperties(string instanceType, ResourceIdentifier vMwareSiteId, ResourceIdentifier migrationSolutionId) : base(instanceType)
        {
            VMwareSiteId = vMwareSiteId;
            MigrationSolutionId = migrationSolutionId;
            InstanceType = instanceType ?? "VMwareMigrate";
        }

        /// <summary> Gets or sets the ARM Id of the VMware site. </summary>
        public ResourceIdentifier VMwareSiteId { get; set; }
        /// <summary> Gets or sets the ARM Id of the migration solution. </summary>
        public ResourceIdentifier MigrationSolutionId { get; set; }
    }
}
