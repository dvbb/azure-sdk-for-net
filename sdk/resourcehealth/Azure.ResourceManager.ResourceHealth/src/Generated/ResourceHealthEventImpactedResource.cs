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

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary>
    /// A Class representing a ResourceHealthEventImpactedResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ResourceHealthEventImpactedResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetResourceHealthEventImpactedResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceHealthEventResource" /> using the GetResourceHealthEventImpactedResource method.
    /// </summary>
    public partial class ResourceHealthEventImpactedResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceHealthEventImpactedResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="eventTrackingId"> The eventTrackingId. </param>
        /// <param name="impactedResourceName"> The impactedResourceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string eventTrackingId, string impactedResourceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics;
        private readonly ImpactedResourcesRestOperations _resourceHealthEventImpactedResourceImpactedResourcesRestClient;
        private readonly ResourceHealthEventImpactedResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthEventImpactedResource"/> class for mocking. </summary>
        protected ResourceHealthEventImpactedResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResourceHealthEventImpactedResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceHealthEventImpactedResource(ArmClient client, ResourceHealthEventImpactedResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceHealthEventImpactedResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceHealthEventImpactedResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resourceHealthEventImpactedResourceImpactedResourcesApiVersion);
            _resourceHealthEventImpactedResourceImpactedResourcesRestClient = new ImpactedResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourceHealthEventImpactedResourceImpactedResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ResourceHealth/events/impactedResources";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResourceHealthEventImpactedResourceData Data
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
        /// Gets the specific impacted resource in the subscription by an event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResourceHealthEventImpactedResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics.CreateScope("ResourceHealthEventImpactedResource.Get");
            scope.Start();
            try
            {
                var response = await _resourceHealthEventImpactedResourceImpactedResourcesRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceHealthEventImpactedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specific impacted resource in the subscription by an event.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}/impactedResources/{impactedResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImpactedResources_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceHealthEventImpactedResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceHealthEventImpactedResourceImpactedResourcesClientDiagnostics.CreateScope("ResourceHealthEventImpactedResource.Get");
            scope.Start();
            try
            {
                var response = _resourceHealthEventImpactedResourceImpactedResourcesRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceHealthEventImpactedResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
