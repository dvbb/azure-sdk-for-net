// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Relay.Models;

namespace Azure.ResourceManager.Relay
{
    /// <summary> A class representing the RelayNamespace data model. </summary>
    public partial class RelayNamespaceData : TrackedResource
    {
        /// <summary> Initializes a new instance of RelayNamespaceData. </summary>
        /// <param name="location"> The location. </param>
        public RelayNamespaceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of RelayNamespaceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> SKU of the namespace. </param>
        /// <param name="provisioningState"></param>
        /// <param name="createdAt"> The time the namespace was created. </param>
        /// <param name="updatedAt"> The time the namespace was updated. </param>
        /// <param name="serviceBusEndpoint"> Endpoint you can use to perform Service Bus operations. </param>
        /// <param name="metricId"> Identifier for Azure Insights metrics. </param>
        internal RelayNamespaceData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, Models.Sku sku, ProvisioningStateEnum? provisioningState, DateTimeOffset? createdAt, DateTimeOffset? updatedAt, string serviceBusEndpoint, string metricId) : base(id, name, type, tags, location)
        {
            Sku = sku;
            ProvisioningState = provisioningState;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ServiceBusEndpoint = serviceBusEndpoint;
            MetricId = metricId;
        }

        /// <summary> SKU of the namespace. </summary>
        public Models.Sku Sku { get; set; }
        /// <summary> Gets the provisioning state. </summary>
        public ProvisioningStateEnum? ProvisioningState { get; }
        /// <summary> The time the namespace was created. </summary>
        public DateTimeOffset? CreatedAt { get; }
        /// <summary> The time the namespace was updated. </summary>
        public DateTimeOffset? UpdatedAt { get; }
        /// <summary> Endpoint you can use to perform Service Bus operations. </summary>
        public string ServiceBusEndpoint { get; }
        /// <summary> Identifier for Azure Insights metrics. </summary>
        public string MetricId { get; }
    }
}
