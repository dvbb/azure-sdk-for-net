// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.EnergyServices.Models;

namespace Azure.ResourceManager.EnergyServices
{
    internal class DataPartitionAddOrRemoveContentOperationSource : IOperationSource<DataPartitionAddOrRemoveContent>
    {
        DataPartitionAddOrRemoveContent IOperationSource<DataPartitionAddOrRemoveContent>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return DataPartitionAddOrRemoveContent.DeserializeDataPartitionAddOrRemoveContent(document.RootElement);
        }

        async ValueTask<DataPartitionAddOrRemoveContent> IOperationSource<DataPartitionAddOrRemoveContent>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return DataPartitionAddOrRemoveContent.DeserializeDataPartitionAddOrRemoveContent(document.RootElement);
        }
    }
}
