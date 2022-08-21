// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    internal class NodeTypeOperationSource : IOperationSource<NodeTypeResource>
    {
        private readonly ArmClient _client;

        internal NodeTypeOperationSource(ArmClient client)
        {
            _client = client;
        }

        NodeTypeResource IOperationSource<NodeTypeResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NodeTypeData.DeserializeNodeTypeData(document.RootElement);
            return new NodeTypeResource(_client, data);
        }

        async ValueTask<NodeTypeResource> IOperationSource<NodeTypeResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NodeTypeData.DeserializeNodeTypeData(document.RootElement);
            return new NodeTypeResource(_client, data);
        }
    }
}
