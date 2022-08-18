// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication.JobRouter;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class RouterModelFactory
    {
        /// <summary> Initializes a new instance of ClassificationPolicy. </summary>
        /// <param name="id"> Unique identifier of this policy. </param>
        /// <param name="name"> Friendly name of this policy. </param>
        /// <param name="fallbackQueueId"> The fallback queue to select if the queue selector doesn&apos;t find a match. </param>
        /// <param name="queueSelectors"> The queue selectors to resolve a queue for a given job. </param>
        /// <param name="prioritizationRule">
        /// A rule of one of the following types:
        ///             
        /// StaticRule:  A rule providing static rules that always return the same result, regardless of input.
        /// DirectMapRule:  A rule that return the same labels as the input labels.
        /// ExpressionRule: A rule providing inline expression rules.
        /// AzureFunctionRule: A rule providing a binding to an HTTP Triggered Azure Function.
        /// </param>
        /// <param name="workerSelectors"> The worker label selectors to attach to a given job. </param>
        /// <returns> A new <see cref="Models.ClassificationPolicy"/> instance for mocking. </returns>
        public static ClassificationPolicy ClassificationPolicy(string id = null, string name = null, string fallbackQueueId = null, IEnumerable<QueueSelectorAttachment> queueSelectors = null, RouterRule prioritizationRule = null, IEnumerable<WorkerSelectorAttachment> workerSelectors = null)
        {
            queueSelectors ??= new List<QueueSelectorAttachment>();
            workerSelectors ??= new List<WorkerSelectorAttachment>();

            return new ClassificationPolicy(id, name, fallbackQueueId, queueSelectors?.ToList(), prioritizationRule, workerSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of JobRouterError. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="target"> The error target. </param>
        /// <param name="details"> Further details about specific errors that led to this error. </param>
        /// <param name="innerError"> The inner error if any. </param>
        /// <returns> A new <see cref="Models.JobRouterError"/> instance for mocking. </returns>
        public static JobRouterError JobRouterError(string code = null, string message = null, string target = null, IEnumerable<JobRouterError> details = null, JobRouterError innerError = null)
        {
            details ??= new List<JobRouterError>();

            return new JobRouterError(code, message, target, details?.ToList(), innerError);
        }

        /// <summary> Initializes a new instance of ClassificationPolicyItem. </summary>
        /// <param name="classificationPolicy"> A container for the rules that govern how jobs are classified. </param>
        /// <param name="etag"> (Optional) The Concurrency Token. </param>
        /// <returns> A new <see cref="Models.ClassificationPolicyItem"/> instance for mocking. </returns>
        public static ClassificationPolicyItem ClassificationPolicyItem(ClassificationPolicy classificationPolicy = null, string etag = null)
        {
            return new ClassificationPolicyItem(classificationPolicy, etag);
        }

        /// <summary> Initializes a new instance of DistributionPolicyItem. </summary>
        /// <param name="distributionPolicy"> Policy governing how jobs are distributed to workers. </param>
        /// <param name="etag"> (Optional) The Concurrency Token. </param>
        /// <returns> A new <see cref="Models.DistributionPolicyItem"/> instance for mocking. </returns>
        public static DistributionPolicyItem DistributionPolicyItem(DistributionPolicy distributionPolicy = null, string etag = null)
        {
            return new DistributionPolicyItem(distributionPolicy, etag);
        }

        /// <summary> Initializes a new instance of ExceptionPolicy. </summary>
        /// <param name="id"> The Id of the exception policy. </param>
        /// <param name="name"> (Optional) The name of the exception policy. </param>
        /// <param name="exceptionRules"> (Optional) A dictionary collection of exception rules on the exception policy. Key is the Id of each exception rule. </param>
        /// <returns> A new <see cref="Models.ExceptionPolicy"/> instance for mocking. </returns>
        public static ExceptionPolicy ExceptionPolicy(string id = null, string name = null, IDictionary<string, ExceptionRule> exceptionRules = null)
        {
            exceptionRules ??= new Dictionary<string, ExceptionRule>();

            return new ExceptionPolicy(id, name, exceptionRules);
        }

        /// <summary> Initializes a new instance of ExceptionPolicyItem. </summary>
        /// <param name="exceptionPolicy"> A policy that defines actions to execute when exception are triggered. </param>
        /// <param name="etag"> (Optional) The Concurrency Token. </param>
        /// <returns> A new <see cref="Models.ExceptionPolicyItem"/> instance for mocking. </returns>
        public static ExceptionPolicyItem ExceptionPolicyItem(ExceptionPolicy exceptionPolicy = null, string etag = null)
        {
            return new ExceptionPolicyItem(exceptionPolicy, etag);
        }

        /// <summary> Initializes a new instance of JobAssignment. </summary>
        /// <param name="id"> The Id of the job assignment. </param>
        /// <param name="workerId"> The Id of the Worker assigned to the job. </param>
        /// <param name="assignTime"> The assignment time of the job. </param>
        /// <param name="completeTime"> The time the job was marked as completed after being assigned. </param>
        /// <param name="closeTime"> The time the job was marked as closed after being completed. </param>
        /// <returns> A new <see cref="Models.JobAssignment"/> instance for mocking. </returns>
        public static JobAssignment JobAssignment(string id = null, string workerId = null, DateTimeOffset assignTime = default, DateTimeOffset? completeTime = null, DateTimeOffset? closeTime = null)
        {
            return new JobAssignment(id, workerId, assignTime, completeTime, closeTime);
        }

        /// <summary> Initializes a new instance of RouterJobItem. </summary>
        /// <param name="routerJob"> A unit of work to be routed. </param>
        /// <param name="etag"> (Optional) The Concurrency Token. </param>
        /// <returns> A new <see cref="Models.RouterJobItem"/> instance for mocking. </returns>
        public static RouterJobItem RouterJobItem(RouterJob routerJob = null, string etag = null)
        {
            return new RouterJobItem(routerJob, etag);
        }

        /// <summary> Initializes a new instance of JobPositionDetails. </summary>
        /// <param name="jobId"> Id of the job these details are about. </param>
        /// <param name="position"> Position of the job in question within that queue. </param>
        /// <param name="queueId"> Id of the queue this job is enqueued in. </param>
        /// <param name="queueLength"> Length of the queue: total number of enqueued jobs. </param>
        /// <param name="estimatedWaitTimeMinutes"> Estimated wait time of the job rounded up to the nearest minute. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> or <paramref name="queueId"/> is null. </exception>
        /// <returns> A new <see cref="Models.JobPositionDetails"/> instance for mocking. </returns>
        public static JobPositionDetails JobPositionDetails(string jobId = null, int position = default, string queueId = null, int queueLength = default, double estimatedWaitTimeMinutes = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (queueId == null)
            {
                throw new ArgumentNullException(nameof(queueId));
            }

            return new JobPositionDetails(jobId, position, queueId, queueLength, estimatedWaitTimeMinutes);
        }

        /// <summary> Initializes a new instance of UnassignJobResult. </summary>
        /// <param name="jobId"> The Id of the job unassigned. </param>
        /// <param name="unassignmentCount"> The number of times a job is unassigned. At a maximum 3. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <returns> A new <see cref="Models.UnassignJobResult"/> instance for mocking. </returns>
        public static UnassignJobResult UnassignJobResult(string jobId = null, int unassignmentCount = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return new UnassignJobResult(jobId, unassignmentCount);
        }

        /// <summary> Initializes a new instance of AcceptJobOfferResult. </summary>
        /// <param name="assignmentId"> The assignment Id that assigns a worker that has accepted an offer to a job. </param>
        /// <param name="jobId"> The Id of the job assigned. </param>
        /// <param name="workerId"> The Id of the worker that has been assigned this job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentId"/>, <paramref name="jobId"/> or <paramref name="workerId"/> is null. </exception>
        /// <returns> A new <see cref="Models.AcceptJobOfferResult"/> instance for mocking. </returns>
        public static AcceptJobOfferResult AcceptJobOfferResult(string assignmentId = null, string jobId = null, string workerId = null)
        {
            if (assignmentId == null)
            {
                throw new ArgumentNullException(nameof(assignmentId));
            }
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (workerId == null)
            {
                throw new ArgumentNullException(nameof(workerId));
            }

            return new AcceptJobOfferResult(assignmentId, jobId, workerId);
        }

        /// <summary> Initializes a new instance of JobQueueItem. </summary>
        /// <param name="jobQueue"> A queue that can contain jobs to be routed. </param>
        /// <param name="etag"> (Optional) The Concurrency Token. </param>
        /// <returns> A new <see cref="Models.JobQueueItem"/> instance for mocking. </returns>
        public static JobQueueItem JobQueueItem(JobQueue jobQueue = null, string etag = null)
        {
            return new JobQueueItem(jobQueue, etag);
        }

        /// <summary> Initializes a new instance of QueueStatistics. </summary>
        /// <param name="queueId"> Id of the queue these details are about. </param>
        /// <param name="length"> Length of the queue: total number of enqueued jobs. </param>
        /// <param name="estimatedWaitTimeMinutes"> The estimated wait time of this queue rounded up to the nearest minute, grouped by job priority. </param>
        /// <param name="longestJobWaitTimeMinutes"> The wait time of the job that has been enqueued in this queue for the longest. </param>
        /// <returns> A new <see cref="Models.QueueStatistics"/> instance for mocking. </returns>
        public static QueueStatistics QueueStatistics(string queueId = null, int length = default, IReadOnlyDictionary<string, double> estimatedWaitTimeMinutes = null, double? longestJobWaitTimeMinutes = null)
        {
            estimatedWaitTimeMinutes ??= new Dictionary<string, double>();

            return new QueueStatistics(queueId, length, estimatedWaitTimeMinutes, longestJobWaitTimeMinutes);
        }

        /// <summary> Initializes a new instance of JobOffer. </summary>
        /// <param name="id"> The Id of the offer. </param>
        /// <param name="jobId"> The Id of the job. </param>
        /// <param name="capacityCost"> The capacity cost consumed by the job offer. </param>
        /// <param name="offerTimeUtc"> The time the offer was created. </param>
        /// <param name="expiryTimeUtc"> The time that the offer will expire. </param>
        /// <returns> A new <see cref="Models.JobOffer"/> instance for mocking. </returns>
        public static JobOffer JobOffer(string id = null, string jobId = null, int capacityCost = default, DateTimeOffset? offerTimeUtc = null, DateTimeOffset? expiryTimeUtc = null)
        {
            return new JobOffer(id, jobId, capacityCost, offerTimeUtc, expiryTimeUtc);
        }

        /// <summary> Initializes a new instance of WorkerAssignment. </summary>
        /// <param name="id"> The Id of the assignment. </param>
        /// <param name="jobId"> The Id of the Job assigned. </param>
        /// <param name="capacityCost"> The amount of capacity this assignment has consumed on the worker. </param>
        /// <param name="assignTime"> The assignment time of the job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="jobId"/> is null. </exception>
        /// <returns> A new <see cref="Models.WorkerAssignment"/> instance for mocking. </returns>
        public static WorkerAssignment WorkerAssignment(string id = null, string jobId = null, int capacityCost = default, DateTimeOffset assignTime = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return new WorkerAssignment(id, jobId, capacityCost, assignTime);
        }

        /// <summary> Initializes a new instance of RouterWorkerItem. </summary>
        /// <param name="routerWorker"> An entity for jobs to be routed to. </param>
        /// <param name="etag"> (Optional) The Concurrency Token. </param>
        /// <returns> A new <see cref="Models.RouterWorkerItem"/> instance for mocking. </returns>
        public static RouterWorkerItem RouterWorkerItem(RouterWorker routerWorker = null, string etag = null)
        {
            return new RouterWorkerItem(routerWorker, etag);
        }
    }
}
