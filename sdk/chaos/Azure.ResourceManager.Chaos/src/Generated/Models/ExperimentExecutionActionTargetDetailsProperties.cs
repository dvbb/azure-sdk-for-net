// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents the Experiment action target details properties model. </summary>
    public partial class ExperimentExecutionActionTargetDetailsProperties
    {
        /// <summary> Initializes a new instance of ExperimentExecutionActionTargetDetailsProperties. </summary>
        internal ExperimentExecutionActionTargetDetailsProperties()
        {
        }

        /// <summary> Initializes a new instance of ExperimentExecutionActionTargetDetailsProperties. </summary>
        /// <param name="status"> The status of the execution. </param>
        /// <param name="target"> The target for the action. </param>
        /// <param name="failedDateUtc"> String that represents the failed date time. </param>
        /// <param name="completedDateUtc"> String that represents the completed date time. </param>
        /// <param name="error"> The error of the action. </param>
        internal ExperimentExecutionActionTargetDetailsProperties(string status, string target, DateTimeOffset? failedDateUtc, DateTimeOffset? completedDateUtc, ExperimentExecutionActionTargetDetailsError error)
        {
            Status = status;
            Target = target;
            FailedDateUtc = failedDateUtc;
            CompletedDateUtc = completedDateUtc;
            Error = error;
        }

        /// <summary> The status of the execution. </summary>
        public string Status { get; }
        /// <summary> The target for the action. </summary>
        public string Target { get; }
        /// <summary> String that represents the failed date time. </summary>
        public DateTimeOffset? FailedDateUtc { get; }
        /// <summary> String that represents the completed date time. </summary>
        public DateTimeOffset? CompletedDateUtc { get; }
        /// <summary> The error of the action. </summary>
        public ExperimentExecutionActionTargetDetailsError Error { get; }
    }
}
