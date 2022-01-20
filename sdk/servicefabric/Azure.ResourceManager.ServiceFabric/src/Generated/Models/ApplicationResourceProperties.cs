// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The application resource properties. </summary>
    internal partial class ApplicationResourceProperties : ApplicationResourceUpdateProperties
    {
        /// <summary> Initializes a new instance of ApplicationResourceProperties. </summary>
        internal ApplicationResourceProperties()
        {
        }

        /// <summary> The current deployment or provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The application type name as defined in the application manifest. </summary>
        public string TypeName { get; }
    }
}
