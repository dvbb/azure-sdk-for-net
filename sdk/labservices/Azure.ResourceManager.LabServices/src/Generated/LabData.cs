// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.LabServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LabServices
{
    /// <summary> A class representing the Lab data model. </summary>
    public partial class LabData : TrackedResource
    {
        /// <summary> Initializes a new instance of LabData. </summary>
        /// <param name="location"> The location. </param>
        public LabData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of LabData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the lab. </param>
        /// <param name="autoShutdownProfile"> The resource auto shutdown configuration for the lab. This controls whether actions are taken on resources that are sitting idle. </param>
        /// <param name="connectionProfile"> The connection profile for the lab. This controls settings such as web access to lab resources or whether RDP or SSH ports are open. </param>
        /// <param name="virtualMachineProfile"> The profile used for creating lab virtual machines. </param>
        /// <param name="securityProfile"> The lab security profile. </param>
        /// <param name="rosterProfile"> The lab user list management profile. </param>
        /// <param name="labPlanId"> The ID of the lab plan. Used during resource creation to provide defaults and acts as a permission container when creating a lab via labs.azure.com. Setting a labPlanId on an existing lab provides organization.. </param>
        /// <param name="title"> The title of the lab. </param>
        /// <param name="description"> The description of the lab. </param>
        /// <param name="provisioningState"> Current provisioning state of the lab. </param>
        /// <param name="networkProfile"> The network profile for the lab, typically applied via a lab plan. This profile cannot be modified once a lab has been created. </param>
        /// <param name="state"> The lab state. </param>
        internal LabData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, SystemData systemData, AutoShutdownProfile autoShutdownProfile, ConnectionProfile connectionProfile, VirtualMachineProfile virtualMachineProfile, SecurityProfile securityProfile, RosterProfile rosterProfile, string labPlanId, string title, string description, ProvisioningState? provisioningState, LabNetworkProfile networkProfile, LabState? state) : base(id, name, type, tags, location)
        {
            SystemData = systemData;
            AutoShutdownProfile = autoShutdownProfile;
            ConnectionProfile = connectionProfile;
            VirtualMachineProfile = virtualMachineProfile;
            SecurityProfile = securityProfile;
            RosterProfile = rosterProfile;
            LabPlanId = labPlanId;
            Title = title;
            Description = description;
            ProvisioningState = provisioningState;
            NetworkProfile = networkProfile;
            State = state;
        }

        /// <summary> Metadata pertaining to creation and last modification of the lab. </summary>
        public SystemData SystemData { get; }
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
        /// <summary> Current provisioning state of the lab. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The network profile for the lab, typically applied via a lab plan. This profile cannot be modified once a lab has been created. </summary>
        public LabNetworkProfile NetworkProfile { get; set; }
        /// <summary> The lab state. </summary>
        public LabState? State { get; }
    }
}
