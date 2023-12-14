// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The CustomMonitoringSignal. </summary>
    public partial class CustomMonitoringSignal : MonitoringSignalBase
    {
        /// <summary> Initializes a new instance of <see cref="CustomMonitoringSignal"/>. </summary>
        /// <param name="componentId"> [Required] ARM resource ID of the component resource used to calculate the custom metrics. </param>
        /// <param name="metricThresholds"> [Required] A list of metrics to calculate and their associated thresholds. </param>
        /// <param name="workspaceConnection"> [Required] A list of metrics to calculate and their associated thresholds. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="componentId"/>, <paramref name="metricThresholds"/> or <paramref name="workspaceConnection"/> is null. </exception>
        public CustomMonitoringSignal(string componentId, IEnumerable<CustomMetricThreshold> metricThresholds, MonitoringWorkspaceConnection workspaceConnection)
        {
            Argument.AssertNotNull(componentId, nameof(componentId));
            Argument.AssertNotNull(metricThresholds, nameof(metricThresholds));
            Argument.AssertNotNull(workspaceConnection, nameof(workspaceConnection));

            ComponentId = componentId;
            InputAssets = new ChangeTrackingDictionary<string, MonitoringInputDataBase>();
            Inputs = new ChangeTrackingDictionary<string, MachineLearningJobInput>();
            MetricThresholds = metricThresholds.ToList();
            WorkspaceConnection = workspaceConnection;
            SignalType = MonitoringSignalType.Custom;
        }

        /// <summary> Initializes a new instance of <see cref="CustomMonitoringSignal"/>. </summary>
        /// <param name="mode"> The current notification mode for this signal. </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="signalType"> [Required] Specifies the type of signal to monitor. </param>
        /// <param name="componentId"> [Required] ARM resource ID of the component resource used to calculate the custom metrics. </param>
        /// <param name="inputAssets">
        /// Monitoring assets to take as input. Key is the component input port name, value is the data asset.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </param>
        /// <param name="inputs">
        /// Extra component parameters to take as input. Key is the component literal input port name, value is the parameter value.
        /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
        /// </param>
        /// <param name="metricThresholds"> [Required] A list of metrics to calculate and their associated thresholds. </param>
        /// <param name="workspaceConnection"> [Required] A list of metrics to calculate and their associated thresholds. </param>
        internal CustomMonitoringSignal(MonitoringNotificationMode? mode, IDictionary<string, string> properties, MonitoringSignalType signalType, string componentId, IDictionary<string, MonitoringInputDataBase> inputAssets, IDictionary<string, MachineLearningJobInput> inputs, IList<CustomMetricThreshold> metricThresholds, MonitoringWorkspaceConnection workspaceConnection) : base(mode, properties, signalType)
        {
            ComponentId = componentId;
            InputAssets = inputAssets;
            Inputs = inputs;
            MetricThresholds = metricThresholds;
            WorkspaceConnection = workspaceConnection;
            SignalType = signalType;
        }

        /// <summary> [Required] ARM resource ID of the component resource used to calculate the custom metrics. </summary>
        public string ComponentId { get; set; }
        /// <summary>
        /// Monitoring assets to take as input. Key is the component input port name, value is the data asset.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </summary>
        public IDictionary<string, MonitoringInputDataBase> InputAssets { get; set; }
        /// <summary>
        /// Extra component parameters to take as input. Key is the component literal input port name, value is the parameter value.
        /// Please note <see cref="MachineLearningJobInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobInput"/>, <see cref="MachineLearningLiteralJobInput"/>, <see cref="MachineLearningFlowModelJobInput"/>, <see cref="MachineLearningTableJobInput"/>, <see cref="MachineLearningTritonModelJobInput"/>, <see cref="MachineLearningUriFileJobInput"/> and <see cref="MachineLearningUriFolderJobInput"/>.
        /// </summary>
        public IDictionary<string, MachineLearningJobInput> Inputs { get; set; }
        /// <summary> [Required] A list of metrics to calculate and their associated thresholds. </summary>
        public IList<CustomMetricThreshold> MetricThresholds { get; }
        /// <summary> [Required] A list of metrics to calculate and their associated thresholds. </summary>
        public MonitoringWorkspaceConnection WorkspaceConnection { get; set; }
    }
}
