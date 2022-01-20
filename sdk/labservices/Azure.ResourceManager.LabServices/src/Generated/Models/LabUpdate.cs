// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> The lab resource for updates. </summary>
    public partial class LabUpdate : TrackedResourceUpdate
    {
        /// <summary> Initializes a new instance of LabUpdate. </summary>
        public LabUpdate()
        {
        }

        /// <summary> The resource auto shutdown configuration for the lab. This controls whether actions are taken on resources that are sitting idle. </summary>
        public AutoShutdownProfile AutoShutdownProfile { get; set; }
        /// <summary> The connection profile for the lab. This controls settings such as web access to lab resources or whether RDP or SSH ports are open. </summary>
        public ConnectionProfile ConnectionProfile { get; set; }
        /// <summary> The profile used for creating lab virtual machines. </summary>
        public VirtualMachineProfile VirtualMachineProfile { get; set; }
        /// <summary> The lab security profile. </summary>
        public SecurityProfile SecurityProfile { get; set; }
        /// <summary> The lab user list management profile. </summary>
        public RosterProfile RosterProfile { get; set; }
        /// <summary> The ID of the lab plan. Used during resource creation to provide defaults and acts as a permission container when creating a lab via labs.azure.com. Setting a labPlanId on an existing lab provides organization.. </summary>
        public string LabPlanId { get; set; }
        /// <summary> The title of the lab. </summary>
        public string Title { get; set; }
        /// <summary> The description of the lab. </summary>
        public string Description { get; set; }
    }
}
