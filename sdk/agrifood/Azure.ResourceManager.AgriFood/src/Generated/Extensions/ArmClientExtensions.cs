// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AgriFood
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region Extension
        /// <summary> Gets an object representing a Extension along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Extension" /> object. </returns>
        public static Extension GetExtension(this ArmClient armClient, ResourceIdentifier id)
        {
            Extension.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Extension(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region FarmBeatsExtension
        /// <summary> Gets an object representing a FarmBeatsExtension along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FarmBeatsExtension" /> object. </returns>
        public static FarmBeatsExtension GetFarmBeatsExtension(this ArmClient armClient, ResourceIdentifier id)
        {
            FarmBeatsExtension.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new FarmBeatsExtension(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region FarmBeats
        /// <summary> Gets an object representing a FarmBeats along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FarmBeats" /> object. </returns>
        public static FarmBeats GetFarmBeats(this ArmClient armClient, ResourceIdentifier id)
        {
            FarmBeats.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new FarmBeats(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
