// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Response body structure for get data factory operation status. </summary>
    internal partial class GetDataFactoryOperationStatusResponse
    {
        /// <summary> Initializes a new instance of GetDataFactoryOperationStatusResponse. </summary>
        internal GetDataFactoryOperationStatusResponse()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Status of the operation. </summary>
        public string Status { get; }
        /// <summary> Additional Properties. </summary>
        public IReadOnlyDictionary<string, object> AdditionalProperties { get; }
    }
}
