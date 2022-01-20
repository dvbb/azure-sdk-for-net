// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    /// <summary> Describes the format of Error response. </summary>
    internal partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        internal ErrorResponse()
        {
        }

        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="error"> The error object. </param>
        internal ErrorResponse(ErrorResponseError error)
        {
            Error = error;
        }

        /// <summary> The error object. </summary>
        public ErrorResponseError Error { get; }
    }
}
