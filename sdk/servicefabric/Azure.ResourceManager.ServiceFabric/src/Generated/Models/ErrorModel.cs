// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The structure of the error. </summary>
    internal partial class ErrorModel
    {
        /// <summary> Initializes a new instance of ErrorModel. </summary>
        internal ErrorModel()
        {
        }

        /// <summary> Initializes a new instance of ErrorModel. </summary>
        /// <param name="error"> The error details. </param>
        internal ErrorModel(ErrorModelError error)
        {
            Error = error;
        }

        /// <summary> The error details. </summary>
        public ErrorModelError Error { get; }
    }
}
