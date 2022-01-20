// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.WorkloadMonitor.Models
{
    /// <summary> Error response. </summary>
    internal partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        internal ErrorResponse()
        {
        }

        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="error"> Error info. </param>
        internal ErrorResponse(ErrorResponseError error)
        {
            Error = error;
        }

        /// <summary> Error info. </summary>
        public ErrorResponseError Error { get; }
    }
}
