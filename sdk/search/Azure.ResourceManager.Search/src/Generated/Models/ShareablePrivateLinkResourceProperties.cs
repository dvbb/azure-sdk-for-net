// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Describes the properties of a resource type that has been onboarded to private link service, supported by Azure Cognitive Search. </summary>
    public partial class ShareablePrivateLinkResourceProperties
    {
        /// <summary> Initializes a new instance of ShareablePrivateLinkResourceProperties. </summary>
        internal ShareablePrivateLinkResourceProperties()
        {
        }

        /// <summary> Initializes a new instance of ShareablePrivateLinkResourceProperties. </summary>
        /// <param name="type"> The resource provider type for the resource that has been onboarded to private link service, supported by Azure Cognitive Search. </param>
        /// <param name="groupId"> The resource provider group id for the resource that has been onboarded to private link service, supported by Azure Cognitive Search. </param>
        /// <param name="description"> The description of the resource type that has been onboarded to private link service, supported by Azure Cognitive Search. </param>
        internal ShareablePrivateLinkResourceProperties(string type, string groupId, string description)
        {
            Type = type;
            GroupId = groupId;
            Description = description;
        }

        /// <summary> The resource provider type for the resource that has been onboarded to private link service, supported by Azure Cognitive Search. </summary>
        public string Type { get; }
        /// <summary> The resource provider group id for the resource that has been onboarded to private link service, supported by Azure Cognitive Search. </summary>
        public string GroupId { get; }
        /// <summary> The description of the resource type that has been onboarded to private link service, supported by Azure Cognitive Search. </summary>
        public string Description { get; }
    }
}
