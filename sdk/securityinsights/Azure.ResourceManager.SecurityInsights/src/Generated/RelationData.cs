// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary> A class representing the Relation data model. </summary>
    public partial class RelationData : ResourceWithEtag
    {
        /// <summary> Initializes a new instance of RelationData. </summary>
        public RelationData()
        {
        }

        /// <summary> Initializes a new instance of RelationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="relatedResourceId"> The resource ID of the related resource. </param>
        /// <param name="relatedResourceName"> The name of the related resource. </param>
        /// <param name="relatedResourceType"> The resource type of the related resource. </param>
        /// <param name="relatedResourceKind"> The resource kind of the related resource. </param>
        internal RelationData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string etag, string relatedResourceId, string relatedResourceName, string relatedResourceType, string relatedResourceKind) : base(id, name, type, systemData, etag)
        {
            RelatedResourceId = relatedResourceId;
            RelatedResourceName = relatedResourceName;
            RelatedResourceType = relatedResourceType;
            RelatedResourceKind = relatedResourceKind;
        }

        /// <summary> The resource ID of the related resource. </summary>
        public string RelatedResourceId { get; set; }
        /// <summary> The name of the related resource. </summary>
        public string RelatedResourceName { get; }
        /// <summary> The resource type of the related resource. </summary>
        public string RelatedResourceType { get; }
        /// <summary> The resource kind of the related resource. </summary>
        public string RelatedResourceKind { get; }
    }
}
