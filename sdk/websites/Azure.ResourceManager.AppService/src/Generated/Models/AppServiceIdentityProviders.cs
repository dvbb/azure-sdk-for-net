// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of each of the identity providers used to configure App Service Authentication/Authorization. </summary>
    public partial class AppServiceIdentityProviders
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

        /// <summary> Initializes a new instance of <see cref="AppServiceIdentityProviders"/>. </summary>
        public AppServiceIdentityProviders()
        {
            CustomOpenIdConnectProviders = new ChangeTrackingDictionary<string, CustomOpenIdConnectProvider>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceIdentityProviders"/>. </summary>
        /// <param name="azureActiveDirectory"> The configuration settings of the Azure Active directory provider. </param>
        /// <param name="facebook"> The configuration settings of the Facebook provider. </param>
        /// <param name="gitHub"> The configuration settings of the GitHub provider. </param>
        /// <param name="google"> The configuration settings of the Google provider. </param>
        /// <param name="legacyMicrosoftAccount"> The configuration settings of the legacy Microsoft Account provider. </param>
        /// <param name="twitter"> The configuration settings of the Twitter provider. </param>
        /// <param name="apple"> The configuration settings of the Apple provider. </param>
        /// <param name="azureStaticWebApps"> The configuration settings of the Azure Static Web Apps provider. </param>
        /// <param name="customOpenIdConnectProviders">
        /// The map of the name of the alias of each custom Open ID Connect provider to the
        /// configuration settings of the custom Open ID Connect provider.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceIdentityProviders(AppServiceAadProvider azureActiveDirectory, AppServiceFacebookProvider facebook, AppServiceGitHubProvider gitHub, AppServiceGoogleProvider google, LegacyMicrosoftAccount legacyMicrosoftAccount, AppServiceTwitterProvider twitter, AppServiceAppleProvider apple, AppServiceStaticWebAppsProvider azureStaticWebApps, IDictionary<string, CustomOpenIdConnectProvider> customOpenIdConnectProviders, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AzureActiveDirectory = azureActiveDirectory;
            Facebook = facebook;
            GitHub = gitHub;
            Google = google;
            LegacyMicrosoftAccount = legacyMicrosoftAccount;
            Twitter = twitter;
            Apple = apple;
            AzureStaticWebApps = azureStaticWebApps;
            CustomOpenIdConnectProviders = customOpenIdConnectProviders;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The configuration settings of the Azure Active directory provider. </summary>
        public AppServiceAadProvider AzureActiveDirectory { get; set; }
        /// <summary> The configuration settings of the Facebook provider. </summary>
        public AppServiceFacebookProvider Facebook { get; set; }
        /// <summary> The configuration settings of the GitHub provider. </summary>
        public AppServiceGitHubProvider GitHub { get; set; }
        /// <summary> The configuration settings of the Google provider. </summary>
        public AppServiceGoogleProvider Google { get; set; }
        /// <summary> The configuration settings of the legacy Microsoft Account provider. </summary>
        public LegacyMicrosoftAccount LegacyMicrosoftAccount { get; set; }
        /// <summary> The configuration settings of the Twitter provider. </summary>
        public AppServiceTwitterProvider Twitter { get; set; }
        /// <summary> The configuration settings of the Apple provider. </summary>
        public AppServiceAppleProvider Apple { get; set; }
        /// <summary> The configuration settings of the Azure Static Web Apps provider. </summary>
        public AppServiceStaticWebAppsProvider AzureStaticWebApps { get; set; }
        /// <summary>
        /// The map of the name of the alias of each custom Open ID Connect provider to the
        /// configuration settings of the custom Open ID Connect provider.
        /// </summary>
        public IDictionary<string, CustomOpenIdConnectProvider> CustomOpenIdConnectProviders { get; }
    }
}
