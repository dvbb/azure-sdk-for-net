// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Rest Service linked service. </summary>
    public partial class RestServiceLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of RestServiceLinkedService. </summary>
        /// <param name="url"> The base URL of the REST service. </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the REST service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        public RestServiceLinkedService(object url, RestServiceAuthenticationType authenticationType)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            Url = url;
            AuthenticationType = authenticationType;
            Type = "RestService";
        }

        /// <summary> Initializes a new instance of RestServiceLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="url"> The base URL of the REST service. </param>
        /// <param name="enableServerCertificateValidation"> Whether to validate server side SSL certificate when connecting to the endpoint.The default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the REST service. </param>
        /// <param name="userName"> The user name used in Basic authentication type. </param>
        /// <param name="password"> The password used in Basic authentication type. </param>
        /// <param name="authHeaders"> The additional HTTP headers in the request to RESTful API used for authorization. Type: object (or Expression with resultType object). </param>
        /// <param name="servicePrincipalId"> The application&apos;s client ID used in AadServicePrincipal authentication type. </param>
        /// <param name="servicePrincipalKey"> The application&apos;s key used in AadServicePrincipal authentication type. </param>
        /// <param name="tenant"> The tenant information (domain name or tenant ID) used in AadServicePrincipal authentication type under which your application resides. </param>
        /// <param name="azureCloudType"> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </param>
        /// <param name="aadResourceId"> The resource you are requesting authorization to use. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal RestServiceLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object url, object enableServerCertificateValidation, RestServiceAuthenticationType authenticationType, object userName, SecretBase password, object authHeaders, object servicePrincipalId, SecretBase servicePrincipalKey, object tenant, object azureCloudType, object aadResourceId, object encryptedCredential, CredentialReference credential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Url = url;
            EnableServerCertificateValidation = enableServerCertificateValidation;
            AuthenticationType = authenticationType;
            UserName = userName;
            Password = password;
            AuthHeaders = authHeaders;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            AzureCloudType = azureCloudType;
            AadResourceId = aadResourceId;
            EncryptedCredential = encryptedCredential;
            Credential = credential;
            Type = type ?? "RestService";
        }

        /// <summary> The base URL of the REST service. </summary>
        public object Url { get; set; }
        /// <summary> Whether to validate server side SSL certificate when connecting to the endpoint.The default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public object EnableServerCertificateValidation { get; set; }
        /// <summary> Type of authentication used to connect to the REST service. </summary>
        public RestServiceAuthenticationType AuthenticationType { get; set; }
        /// <summary> The user name used in Basic authentication type. </summary>
        public object UserName { get; set; }
        /// <summary> The password used in Basic authentication type. </summary>
        public SecretBase Password { get; set; }
        /// <summary> The additional HTTP headers in the request to RESTful API used for authorization. Type: object (or Expression with resultType object). </summary>
        public object AuthHeaders { get; set; }
        /// <summary> The application&apos;s client ID used in AadServicePrincipal authentication type. </summary>
        public object ServicePrincipalId { get; set; }
        /// <summary> The application&apos;s key used in AadServicePrincipal authentication type. </summary>
        public SecretBase ServicePrincipalKey { get; set; }
        /// <summary> The tenant information (domain name or tenant ID) used in AadServicePrincipal authentication type under which your application resides. </summary>
        public object Tenant { get; set; }
        /// <summary> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </summary>
        public object AzureCloudType { get; set; }
        /// <summary> The resource you are requesting authorization to use. </summary>
        public object AadResourceId { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public CredentialReference Credential { get; set; }
    }
}
