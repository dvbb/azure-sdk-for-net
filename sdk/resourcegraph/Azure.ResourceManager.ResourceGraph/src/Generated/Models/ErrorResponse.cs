// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    /// <summary> An error response from the API. </summary>
    internal partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="error"> Error information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/> is null. </exception>
        internal ErrorResponse(Error error)
        {
            if (error == null)
            {
                throw new ArgumentNullException(nameof(error));
            }

            Error = error;
        }

        /// <summary> Error information. </summary>
        public Error Error { get; }
    }
}
