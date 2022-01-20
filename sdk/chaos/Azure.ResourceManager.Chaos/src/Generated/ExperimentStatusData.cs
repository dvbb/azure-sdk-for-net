// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Chaos
{
    /// <summary> A class representing the ExperimentStatus data model. </summary>
    public partial class ExperimentStatusData : Resource
    {
        /// <summary> Initializes a new instance of ExperimentStatusData. </summary>
        internal ExperimentStatusData()
        {
        }

        /// <summary> Initializes a new instance of ExperimentStatusData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="status"> String that represents the status of a Experiment. </param>
        /// <param name="createdDateUtc"> String that represents the created date time of a Experiment. </param>
        /// <param name="endDateUtc"> String that represents the end date time of a Experiment. </param>
        internal ExperimentStatusData(ResourceIdentifier id, string name, ResourceType type, string status, DateTimeOffset? createdDateUtc, DateTimeOffset? endDateUtc) : base(id, name, type)
        {
            Status = status;
            CreatedDateUtc = createdDateUtc;
            EndDateUtc = endDateUtc;
        }

        /// <summary> String that represents the status of a Experiment. </summary>
        public string Status { get; }
        /// <summary> String that represents the created date time of a Experiment. </summary>
        public DateTimeOffset? CreatedDateUtc { get; }
        /// <summary> String that represents the end date time of a Experiment. </summary>
        public DateTimeOffset? EndDateUtc { get; }
    }
}
