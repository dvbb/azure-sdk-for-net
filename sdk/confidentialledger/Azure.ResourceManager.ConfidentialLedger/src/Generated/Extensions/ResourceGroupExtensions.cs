// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConfidentialLedger
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region ConfidentialLedger
        /// <summary> Gets an object representing a ConfidentialLedgerCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ConfidentialLedgerCollection" /> object. </returns>
        public static ConfidentialLedgerCollection GetConfidentialLedgers(this ResourceGroup resourceGroup)
        {
            return new ConfidentialLedgerCollection(resourceGroup);
        }
        #endregion
    }
}
