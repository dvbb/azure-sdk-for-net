// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    /// <summary> A Class representing a SupportTicketDetails along with the instance operations that can be performed on it. </summary>
    public partial class SupportTicketDetails : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SupportTicketDetails"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string supportTicketName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SupportTicketsRestOperations _supportTicketsRestClient;
        private readonly CommunicationsRestOperations _communicationsRestClient;
        private readonly SupportTicketDetailsData _data;

        /// <summary> Initializes a new instance of the <see cref="SupportTicketDetails"/> class for mocking. </summary>
        protected SupportTicketDetails()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SupportTicketDetails"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SupportTicketDetails(ArmResource options, SupportTicketDetailsData data) : base(options, data.Id)
        {
            HasData = true;
            _data = data;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _supportTicketsRestClient = new SupportTicketsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _communicationsRestClient = new CommunicationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SupportTicketDetails"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SupportTicketDetails(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _supportTicketsRestClient = new SupportTicketsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _communicationsRestClient = new CommunicationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SupportTicketDetails"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SupportTicketDetails(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _supportTicketsRestClient = new SupportTicketsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _communicationsRestClient = new CommunicationsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Support/supportTickets";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SupportTicketDetailsData Data
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

        /// <summary> Get ticket details for an Azure subscription. Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SupportTicketDetails>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SupportTicketDetails.Get");
            scope.Start();
            try
            {
                var response = await _supportTicketsRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SupportTicketDetails(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get ticket details for an Azure subscription. Support ticket data is available for 18 months after ticket creation. If a ticket was created more than 18 months ago, a request for data might cause an error. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SupportTicketDetails> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SupportTicketDetails.Get");
            scope.Start();
            try
            {
                var response = _supportTicketsRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportTicketDetails(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SupportTicketDetails.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SupportTicketDetails.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This API allows you to update the severity level, ticket status, and your contact information in the support ticket.&lt;br/&gt;&lt;br/&gt;Note: The severity levels cannot be changed if a support ticket is actively being worked upon by an Azure support engineer. In such a case, contact your support engineer to request severity update by adding a new communication using the Communications API.&lt;br/&gt;&lt;br/&gt;Changing the ticket status to _closed_ is allowed only on an unassigned case. When an engineer is actively working on the ticket, send your ticket closure request by sending a note to your engineer. </summary>
        /// <param name="updateSupportTicket"> UpdateSupportTicket object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateSupportTicket"/> is null. </exception>
        public async virtual Task<Response<SupportTicketDetails>> UpdateAsync(UpdateSupportTicket updateSupportTicket, CancellationToken cancellationToken = default)
        {
            if (updateSupportTicket == null)
            {
                throw new ArgumentNullException(nameof(updateSupportTicket));
            }

            using var scope = _clientDiagnostics.CreateScope("SupportTicketDetails.Update");
            scope.Start();
            try
            {
                var response = await _supportTicketsRestClient.UpdateAsync(Id.SubscriptionId, Id.Name, updateSupportTicket, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SupportTicketDetails(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This API allows you to update the severity level, ticket status, and your contact information in the support ticket.&lt;br/&gt;&lt;br/&gt;Note: The severity levels cannot be changed if a support ticket is actively being worked upon by an Azure support engineer. In such a case, contact your support engineer to request severity update by adding a new communication using the Communications API.&lt;br/&gt;&lt;br/&gt;Changing the ticket status to _closed_ is allowed only on an unassigned case. When an engineer is actively working on the ticket, send your ticket closure request by sending a note to your engineer. </summary>
        /// <param name="updateSupportTicket"> UpdateSupportTicket object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="updateSupportTicket"/> is null. </exception>
        public virtual Response<SupportTicketDetails> Update(UpdateSupportTicket updateSupportTicket, CancellationToken cancellationToken = default)
        {
            if (updateSupportTicket == null)
            {
                throw new ArgumentNullException(nameof(updateSupportTicket));
            }

            using var scope = _clientDiagnostics.CreateScope("SupportTicketDetails.Update");
            scope.Start();
            try
            {
                var response = _supportTicketsRestClient.Update(Id.SubscriptionId, Id.Name, updateSupportTicket, cancellationToken);
                return Response.FromValue(new SupportTicketDetails(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Check the availability of a resource name. This API should be used to check the uniqueness of the name for adding a new communication to the support ticket. </summary>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="checkNameAvailabilityInput"/> is null. </exception>
        public async virtual Task<Response<CheckNameAvailabilityOutput>> CheckNameAvailabilityCommunicationAsync(CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            if (checkNameAvailabilityInput == null)
            {
                throw new ArgumentNullException(nameof(checkNameAvailabilityInput));
            }

            using var scope = _clientDiagnostics.CreateScope("SupportTicketDetails.CheckNameAvailabilityCommunication");
            scope.Start();
            try
            {
                var response = await _communicationsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, Id.Name, checkNameAvailabilityInput, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Check the availability of a resource name. This API should be used to check the uniqueness of the name for adding a new communication to the support ticket. </summary>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="checkNameAvailabilityInput"/> is null. </exception>
        public virtual Response<CheckNameAvailabilityOutput> CheckNameAvailabilityCommunication(CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            if (checkNameAvailabilityInput == null)
            {
                throw new ArgumentNullException(nameof(checkNameAvailabilityInput));
            }

            using var scope = _clientDiagnostics.CreateScope("SupportTicketDetails.CheckNameAvailabilityCommunication");
            scope.Start();
            try
            {
                var response = _communicationsRestClient.CheckNameAvailability(Id.SubscriptionId, Id.Name, checkNameAvailabilityInput, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        #region CommunicationDetails

        /// <summary> Gets a collection of CommunicationDetails in the SupportTicketDetails. </summary>
        /// <returns> An object representing collection of CommunicationDetails and their operations over a SupportTicketDetails. </returns>
        public virtual CommunicationDetailsCollection GetCommunicationDetails()
        {
            return new CommunicationDetailsCollection(this);
        }
        #endregion
    }
}
