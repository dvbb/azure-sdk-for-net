// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.StorSimple8000Series
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region Manager
        /// <summary> Gets an object representing a ManagerCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ManagerCollection" /> object. </returns>
        public static ManagerCollection GetManagers(this ResourceGroup resourceGroup)
        {
            return new ManagerCollection(resourceGroup);
        }
        #endregion
    }
}
