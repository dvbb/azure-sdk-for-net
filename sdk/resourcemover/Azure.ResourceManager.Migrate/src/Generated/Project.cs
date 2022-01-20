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
using Azure.ResourceManager.Migrate.Models;

namespace Azure.ResourceManager.Migrate
{
    /// <summary> A Class representing a Project along with the instance operations that can be performed on it. </summary>
    public partial class Project : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="Project"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string projectName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Migrate/assessmentProjects/{projectName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ProjectsRestOperations _projectsRestClient;
        private readonly AssessmentsRestOperations _assessmentsRestClient;
        private readonly ProjectData _data;

        /// <summary> Initializes a new instance of the <see cref="Project"/> class for mocking. </summary>
        protected Project()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "Project"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal Project(ArmResource options, ProjectData data) : base(options, data.Id)
        {
            HasData = true;
            _data = data;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _projectsRestClient = new ProjectsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _assessmentsRestClient = new AssessmentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="Project"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal Project(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _projectsRestClient = new ProjectsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _assessmentsRestClient = new AssessmentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="Project"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal Project(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ResourceType, out string apiVersion);
            _projectsRestClient = new ProjectsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
            _assessmentsRestClient = new AssessmentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Migrate/assessmentProjects";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ProjectData Data
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

        /// <summary> Get the project with the specified name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<Project>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Project.Get");
            scope.Start();
            try
            {
                var response = await _projectsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Project(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the project with the specified name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Project> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Project.Get");
            scope.Start();
            try
            {
                var response = _projectsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Project(this, response.Value), response.GetRawResponse());
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
        public async virtual Task<IEnumerable<Azure.Core.AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Project.GetAvailableLocations");
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
        public virtual IEnumerable<Azure.Core.AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Project.GetAvailableLocations");
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

        /// <summary> Delete the project. Deleting non-existent project is a no-operation. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ProjectDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Project.Delete");
            scope.Start();
            try
            {
                var response = await _projectsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ProjectDeleteOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete the project. Deleting non-existent project is a no-operation. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ProjectDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Project.Delete");
            scope.Start();
            try
            {
                var response = _projectsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new ProjectDeleteOperation(response);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a project with specified name. Supports partial updates, for example only tags can be provided. </summary>
        /// <param name="project"> Updated project object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<Project>> UpdateAsync(ProjectData project = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Project.Update");
            scope.Start();
            try
            {
                var response = await _projectsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, project, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Project(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update a project with specified name. Supports partial updates, for example only tags can be provided. </summary>
        /// <param name="project"> Updated project object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Project> Update(ProjectData project = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("Project.Update");
            scope.Start();
            try
            {
                var response = _projectsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, project, cancellationToken);
                return Response.FromValue(new Project(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all available options for the properties of an assessment on a project. </summary>
        /// <param name="assessmentOptionsName"> Name of the assessment options. The only name accepted in default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentOptionsName"/> is null. </exception>
        public async virtual Task<Response<AssessmentOptions>> AssessmentOptionsAsync(string assessmentOptionsName, CancellationToken cancellationToken = default)
        {
            if (assessmentOptionsName == null)
            {
                throw new ArgumentNullException(nameof(assessmentOptionsName));
            }

            using var scope = _clientDiagnostics.CreateScope("Project.AssessmentOptions");
            scope.Start();
            try
            {
                var response = await _projectsRestClient.AssessmentOptionsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assessmentOptionsName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all available options for the properties of an assessment on a project. </summary>
        /// <param name="assessmentOptionsName"> Name of the assessment options. The only name accepted in default. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assessmentOptionsName"/> is null. </exception>
        public virtual Response<AssessmentOptions> AssessmentOptions(string assessmentOptionsName, CancellationToken cancellationToken = default)
        {
            if (assessmentOptionsName == null)
            {
                throw new ArgumentNullException(nameof(assessmentOptionsName));
            }

            using var scope = _clientDiagnostics.CreateScope("Project.AssessmentOptions");
            scope.Start();
            try
            {
                var response = _projectsRestClient.AssessmentOptions(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, assessmentOptionsName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets list of all available options for the properties of an assessment on a project. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AssessmentOptions" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AssessmentOptions> AssessmentOptionsListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AssessmentOptions>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("Project.AssessmentOptionsList");
                scope.Start();
                try
                {
                    var response = await _projectsRestClient.AssessmentOptionsListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Gets list of all available options for the properties of an assessment on a project. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AssessmentOptions" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AssessmentOptions> AssessmentOptionsList(CancellationToken cancellationToken = default)
        {
            Page<AssessmentOptions> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("Project.AssessmentOptionsList");
                scope.Start();
                try
                {
                    var response = _projectsRestClient.AssessmentOptionsList(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get all assessments created in the project.
        /// 
        /// Returns a json array of objects of type &apos;assessment&apos; as specified in Models section.
        /// 
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AssessmentData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AssessmentData> GetAssessmentsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AssessmentData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("Project.GetAssessments");
                scope.Start();
                try
                {
                    var response = await _assessmentsRestClient.ListByProjectAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get all assessments created in the project.
        /// 
        /// Returns a json array of objects of type &apos;assessment&apos; as specified in Models section.
        /// 
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AssessmentData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AssessmentData> GetAssessments(CancellationToken cancellationToken = default)
        {
            Page<AssessmentData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("Project.GetAssessments");
                scope.Start();
                try
                {
                    var response = _assessmentsRestClient.ListByProject(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        #region Machine

        /// <summary> Gets a collection of Machines in the Project. </summary>
        /// <returns> An object representing collection of Machines and their operations over a Project. </returns>
        public virtual MachineCollection GetMachines()
        {
            return new MachineCollection(this);
        }
        #endregion

        #region Group

        /// <summary> Gets a collection of Groups in the Project. </summary>
        /// <returns> An object representing collection of Groups and their operations over a Project. </returns>
        public virtual GroupCollection GetGroups()
        {
            return new GroupCollection(this);
        }
        #endregion

        #region HyperVCollector

        /// <summary> Gets a collection of HyperVCollectors in the Project. </summary>
        /// <returns> An object representing collection of HyperVCollectors and their operations over a Project. </returns>
        public virtual HyperVCollectorCollection GetHyperVCollectors()
        {
            return new HyperVCollectorCollection(this);
        }
        #endregion

        #region ServerCollector

        /// <summary> Gets a collection of ServerCollectors in the Project. </summary>
        /// <returns> An object representing collection of ServerCollectors and their operations over a Project. </returns>
        public virtual ServerCollectorCollection GetServerCollectors()
        {
            return new ServerCollectorCollection(this);
        }
        #endregion

        #region VMwareCollector

        /// <summary> Gets a collection of VMwareCollectors in the Project. </summary>
        /// <returns> An object representing collection of VMwareCollectors and their operations over a Project. </returns>
        public virtual VMwareCollectorCollection GetVMwareCollectors()
        {
            return new VMwareCollectorCollection(this);
        }
        #endregion

        #region ImportCollector

        /// <summary> Gets a collection of ImportCollectors in the Project. </summary>
        /// <returns> An object representing collection of ImportCollectors and their operations over a Project. </returns>
        public virtual ImportCollectorCollection GetImportCollectors()
        {
            return new ImportCollectorCollection(this);
        }
        #endregion

        #region PrivateEndpointConnection

        /// <summary> Gets a collection of PrivateEndpointConnections in the Project. </summary>
        /// <returns> An object representing collection of PrivateEndpointConnections and their operations over a Project. </returns>
        public virtual PrivateEndpointConnectionCollection GetPrivateEndpointConnections()
        {
            return new PrivateEndpointConnectionCollection(this);
        }
        #endregion

        #region PrivateLinkResource

        /// <summary> Gets a collection of PrivateLinkResources in the Project. </summary>
        /// <returns> An object representing collection of PrivateLinkResources and their operations over a Project. </returns>
        public virtual PrivateLinkResourceCollection GetPrivateLinkResources()
        {
            return new PrivateLinkResourceCollection(this);
        }
        #endregion
    }
}
