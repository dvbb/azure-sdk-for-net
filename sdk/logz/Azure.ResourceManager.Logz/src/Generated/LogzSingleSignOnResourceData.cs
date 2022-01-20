// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Logz.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logz
{
    /// <summary> A class representing the LogzSingleSignOnResource data model. </summary>
    public partial class LogzSingleSignOnResourceData : Resource
    {
        /// <summary> Initializes a new instance of LogzSingleSignOnResourceData. </summary>
        public LogzSingleSignOnResourceData()
        {
        }

        /// <summary> Initializes a new instance of LogzSingleSignOnResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the resource. </param>
        /// <param name="properties"></param>
        internal LogzSingleSignOnResourceData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, LogzSingleSignOnProperties properties) : base(id, name, type)
        {
            SystemData = systemData;
            Properties = properties;
        }

        /// <summary> Metadata pertaining to creation and last modification of the resource. </summary>
        public SystemData SystemData { get; }
        /// <summary> Gets or sets the properties. </summary>
        public LogzSingleSignOnProperties Properties { get; set; }
    }
}
