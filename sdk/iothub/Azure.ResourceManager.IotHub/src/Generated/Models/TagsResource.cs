// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> A container holding only the Tags for a resource, allowing the user to update the tags on an IoT Hub instance. </summary>
    public partial class TagsResource
    {
        /// <summary> Initializes a new instance of TagsResource. </summary>
        public TagsResource()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
