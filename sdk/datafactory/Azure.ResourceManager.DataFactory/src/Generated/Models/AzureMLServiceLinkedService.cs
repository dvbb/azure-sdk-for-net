// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure ML Service linked service. </summary>
    public partial class AzureMLServiceLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of AzureMLServiceLinkedService. </summary>
        /// <param name="subscriptionId"> Azure ML Service workspace subscription ID. Type: string (or Expression with resultType string). </param>
        /// <param name="resourceGroupName"> Azure ML Service workspace resource group name. Type: string (or Expression with resultType string). </param>
        /// <param name="mlWorkspaceName"> Azure ML Service workspace name. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="mlWorkspaceName"/> is null. </exception>
        public AzureMLServiceLinkedService(object subscriptionId, object resourceGroupName, object mlWorkspaceName)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (mlWorkspaceName == null)
            {
                throw new ArgumentNullException(nameof(mlWorkspaceName));
            }

            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            MlWorkspaceName = mlWorkspaceName;
            Type = "AzureMLService";
        }

        /// <summary> Initializes a new instance of AzureMLServiceLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="subscriptionId"> Azure ML Service workspace subscription ID. Type: string (or Expression with resultType string). </param>
        /// <param name="resourceGroupName"> Azure ML Service workspace resource group name. Type: string (or Expression with resultType string). </param>
        /// <param name="mlWorkspaceName"> Azure ML Service workspace name. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> The ID of the service principal used to authenticate against the endpoint of a published Azure ML Service pipeline. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> The key of the service principal used to authenticate against the endpoint of a published Azure ML Service pipeline. </param>
        /// <param name="tenant"> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal AzureMLServiceLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object subscriptionId, object resourceGroupName, object mlWorkspaceName, object servicePrincipalId, SecretBase servicePrincipalKey, object tenant, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            MlWorkspaceName = mlWorkspaceName;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "AzureMLService";
        }

        /// <summary> Azure ML Service workspace subscription ID. Type: string (or Expression with resultType string). </summary>
        public object SubscriptionId { get; set; }
        /// <summary> Azure ML Service workspace resource group name. Type: string (or Expression with resultType string). </summary>
        public object ResourceGroupName { get; set; }
        /// <summary> Azure ML Service workspace name. Type: string (or Expression with resultType string). </summary>
        public object MlWorkspaceName { get; set; }
        /// <summary> The ID of the service principal used to authenticate against the endpoint of a published Azure ML Service pipeline. Type: string (or Expression with resultType string). </summary>
        public object ServicePrincipalId { get; set; }
        /// <summary> The key of the service principal used to authenticate against the endpoint of a published Azure ML Service pipeline. </summary>
        public SecretBase ServicePrincipalKey { get; set; }
        /// <summary> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </summary>
        public object Tenant { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
