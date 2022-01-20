// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Migrate
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region Project
        /// <summary> Gets an object representing a Project along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Project" /> object. </returns>
        public static Project GetProject(this ArmClient armClient, ResourceIdentifier id)
        {
            Project.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Project(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Machine
        /// <summary> Gets an object representing a Machine along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Machine" /> object. </returns>
        public static Machine GetMachine(this ArmClient armClient, ResourceIdentifier id)
        {
            Machine.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Machine(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Group
        /// <summary> Gets an object representing a Group along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Group" /> object. </returns>
        public static Group GetGroup(this ArmClient armClient, ResourceIdentifier id)
        {
            Group.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Group(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Assessment
        /// <summary> Gets an object representing a Assessment along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Assessment" /> object. </returns>
        public static Assessment GetAssessment(this ArmClient armClient, ResourceIdentifier id)
        {
            Assessment.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Assessment(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AssessedMachine
        /// <summary> Gets an object representing a AssessedMachine along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AssessedMachine" /> object. </returns>
        public static AssessedMachine GetAssessedMachine(this ArmClient armClient, ResourceIdentifier id)
        {
            AssessedMachine.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AssessedMachine(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region HyperVCollector
        /// <summary> Gets an object representing a HyperVCollector along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HyperVCollector" /> object. </returns>
        public static HyperVCollector GetHyperVCollector(this ArmClient armClient, ResourceIdentifier id)
        {
            HyperVCollector.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new HyperVCollector(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ServerCollector
        /// <summary> Gets an object representing a ServerCollector along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServerCollector" /> object. </returns>
        public static ServerCollector GetServerCollector(this ArmClient armClient, ResourceIdentifier id)
        {
            ServerCollector.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ServerCollector(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region VMwareCollector
        /// <summary> Gets an object representing a VMwareCollector along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VMwareCollector" /> object. </returns>
        public static VMwareCollector GetVMwareCollector(this ArmClient armClient, ResourceIdentifier id)
        {
            VMwareCollector.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new VMwareCollector(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ImportCollector
        /// <summary> Gets an object representing a ImportCollector along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ImportCollector" /> object. </returns>
        public static ImportCollector GetImportCollector(this ArmClient armClient, ResourceIdentifier id)
        {
            ImportCollector.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ImportCollector(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient armClient, ResourceIdentifier id)
        {
            PrivateEndpointConnection.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateEndpointConnection(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PrivateLinkResource
        /// <summary> Gets an object representing a PrivateLinkResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateLinkResource" /> object. </returns>
        public static PrivateLinkResource GetPrivateLinkResource(this ArmClient armClient, ResourceIdentifier id)
        {
            PrivateLinkResource.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateLinkResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
