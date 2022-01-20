// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Monitoring data for integration runtime node. </summary>
    public partial class IntegrationRuntimeNodeMonitoringData
    {
        /// <summary> Initializes a new instance of IntegrationRuntimeNodeMonitoringData. </summary>
        internal IntegrationRuntimeNodeMonitoringData()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of IntegrationRuntimeNodeMonitoringData. </summary>
        /// <param name="nodeName"> Name of the integration runtime node. </param>
        /// <param name="availableMemoryInMB"> Available memory (MB) on the integration runtime node. </param>
        /// <param name="cpuUtilization"> CPU percentage on the integration runtime node. </param>
        /// <param name="concurrentJobsLimit"> Maximum concurrent jobs on the integration runtime node. </param>
        /// <param name="concurrentJobsRunning"> The number of jobs currently running on the integration runtime node. </param>
        /// <param name="maxConcurrentJobs"> The maximum concurrent jobs in this integration runtime. </param>
        /// <param name="sentBytes"> Sent bytes on the integration runtime node. </param>
        /// <param name="receivedBytes"> Received bytes on the integration runtime node. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal IntegrationRuntimeNodeMonitoringData(string nodeName, int? availableMemoryInMB, int? cpuUtilization, int? concurrentJobsLimit, int? concurrentJobsRunning, int? maxConcurrentJobs, float? sentBytes, float? receivedBytes, IReadOnlyDictionary<string, object> additionalProperties)
        {
            NodeName = nodeName;
            AvailableMemoryInMB = availableMemoryInMB;
            CpuUtilization = cpuUtilization;
            ConcurrentJobsLimit = concurrentJobsLimit;
            ConcurrentJobsRunning = concurrentJobsRunning;
            MaxConcurrentJobs = maxConcurrentJobs;
            SentBytes = sentBytes;
            ReceivedBytes = receivedBytes;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Name of the integration runtime node. </summary>
        public string NodeName { get; }
        /// <summary> Available memory (MB) on the integration runtime node. </summary>
        public int? AvailableMemoryInMB { get; }
        /// <summary> CPU percentage on the integration runtime node. </summary>
        public int? CpuUtilization { get; }
        /// <summary> Maximum concurrent jobs on the integration runtime node. </summary>
        public int? ConcurrentJobsLimit { get; }
        /// <summary> The number of jobs currently running on the integration runtime node. </summary>
        public int? ConcurrentJobsRunning { get; }
        /// <summary> The maximum concurrent jobs in this integration runtime. </summary>
        public int? MaxConcurrentJobs { get; }
        /// <summary> Sent bytes on the integration runtime node. </summary>
        public float? SentBytes { get; }
        /// <summary> Received bytes on the integration runtime node. </summary>
        public float? ReceivedBytes { get; }
        /// <summary> Additional Properties. </summary>
        public IReadOnlyDictionary<string, object> AdditionalProperties { get; }
    }
}
