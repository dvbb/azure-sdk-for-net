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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Subscription.Models;

namespace Azure.ResourceManager.Subscription
{
    /// <summary>
    /// A Class representing a SubscriptionAlias along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SubscriptionAliasResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSubscriptionAliasResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetSubscriptionAlias method.
    /// </summary>
    public partial class SubscriptionAliasResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionAliasResource"/> instance. </summary>
        /// <param name="aliasName"> The aliasName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string aliasName)
        {
            var resourceId = $"/providers/Microsoft.Subscription/aliases/{aliasName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _subscriptionAliasAliasClientDiagnostics;
        private readonly AliasRestOperations _subscriptionAliasAliasRestClient;
        private readonly SubscriptionAliasData _data;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionAliasResource"/> class for mocking. </summary>
        protected SubscriptionAliasResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SubscriptionAliasResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionAliasResource(ArmClient client, SubscriptionAliasData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionAliasResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionAliasResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionAliasAliasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Subscription", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string subscriptionAliasAliasApiVersion);
            _subscriptionAliasAliasRestClient = new AliasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionAliasAliasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Subscription/aliases";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SubscriptionAliasData Data
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
        /// Get Alias Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/aliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SubscriptionAliasResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionAliasAliasClientDiagnostics.CreateScope("SubscriptionAliasResource.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionAliasAliasRestClient.GetAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Alias Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/aliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionAliasResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionAliasAliasClientDiagnostics.CreateScope("SubscriptionAliasResource.Get");
            scope.Start();
            try
            {
                var response = _subscriptionAliasAliasRestClient.Get(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionAliasResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete Alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/aliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionAliasAliasClientDiagnostics.CreateScope("SubscriptionAliasResource.Delete");
            scope.Start();
            try
            {
                var response = await _subscriptionAliasAliasRestClient.DeleteAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SubscriptionArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete Alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/aliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionAliasAliasClientDiagnostics.CreateScope("SubscriptionAliasResource.Delete");
            scope.Start();
            try
            {
                var response = _subscriptionAliasAliasRestClient.Delete(Id.Name, cancellationToken);
                var operation = new SubscriptionArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create Alias Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/aliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The SubscriptionAliasCreateOrUpdateContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<SubscriptionAliasResource>> UpdateAsync(WaitUntil waitUntil, SubscriptionAliasCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _subscriptionAliasAliasClientDiagnostics.CreateScope("SubscriptionAliasResource.Update");
            scope.Start();
            try
            {
                var response = await _subscriptionAliasAliasRestClient.CreateAsync(Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new SubscriptionArmOperation<SubscriptionAliasResource>(new SubscriptionAliasOperationSource(Client), _subscriptionAliasAliasClientDiagnostics, Pipeline, _subscriptionAliasAliasRestClient.CreateCreateRequest(Id.Name, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create Alias Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Subscription/aliases/{aliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Alias_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The SubscriptionAliasCreateOrUpdateContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<SubscriptionAliasResource> Update(WaitUntil waitUntil, SubscriptionAliasCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _subscriptionAliasAliasClientDiagnostics.CreateScope("SubscriptionAliasResource.Update");
            scope.Start();
            try
            {
                var response = _subscriptionAliasAliasRestClient.Create(Id.Name, content, cancellationToken);
                var operation = new SubscriptionArmOperation<SubscriptionAliasResource>(new SubscriptionAliasOperationSource(Client), _subscriptionAliasAliasClientDiagnostics, Pipeline, _subscriptionAliasAliasRestClient.CreateCreateRequest(Id.Name, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
