// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> The UnknownUsageDetail. </summary>
    internal partial class UnknownUsageDetail : ConsumptionUsageDetail
    {
        /// <summary> Initializes a new instance of <see cref="UnknownUsageDetail"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Specifies the kind of usage details. </param>
        /// <param name="etag"> The etag for the resource. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownUsageDetail(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, UsageDetailsKind kind, ETag? etag, IReadOnlyDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, kind, etag, tags, serializedAdditionalRawData)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownUsageDetail"/> for deserialization. </summary>
        internal UnknownUsageDetail()
        {
        }
    }
}
