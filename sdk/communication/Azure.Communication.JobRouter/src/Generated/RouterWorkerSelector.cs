// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> Describes a condition that must be met against a set of labels for worker selection. </summary>
    public partial class RouterWorkerSelector
    {
        /// <summary> Initializes a new instance of RouterWorkerSelector. </summary>
        /// <param name="key"> The label key to query against. </param>
        /// <param name="labelOperator"> Describes how the value of the label is compared to the value defined on the label selector. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        internal RouterWorkerSelector(string key, LabelOperator labelOperator)
        {
            Argument.AssertNotNull(key, nameof(key));

            Key = key;
            LabelOperator = labelOperator;
        }

        /// <summary> Initializes a new instance of RouterWorkerSelector. </summary>
        /// <param name="key"> The label key to query against. </param>
        /// <param name="labelOperator"> Describes how the value of the label is compared to the value defined on the label selector. </param>
        /// <param name="value"> The value to compare against the actual label value with the given operator. Values must be primitive values - number, string, boolean. </param>
        /// <param name="expiresAfterSeconds"> Describes how long this label selector is valid in seconds. </param>
        /// <param name="expedite"> Pushes the job to the front of the queue as long as this selector is active. </param>
        /// <param name="status"> The status of the worker selector. </param>
        /// <param name="expiresAt"> The time at which this worker selector expires in UTC. </param>
        internal RouterWorkerSelector(string key, LabelOperator labelOperator, BinaryData value, double? expiresAfterSeconds, bool? expedite, RouterWorkerSelectorStatus? status, DateTimeOffset? expiresAt)
        {
            Key = key;
            LabelOperator = labelOperator;
            _value = value;
            _expiresAfterSeconds = expiresAfterSeconds;
            Expedite = expedite;
            Status = status;
            ExpiresAt = expiresAt;
        }

        /// <summary> The label key to query against. </summary>
        public string Key { get; }
        /// <summary> Describes how the value of the label is compared to the value defined on the label selector. </summary>
        public LabelOperator LabelOperator { get; }
        /// <summary> The status of the worker selector. </summary>
        public RouterWorkerSelectorStatus? Status { get; }
        /// <summary> The time at which this worker selector expires in UTC. </summary>
        public DateTimeOffset? ExpiresAt { get; }
    }
}
