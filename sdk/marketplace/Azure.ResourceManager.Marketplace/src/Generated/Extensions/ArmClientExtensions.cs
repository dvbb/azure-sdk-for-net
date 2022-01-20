// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Marketplace
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region PrivateStore
        /// <summary> Gets an object representing a PrivateStore along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateStore" /> object. </returns>
        public static PrivateStore GetPrivateStore(this ArmClient armClient, ResourceIdentifier id)
        {
            PrivateStore.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateStore(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region RequestApprovalResource
        /// <summary> Gets an object representing a RequestApprovalResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RequestApprovalResource" /> object. </returns>
        public static RequestApprovalResource GetRequestApprovalResource(this ArmClient armClient, ResourceIdentifier id)
        {
            RequestApprovalResource.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new RequestApprovalResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region AdminRequestApprovalsResource
        /// <summary> Gets an object representing a AdminRequestApprovalsResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AdminRequestApprovalsResource" /> object. </returns>
        public static AdminRequestApprovalsResource GetAdminRequestApprovalsResource(this ArmClient armClient, ResourceIdentifier id)
        {
            AdminRequestApprovalsResource.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new AdminRequestApprovalsResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Collection
        /// <summary> Gets an object representing a Collection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Collection" /> object. </returns>
        public static Collection GetCollection(this ArmClient armClient, ResourceIdentifier id)
        {
            Collection.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Collection(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Offer
        /// <summary> Gets an object representing a Offer along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Offer" /> object. </returns>
        public static Offer GetOffer(this ArmClient armClient, ResourceIdentifier id)
        {
            Offer.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Offer(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
