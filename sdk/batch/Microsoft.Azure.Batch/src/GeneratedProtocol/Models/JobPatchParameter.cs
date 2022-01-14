// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The set of changes to be made to a Job.
    /// </summary>
    public partial class JobPatchParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobPatchParameter class.
        /// </summary>
        public JobPatchParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobPatchParameter class.
        /// </summary>
        /// <param name="priority">The priority of the Job.</param>
        /// <param name="maxParallelTasks">The maximum number of tasks that can
        /// be executed in parallel for the job.</param>
        /// <param name="allowTaskPreemption">Whether Tasks in this job can be
        /// preempted by other high priority jobs</param>
        /// <param name="onAllTasksComplete">The action the Batch service
        /// should take when all Tasks in the Job are in the completed
        /// state.</param>
        /// <param name="constraints">The execution constraints for the
        /// Job.</param>
        /// <param name="poolInfo">The Pool on which the Batch service runs the
        /// Job's Tasks.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the Job as metadata.</param>
        public JobPatchParameter(int? priority = default(int?), int? maxParallelTasks = default(int?), bool? allowTaskPreemption = default(bool?), OnAllTasksComplete? onAllTasksComplete = default(OnAllTasksComplete?), JobConstraints constraints = default(JobConstraints), PoolInformation poolInfo = default(PoolInformation), IList<MetadataItem> metadata = default(IList<MetadataItem>))
        {
            Priority = priority;
            MaxParallelTasks = maxParallelTasks;
            AllowTaskPreemption = allowTaskPreemption;
            OnAllTasksComplete = onAllTasksComplete;
            Constraints = constraints;
            PoolInfo = poolInfo;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the priority of the Job.
        /// </summary>
        /// <remarks>
        /// Priority values can range from -1000 to 1000, with -1000 being the
        /// lowest priority and 1000 being the highest priority. If omitted,
        /// the priority of the Job is left unchanged.
        /// </remarks>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of tasks that can be executed in
        /// parallel for the job.
        /// </summary>
        /// <remarks>
        /// The value of maxParallelTasks must be -1 or greater than 0 if
        /// specified. If not specified, the default value is -1, which means
        /// there's no limit to the number of tasks that can be run at once.
        /// You can update a job's maxParallelTasks after it has been created
        /// using the update job API.
        /// </remarks>
        [JsonProperty(PropertyName = "maxParallelTasks")]
        public int? MaxParallelTasks { get; set; }

        /// <summary>
        /// Gets or sets whether Tasks in this job can be preempted by other
        /// high priority jobs
        /// </summary>
        /// <remarks>
        /// If the value is set to True, other high priority jobs submitted to
        /// the system will take precedence and will be able requeue tasks from
        /// this job. You can update a job's allowTaskPreemption after it has
        /// been created using the update job API.
        /// </remarks>
        [JsonProperty(PropertyName = "allowTaskPreemption")]
        public bool? AllowTaskPreemption { get; set; }

        /// <summary>
        /// Gets or sets the action the Batch service should take when all
        /// Tasks in the Job are in the completed state.
        /// </summary>
        /// <remarks>
        /// If omitted, the completion behavior is left unchanged. You may not
        /// change the value from terminatejob to noaction - that is, once you
        /// have engaged automatic Job termination, you cannot turn it off
        /// again. If you try to do this, the request fails with an 'invalid
        /// property value' error response; if you are calling the REST API
        /// directly, the HTTP status code is 400 (Bad Request). Possible
        /// values include: 'noAction', 'terminateJob'
        /// </remarks>
        [JsonProperty(PropertyName = "onAllTasksComplete")]
        public OnAllTasksComplete? OnAllTasksComplete { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints for the Job.
        /// </summary>
        /// <remarks>
        /// If omitted, the existing execution constraints are left unchanged.
        /// </remarks>
        [JsonProperty(PropertyName = "constraints")]
        public JobConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets the Pool on which the Batch service runs the Job's
        /// Tasks.
        /// </summary>
        /// <remarks>
        /// You may change the Pool for a Job only when the Job is disabled.
        /// The Patch Job call will fail if you include the poolInfo element
        /// and the Job is not disabled. If you specify an
        /// autoPoolSpecification in the poolInfo, only the keepAlive property
        /// of the autoPoolSpecification can be updated, and then only if the
        /// autoPoolSpecification has a poolLifetimeOption of Job (other job
        /// properties can be updated as normal). If omitted, the Job continues
        /// to run on its current Pool.
        /// </remarks>
        [JsonProperty(PropertyName = "poolInfo")]
        public PoolInformation PoolInfo { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the Job as
        /// metadata.
        /// </summary>
        /// <remarks>
        /// If omitted, the existing Job metadata is left unchanged.
        /// </remarks>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

    }
}
