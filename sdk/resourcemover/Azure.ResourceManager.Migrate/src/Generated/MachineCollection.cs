// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Migrate.Models;

namespace Azure.ResourceManager.Migrate
{
    /// <summary> A class representing collection of Machine and their operations over its parent. </summary>
    public partial class MachineCollection : ArmCollection, IEnumerable<Machine>, IAsyncEnumerable<Machine>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly MachinesRestOperations _machinesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineCollection"/> class for mocking. </summary>
        protected MachineCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal MachineCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(Machine.ResourceType, out string apiVersion);
            _machinesRestClient = new MachinesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Project.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Project.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Get the machine with the specified name. Returns a json object of type &apos;machine&apos; defined in Models section. </summary>
        /// <param name="machineName"> Unique name of a machine in private datacenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> is null. </exception>
        public virtual Response<Machine> Get(string machineName, CancellationToken cancellationToken = default)
        {
            if (machineName == null)
            {
                throw new ArgumentNullException(nameof(machineName));
            }

            using var scope = _clientDiagnostics.CreateScope("MachineCollection.Get");
            scope.Start();
            try
            {
                var response = _machinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, machineName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Machine(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the machine with the specified name. Returns a json object of type &apos;machine&apos; defined in Models section. </summary>
        /// <param name="machineName"> Unique name of a machine in private datacenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> is null. </exception>
        public async virtual Task<Response<Machine>> GetAsync(string machineName, CancellationToken cancellationToken = default)
        {
            if (machineName == null)
            {
                throw new ArgumentNullException(nameof(machineName));
            }

            using var scope = _clientDiagnostics.CreateScope("MachineCollection.Get");
            scope.Start();
            try
            {
                var response = await _machinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, machineName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Machine(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="machineName"> Unique name of a machine in private datacenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> is null. </exception>
        public virtual Response<Machine> GetIfExists(string machineName, CancellationToken cancellationToken = default)
        {
            if (machineName == null)
            {
                throw new ArgumentNullException(nameof(machineName));
            }

            using var scope = _clientDiagnostics.CreateScope("MachineCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, machineName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Machine>(null, response.GetRawResponse());
                return Response.FromValue(new Machine(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="machineName"> Unique name of a machine in private datacenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> is null. </exception>
        public async virtual Task<Response<Machine>> GetIfExistsAsync(string machineName, CancellationToken cancellationToken = default)
        {
            if (machineName == null)
            {
                throw new ArgumentNullException(nameof(machineName));
            }

            using var scope = _clientDiagnostics.CreateScope("MachineCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, machineName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Machine>(null, response.GetRawResponse());
                return Response.FromValue(new Machine(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="machineName"> Unique name of a machine in private datacenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> is null. </exception>
        public virtual Response<bool> Exists(string machineName, CancellationToken cancellationToken = default)
        {
            if (machineName == null)
            {
                throw new ArgumentNullException(nameof(machineName));
            }

            using var scope = _clientDiagnostics.CreateScope("MachineCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(machineName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="machineName"> Unique name of a machine in private datacenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="machineName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string machineName, CancellationToken cancellationToken = default)
        {
            if (machineName == null)
            {
                throw new ArgumentNullException(nameof(machineName));
            }

            using var scope = _clientDiagnostics.CreateScope("MachineCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(machineName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get data of all the machines available in the project. Returns a json array of objects of type &apos;machine&apos; defined in Models section. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Machine" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Machine> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Machine> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _machinesRestClient.ListByProject(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Machine(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Machine> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _machinesRestClient.ListByProjectNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Machine(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get data of all the machines available in the project. Returns a json array of objects of type &apos;machine&apos; defined in Models section. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Machine" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Machine> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Machine>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _machinesRestClient.ListByProjectAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Machine(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Machine>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _machinesRestClient.ListByProjectNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Machine(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<Machine> IEnumerable<Machine>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Machine> IAsyncEnumerable<Machine>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, Machine, MachineData> Construct() { }
    }
}
