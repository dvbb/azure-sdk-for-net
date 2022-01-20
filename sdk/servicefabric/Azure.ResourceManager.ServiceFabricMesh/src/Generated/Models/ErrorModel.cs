// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceFabricMesh.Models
{
    /// <summary> The error details. </summary>
    internal partial class ErrorModel
    {
        /// <summary> Initializes a new instance of ErrorModel. </summary>
        /// <param name="error"> Error model information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/> is null. </exception>
        internal ErrorModel(ErrorErrorModel error)
        {
            if (error == null)
            {
                throw new ArgumentNullException(nameof(error));
            }

            Error = error;
        }

        /// <summary> Error model information. </summary>
        public ErrorErrorModel Error { get; }
    }
}
