// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HybridDataManager
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region DataManager
        /// <summary> Gets an object representing a DataManager along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataManager" /> object. </returns>
        public static DataManager GetDataManager(this ArmClient armClient, ResourceIdentifier id)
        {
            DataManager.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DataManager(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DataService
        /// <summary> Gets an object representing a DataService along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataService" /> object. </returns>
        public static DataService GetDataService(this ArmClient armClient, ResourceIdentifier id)
        {
            DataService.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DataService(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region JobDefinition
        /// <summary> Gets an object representing a JobDefinition along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="JobDefinition" /> object. </returns>
        public static JobDefinition GetJobDefinition(this ArmClient armClient, ResourceIdentifier id)
        {
            JobDefinition.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new JobDefinition(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Job
        /// <summary> Gets an object representing a Job along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Job" /> object. </returns>
        public static Job GetJob(this ArmClient armClient, ResourceIdentifier id)
        {
            Job.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Job(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DataStore
        /// <summary> Gets an object representing a DataStore along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataStore" /> object. </returns>
        public static DataStore GetDataStore(this ArmClient armClient, ResourceIdentifier id)
        {
            DataStore.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DataStore(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DataStoreType
        /// <summary> Gets an object representing a DataStoreType along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataStoreType" /> object. </returns>
        public static DataStoreType GetDataStoreType(this ArmClient armClient, ResourceIdentifier id)
        {
            DataStoreType.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DataStoreType(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PublicKey
        /// <summary> Gets an object representing a PublicKey along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PublicKey" /> object. </returns>
        public static PublicKey GetPublicKey(this ArmClient armClient, ResourceIdentifier id)
        {
            PublicKey.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PublicKey(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
