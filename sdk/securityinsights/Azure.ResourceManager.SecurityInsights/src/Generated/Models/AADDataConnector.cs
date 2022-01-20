// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents AAD (Azure Active Directory) data connector. </summary>
    public partial class AADDataConnector : DataConnectorData
    {
        /// <summary> Initializes a new instance of AADDataConnector. </summary>
        public AADDataConnector()
        {
            Kind = DataConnectorKind.AzureActiveDirectory;
        }

        /// <summary> Initializes a new instance of AADDataConnector. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="kind"> The data connector kind. </param>
        /// <param name="tenantId"> The tenant id to connect to, and get the data from. </param>
        /// <param name="dataTypes"> The available data types for the connector. </param>
        internal AADDataConnector(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string etag, DataConnectorKind kind, string tenantId, AlertsDataTypeOfDataConnector dataTypes) : base(id, name, type, systemData, etag, kind)
        {
            TenantId = tenantId;
            DataTypes = dataTypes;
            Kind = kind;
        }

        /// <summary> The tenant id to connect to, and get the data from. </summary>
        public string TenantId { get; set; }
        /// <summary> The available data types for the connector. </summary>
        public AlertsDataTypeOfDataConnector DataTypes { get; set; }
    }
}
