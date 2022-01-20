// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotHub
{
    /// <summary> A class representing the EventHubConsumerGroupInfo data model. </summary>
    public partial class EventHubConsumerGroupInfoData : Resource
    {
        /// <summary> Initializes a new instance of EventHubConsumerGroupInfoData. </summary>
        internal EventHubConsumerGroupInfoData()
        {
            Properties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of EventHubConsumerGroupInfoData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="properties"> The tags. </param>
        /// <param name="etag"> The etag. </param>
        internal EventHubConsumerGroupInfoData(ResourceIdentifier id, string name, ResourceType type, IReadOnlyDictionary<string, object> properties, string etag) : base(id, name, type)
        {
            Properties = properties;
            Etag = etag;
        }

        /// <summary> The tags. </summary>
        public IReadOnlyDictionary<string, object> Properties { get; }
        /// <summary> The etag. </summary>
        public string Etag { get; }
    }
}
