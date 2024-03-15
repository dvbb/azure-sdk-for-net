// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> API route config of the Spring Cloud Gateway. </summary>
    public partial class AppPlatformGatewayRouteConfigProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformGatewayRouteConfigProperties"/>. </summary>
        public AppPlatformGatewayRouteConfigProperties()
        {
            Routes = new ChangeTrackingList<AppPlatformGatewayApiRoute>();
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformGatewayRouteConfigProperties"/>. </summary>
        /// <param name="provisioningState"> State of the Spring Cloud Gateway route config. </param>
        /// <param name="appResourceId"> The resource Id of the Azure Spring Apps app, required unless route defines `uri`. </param>
        /// <param name="openApi"> OpenAPI properties of Spring Cloud Gateway route config. </param>
        /// <param name="protocol"> Protocol of routed Azure Spring Apps applications. </param>
        /// <param name="routes"> Array of API routes, each route contains properties such as `title`, `uri`, `ssoEnabled`, `predicates`, `filters`. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformGatewayRouteConfigProperties(AppPlatformGatewayProvisioningState? provisioningState, ResourceIdentifier appResourceId, GatewayRouteConfigOpenApiProperties openApi, AppPlatformGatewayRouteConfigProtocol? protocol, IList<AppPlatformGatewayApiRoute> routes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            AppResourceId = appResourceId;
            OpenApi = openApi;
            Protocol = protocol;
            Routes = routes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> State of the Spring Cloud Gateway route config. </summary>
        public AppPlatformGatewayProvisioningState? ProvisioningState { get; }
        /// <summary> The resource Id of the Azure Spring Apps app, required unless route defines `uri`. </summary>
        public ResourceIdentifier AppResourceId { get; set; }
        /// <summary> OpenAPI properties of Spring Cloud Gateway route config. </summary>
        internal GatewayRouteConfigOpenApiProperties OpenApi { get; set; }
        /// <summary> The URI of OpenAPI specification. </summary>
        public Uri OpenApiUri
        {
            get => OpenApi is null ? default : OpenApi.Uri;
            set
            {
                if (OpenApi is null)
                    OpenApi = new GatewayRouteConfigOpenApiProperties();
                OpenApi.Uri = value;
            }
        }

        /// <summary> Protocol of routed Azure Spring Apps applications. </summary>
        public AppPlatformGatewayRouteConfigProtocol? Protocol { get; set; }
        /// <summary> Array of API routes, each route contains properties such as `title`, `uri`, `ssoEnabled`, `predicates`, `filters`. </summary>
        public IList<AppPlatformGatewayApiRoute> Routes { get; }
    }
}
