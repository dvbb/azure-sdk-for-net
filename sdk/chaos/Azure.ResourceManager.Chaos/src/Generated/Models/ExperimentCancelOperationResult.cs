// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents the result of a cancel Experiment operation. </summary>
    public partial class ExperimentCancelOperationResult
    {
        /// <summary> Initializes a new instance of <see cref="ExperimentCancelOperationResult"/>. </summary>
        internal ExperimentCancelOperationResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExperimentCancelOperationResult"/>. </summary>
        /// <param name="name"> String of the Experiment name. </param>
        /// <param name="statusUri"> URL to retrieve the Experiment status. </param>
        internal ExperimentCancelOperationResult(string name, string statusUri)
        {
            Name = name;
            StatusUri = statusUri;
        }

        /// <summary> String of the Experiment name. </summary>
        public string Name { get; }
        /// <summary> URL to retrieve the Experiment status. </summary>
        public string StatusUri { get; }
    }
}
