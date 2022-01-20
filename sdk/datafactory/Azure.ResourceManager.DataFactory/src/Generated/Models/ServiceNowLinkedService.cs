// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> ServiceNow server linked service. </summary>
    public partial class ServiceNowLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of ServiceNowLinkedService. </summary>
        /// <param name="endpoint"> The endpoint of the ServiceNow server. (i.e. &lt;instance&gt;.service-now.com). </param>
        /// <param name="authenticationType"> The authentication type to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public ServiceNowLinkedService(object endpoint, ServiceNowAuthenticationType authenticationType)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }

            Endpoint = endpoint;
            AuthenticationType = authenticationType;
            Type = "ServiceNow";
        }

        /// <summary> Initializes a new instance of ServiceNowLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="endpoint"> The endpoint of the ServiceNow server. (i.e. &lt;instance&gt;.service-now.com). </param>
        /// <param name="authenticationType"> The authentication type to use. </param>
        /// <param name="username"> The user name used to connect to the ServiceNow server for Basic and OAuth2 authentication. </param>
        /// <param name="password"> The password corresponding to the user name for Basic and OAuth2 authentication. </param>
        /// <param name="clientId"> The client id for OAuth2 authentication. </param>
        /// <param name="clientSecret"> The client secret for OAuth2 authentication. </param>
        /// <param name="useEncryptedEndpoints"> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </param>
        /// <param name="useHostVerification"> Specifies whether to require the host name in the server&apos;s certificate to match the host name of the server when connecting over SSL. The default value is true. </param>
        /// <param name="usePeerVerification"> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal ServiceNowLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object endpoint, ServiceNowAuthenticationType authenticationType, object username, SecretBase password, object clientId, SecretBase clientSecret, object useEncryptedEndpoints, object useHostVerification, object usePeerVerification, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Endpoint = endpoint;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            ClientId = clientId;
            ClientSecret = clientSecret;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "ServiceNow";
        }

        /// <summary> The endpoint of the ServiceNow server. (i.e. &lt;instance&gt;.service-now.com). </summary>
        public object Endpoint { get; set; }
        /// <summary> The authentication type to use. </summary>
        public ServiceNowAuthenticationType AuthenticationType { get; set; }
        /// <summary> The user name used to connect to the ServiceNow server for Basic and OAuth2 authentication. </summary>
        public object Username { get; set; }
        /// <summary> The password corresponding to the user name for Basic and OAuth2 authentication. </summary>
        public SecretBase Password { get; set; }
        /// <summary> The client id for OAuth2 authentication. </summary>
        public object ClientId { get; set; }
        /// <summary> The client secret for OAuth2 authentication. </summary>
        public SecretBase ClientSecret { get; set; }
        /// <summary> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </summary>
        public object UseEncryptedEndpoints { get; set; }
        /// <summary> Specifies whether to require the host name in the server&apos;s certificate to match the host name of the server when connecting over SSL. The default value is true. </summary>
        public object UseHostVerification { get; set; }
        /// <summary> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </summary>
        public object UsePeerVerification { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
