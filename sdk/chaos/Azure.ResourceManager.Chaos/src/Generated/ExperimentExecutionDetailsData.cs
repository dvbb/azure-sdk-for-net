// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Chaos.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Chaos
{
    /// <summary> A class representing the ExperimentExecutionDetails data model. </summary>
    public partial class ExperimentExecutionDetailsData : Resource
    {
        /// <summary> Initializes a new instance of ExperimentExecutionDetailsData. </summary>
        internal ExperimentExecutionDetailsData()
        {
        }

        /// <summary> Initializes a new instance of ExperimentExecutionDetailsData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="experimentId"> The id of the experiment. </param>
        /// <param name="status"> The value of the status of the experiment execution. </param>
        /// <param name="failureReason"> The reason why the execution failed. </param>
        /// <param name="createdDateUtc"> String that represents the created date time. </param>
        /// <param name="lastActionDateUtc"> String that represents the last action date time. </param>
        /// <param name="startDateUtc"> String that represents the start date time. </param>
        /// <param name="stopDateUtc"> String that represents the stop date time. </param>
        /// <param name="runInformation"> The information of the experiment run. </param>
        internal ExperimentExecutionDetailsData(ResourceIdentifier id, string name, ResourceType type, string experimentId, string status, string failureReason, DateTimeOffset? createdDateUtc, DateTimeOffset? lastActionDateUtc, DateTimeOffset? startDateUtc, DateTimeOffset? stopDateUtc, ExperimentExecutionDetailsPropertiesRunInformation runInformation) : base(id, name, type)
        {
            ExperimentId = experimentId;
            Status = status;
            FailureReason = failureReason;
            CreatedDateUtc = createdDateUtc;
            LastActionDateUtc = lastActionDateUtc;
            StartDateUtc = startDateUtc;
            StopDateUtc = stopDateUtc;
            RunInformation = runInformation;
        }

        /// <summary> The id of the experiment. </summary>
        public string ExperimentId { get; }
        /// <summary> The value of the status of the experiment execution. </summary>
        public string Status { get; }
        /// <summary> The reason why the execution failed. </summary>
        public string FailureReason { get; }
        /// <summary> String that represents the created date time. </summary>
        public DateTimeOffset? CreatedDateUtc { get; }
        /// <summary> String that represents the last action date time. </summary>
        public DateTimeOffset? LastActionDateUtc { get; }
        /// <summary> String that represents the start date time. </summary>
        public DateTimeOffset? StartDateUtc { get; }
        /// <summary> String that represents the stop date time. </summary>
        public DateTimeOffset? StopDateUtc { get; }
        /// <summary> The information of the experiment run. </summary>
        public ExperimentExecutionDetailsPropertiesRunInformation RunInformation { get; }
    }
}
