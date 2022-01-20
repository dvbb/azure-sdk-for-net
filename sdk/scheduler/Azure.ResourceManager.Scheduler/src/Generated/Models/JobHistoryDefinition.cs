// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Scheduler.Models
{
    /// <summary> The JobHistoryDefinition. </summary>
    public partial class JobHistoryDefinition : Resource
    {
        /// <summary> Initializes a new instance of JobHistoryDefinition. </summary>
        internal JobHistoryDefinition()
        {
        }

        /// <summary> Initializes a new instance of JobHistoryDefinition. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="properties"> Gets or sets the job history properties. </param>
        internal JobHistoryDefinition(ResourceIdentifier id, string name, ResourceType type, JobHistoryDefinitionProperties properties) : base(id, name, type)
        {
            Properties = properties;
        }

        /// <summary> Gets or sets the job history properties. </summary>
        public JobHistoryDefinitionProperties Properties { get; }
    }
}
