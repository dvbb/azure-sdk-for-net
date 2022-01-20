// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CustomProviders
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region CustomRPManifest
        /// <summary> Gets an object representing a CustomRPManifestCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="CustomRPManifestCollection" /> object. </returns>
        public static CustomRPManifestCollection GetCustomRPManifests(this ResourceGroup resourceGroup)
        {
            return new CustomRPManifestCollection(resourceGroup);
        }
        #endregion
    }
}
