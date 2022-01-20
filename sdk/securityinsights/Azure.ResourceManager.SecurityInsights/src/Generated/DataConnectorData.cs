// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary> A class representing the DataConnector data model. </summary>
    public partial class DataConnectorData : ResourceWithEtag
    {
        /// <summary> Initializes a new instance of DataConnectorData. </summary>
        public DataConnectorData()
        {
            Kind = new DataConnectorKind("DataConnector");
        }

        /// <summary> Initializes a new instance of DataConnectorData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="kind"> The data connector kind. </param>
        internal DataConnectorData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string etag, DataConnectorKind kind) : base(id, name, type, systemData, etag)
        {
            Kind = kind;
        }

        /// <summary> The data connector kind. </summary>
        internal DataConnectorKind Kind { get; set; }
    }
}
