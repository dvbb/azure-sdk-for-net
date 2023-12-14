// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the SqlServerJobStep data model.
    /// A job step.
    /// </summary>
    public partial class SqlServerJobStepData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SqlServerJobStepData"/>. </summary>
        public SqlServerJobStepData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlServerJobStepData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="stepId"> The job step's index within the job. If not specified when creating the job step, it will be created as the last step. If not specified when updating the job step, the step id is not modified. </param>
        /// <param name="targetGroup"> The resource ID of the target group that the job step will be executed on. </param>
        /// <param name="credential"> The resource ID of the job credential that will be used to connect to the targets. </param>
        /// <param name="action"> The action payload of the job step. </param>
        /// <param name="output"> Output destination properties of the job step. </param>
        /// <param name="executionOptions"> Execution options for the job step. </param>
        internal SqlServerJobStepData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? stepId, string targetGroup, string credential, JobStepAction action, JobStepOutput output, JobStepExecutionOptions executionOptions) : base(id, name, resourceType, systemData)
        {
            StepId = stepId;
            TargetGroup = targetGroup;
            Credential = credential;
            Action = action;
            Output = output;
            ExecutionOptions = executionOptions;
        }

        /// <summary> The job step's index within the job. If not specified when creating the job step, it will be created as the last step. If not specified when updating the job step, the step id is not modified. </summary>
        public int? StepId { get; set; }
        /// <summary> The resource ID of the target group that the job step will be executed on. </summary>
        public string TargetGroup { get; set; }
        /// <summary> The resource ID of the job credential that will be used to connect to the targets. </summary>
        public string Credential { get; set; }
        /// <summary> The action payload of the job step. </summary>
        public JobStepAction Action { get; set; }
        /// <summary> Output destination properties of the job step. </summary>
        public JobStepOutput Output { get; set; }
        /// <summary> Execution options for the job step. </summary>
        public JobStepExecutionOptions ExecutionOptions { get; set; }
    }
}
