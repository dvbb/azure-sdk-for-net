// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> CloudApplication entity property bag. </summary>
    internal partial class CloudApplicationEntityProperties : EntityCommonProperties
    {
        /// <summary> Initializes a new instance of CloudApplicationEntityProperties. </summary>
        internal CloudApplicationEntityProperties()
        {
        }

        /// <summary> The technical identifier of the application. </summary>
        public int? AppId { get; }
        /// <summary> The name of the related cloud application. </summary>
        public string AppName { get; }
        /// <summary> The user defined instance name of the cloud application. It is often used to distinguish between several applications of the same type that a customer has. </summary>
        public string InstanceName { get; }
    }
}
