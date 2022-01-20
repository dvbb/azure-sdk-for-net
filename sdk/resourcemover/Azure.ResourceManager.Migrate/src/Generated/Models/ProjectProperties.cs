// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Migrate;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> Properties of a project. </summary>
    public partial class ProjectProperties
    {
        /// <summary> Initializes a new instance of ProjectProperties. </summary>
        public ProjectProperties()
        {
            PrivateEndpointConnections = new ChangeTrackingList<PrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of ProjectProperties. </summary>
        /// <param name="createdTimestamp"> Time when this project was created. Date-Time represented in ISO-8601 format. </param>
        /// <param name="updatedTimestamp"> Time when this project was last updated. Date-Time represented in ISO-8601 format. </param>
        /// <param name="serviceEndpoint"> Endpoint at which the collector agent can call agent REST API. </param>
        /// <param name="assessmentSolutionId"> Assessment solution ARM id tracked by Microsoft.Migrate/migrateProjects. </param>
        /// <param name="projectStatus"> Assessment project status. </param>
        /// <param name="customerWorkspaceId"> The ARM id of service map workspace created by customer. </param>
        /// <param name="customerWorkspaceLocation"> Location of service map workspace created by customer. </param>
        /// <param name="numberOfGroups"> Number of groups created in the project. </param>
        /// <param name="numberOfMachines"> Number of machines in the project. </param>
        /// <param name="numberOfAssessments"> Number of assessments created in the project. </param>
        /// <param name="lastAssessmentTimestamp"> Time when last assessment was created. Date-Time represented in ISO-8601 format. This value will be null until assessment is created. </param>
        /// <param name="publicNetworkAccess"> This value can be set to &apos;enabled&apos; to avoid breaking changes on existing customer resources and templates. If set to &apos;disabled&apos;, traffic over public interface is not allowed, and private endpoint connections would be the exclusive access method. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections to the project. </param>
        /// <param name="customerStorageAccountArmId"> The ARM id of the storage account used for interactions when public access is disabled. </param>
        /// <param name="provisioningState"> Provisioning state of the project. </param>
        internal ProjectProperties(DateTimeOffset? createdTimestamp, DateTimeOffset? updatedTimestamp, string serviceEndpoint, string assessmentSolutionId, ProjectStatus? projectStatus, string customerWorkspaceId, string customerWorkspaceLocation, int? numberOfGroups, int? numberOfMachines, int? numberOfAssessments, DateTimeOffset? lastAssessmentTimestamp, string publicNetworkAccess, IReadOnlyList<PrivateEndpointConnectionData> privateEndpointConnections, string customerStorageAccountArmId, ProvisioningState? provisioningState)
        {
            CreatedTimestamp = createdTimestamp;
            UpdatedTimestamp = updatedTimestamp;
            ServiceEndpoint = serviceEndpoint;
            AssessmentSolutionId = assessmentSolutionId;
            ProjectStatus = projectStatus;
            CustomerWorkspaceId = customerWorkspaceId;
            CustomerWorkspaceLocation = customerWorkspaceLocation;
            NumberOfGroups = numberOfGroups;
            NumberOfMachines = numberOfMachines;
            NumberOfAssessments = numberOfAssessments;
            LastAssessmentTimestamp = lastAssessmentTimestamp;
            PublicNetworkAccess = publicNetworkAccess;
            PrivateEndpointConnections = privateEndpointConnections;
            CustomerStorageAccountArmId = customerStorageAccountArmId;
            ProvisioningState = provisioningState;
        }

        /// <summary> Time when this project was created. Date-Time represented in ISO-8601 format. </summary>
        public DateTimeOffset? CreatedTimestamp { get; }
        /// <summary> Time when this project was last updated. Date-Time represented in ISO-8601 format. </summary>
        public DateTimeOffset? UpdatedTimestamp { get; }
        /// <summary> Endpoint at which the collector agent can call agent REST API. </summary>
        public string ServiceEndpoint { get; }
        /// <summary> Assessment solution ARM id tracked by Microsoft.Migrate/migrateProjects. </summary>
        public string AssessmentSolutionId { get; set; }
        /// <summary> Assessment project status. </summary>
        public ProjectStatus? ProjectStatus { get; set; }
        /// <summary> The ARM id of service map workspace created by customer. </summary>
        public string CustomerWorkspaceId { get; set; }
        /// <summary> Location of service map workspace created by customer. </summary>
        public string CustomerWorkspaceLocation { get; set; }
        /// <summary> Number of groups created in the project. </summary>
        public int? NumberOfGroups { get; }
        /// <summary> Number of machines in the project. </summary>
        public int? NumberOfMachines { get; }
        /// <summary> Number of assessments created in the project. </summary>
        public int? NumberOfAssessments { get; }
        /// <summary> Time when last assessment was created. Date-Time represented in ISO-8601 format. This value will be null until assessment is created. </summary>
        public DateTimeOffset? LastAssessmentTimestamp { get; }
        /// <summary> This value can be set to &apos;enabled&apos; to avoid breaking changes on existing customer resources and templates. If set to &apos;disabled&apos;, traffic over public interface is not allowed, and private endpoint connections would be the exclusive access method. </summary>
        public string PublicNetworkAccess { get; set; }
        /// <summary> The list of private endpoint connections to the project. </summary>
        public IReadOnlyList<PrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> The ARM id of the storage account used for interactions when public access is disabled. </summary>
        public string CustomerStorageAccountArmId { get; set; }
        /// <summary> Provisioning state of the project. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
