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

namespace Azure.ResourceManager.ManagedServices
{
    /// <summary>
    /// A Class representing a ManagedServicesMarketplaceRegistration along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ManagedServicesMarketplaceRegistrationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetManagedServicesMarketplaceRegistrationResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetManagedServicesMarketplaceRegistration method.
    /// </summary>
    public partial class ManagedServicesMarketplaceRegistrationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedServicesMarketplaceRegistrationResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        /// <param name="marketplaceIdentifier"> The marketplaceIdentifier. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string marketplaceIdentifier)
        {
            var resourceId = $"{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions/{marketplaceIdentifier}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedServicesMarketplaceRegistrationMarketplaceRegistrationDefinitionsClientDiagnostics;
        private readonly MarketplaceRegistrationDefinitionsRestOperations _managedServicesMarketplaceRegistrationMarketplaceRegistrationDefinitionsRestClient;
        private readonly ManagedServicesMarketplaceRegistrationData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ManagedServices/marketplaceRegistrationDefinitions";

        /// <summary> Initializes a new instance of the <see cref="ManagedServicesMarketplaceRegistrationResource"/> class for mocking. </summary>
        protected ManagedServicesMarketplaceRegistrationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedServicesMarketplaceRegistrationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedServicesMarketplaceRegistrationResource(ArmClient client, ManagedServicesMarketplaceRegistrationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedServicesMarketplaceRegistrationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedServicesMarketplaceRegistrationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedServicesMarketplaceRegistrationMarketplaceRegistrationDefinitionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedServices", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedServicesMarketplaceRegistrationMarketplaceRegistrationDefinitionsApiVersion);
            _managedServicesMarketplaceRegistrationMarketplaceRegistrationDefinitionsRestClient = new MarketplaceRegistrationDefinitionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedServicesMarketplaceRegistrationMarketplaceRegistrationDefinitionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedServicesMarketplaceRegistrationData Data
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
        /// Get the marketplace registration definition for the marketplace identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions/{marketplaceIdentifier}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceRegistrationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedServicesMarketplaceRegistrationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedServicesMarketplaceRegistrationMarketplaceRegistrationDefinitionsClientDiagnostics.CreateScope("ManagedServicesMarketplaceRegistrationResource.Get");
            scope.Start();
            try
            {
                var response = await _managedServicesMarketplaceRegistrationMarketplaceRegistrationDefinitionsRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedServicesMarketplaceRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the marketplace registration definition for the marketplace identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions/{marketplaceIdentifier}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceRegistrationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedServicesMarketplaceRegistrationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedServicesMarketplaceRegistrationMarketplaceRegistrationDefinitionsClientDiagnostics.CreateScope("ManagedServicesMarketplaceRegistrationResource.Get");
            scope.Start();
            try
            {
                var response = _managedServicesMarketplaceRegistrationMarketplaceRegistrationDefinitionsRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedServicesMarketplaceRegistrationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
