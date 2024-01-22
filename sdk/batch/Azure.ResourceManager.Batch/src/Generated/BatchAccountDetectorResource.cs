// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A Class representing a BatchAccountDetector along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="BatchAccountDetectorResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetBatchAccountDetectorResource method.
    /// Otherwise you can get one from its parent resource <see cref="BatchAccountResource"/> using the GetBatchAccountDetector method.
    /// </summary>
    public partial class BatchAccountDetectorResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BatchAccountDetectorResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="detectorId"> The detectorId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string detectorId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/detectors/{detectorId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _batchAccountDetectorBatchAccountClientDiagnostics;
        private readonly BatchAccountRestOperations _batchAccountDetectorBatchAccountRestClient;
        private readonly BatchAccountDetectorData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Batch/batchAccounts/detectors";

        /// <summary> Initializes a new instance of the <see cref="BatchAccountDetectorResource"/> class for mocking. </summary>
        protected BatchAccountDetectorResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BatchAccountDetectorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BatchAccountDetectorResource(ArmClient client, BatchAccountDetectorData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BatchAccountDetectorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BatchAccountDetectorResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _batchAccountDetectorBatchAccountClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Batch", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string batchAccountDetectorBatchAccountApiVersion);
            _batchAccountDetectorBatchAccountRestClient = new BatchAccountRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, batchAccountDetectorBatchAccountApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BatchAccountDetectorData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets information about the given detector for a given Batch account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/detectors/{detectorId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchAccount_GetDetector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BatchAccountDetectorResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _batchAccountDetectorBatchAccountClientDiagnostics.CreateScope("BatchAccountDetectorResource.Get");
            scope.Start();
            try
            {
                var response = await _batchAccountDetectorBatchAccountRestClient.GetDetectorAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchAccountDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the given detector for a given Batch account.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/detectors/{detectorId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BatchAccount_GetDetector</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BatchAccountDetectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BatchAccountDetectorResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _batchAccountDetectorBatchAccountClientDiagnostics.CreateScope("BatchAccountDetectorResource.Get");
            scope.Start();
            try
            {
                var response = _batchAccountDetectorBatchAccountRestClient.GetDetector(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchAccountDetectorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
