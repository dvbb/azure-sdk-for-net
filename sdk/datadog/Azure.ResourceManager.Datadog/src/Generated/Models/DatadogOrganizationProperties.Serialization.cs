// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    public partial class DatadogOrganizationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkingAuthCode))
            {
                writer.WritePropertyName("linkingAuthCode");
                writer.WriteStringValue(LinkingAuthCode);
            }
            if (Optional.IsDefined(LinkingClientId))
            {
                writer.WritePropertyName("linkingClientId");
                writer.WriteStringValue(LinkingClientId);
            }
            if (Optional.IsDefined(RedirectUri))
            {
                writer.WritePropertyName("redirectUri");
                writer.WriteStringValue(RedirectUri);
            }
            if (Optional.IsDefined(ApiKey))
            {
                writer.WritePropertyName("apiKey");
                writer.WriteStringValue(ApiKey);
            }
            if (Optional.IsDefined(ApplicationKey))
            {
                writer.WritePropertyName("applicationKey");
                writer.WriteStringValue(ApplicationKey);
            }
            if (Optional.IsDefined(EnterpriseAppId))
            {
                writer.WritePropertyName("enterpriseAppId");
                writer.WriteStringValue(EnterpriseAppId);
            }
            writer.WriteEndObject();
        }

        internal static DatadogOrganizationProperties DeserializeDatadogOrganizationProperties(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<string> linkingAuthCode = default;
            Optional<string> linkingClientId = default;
            Optional<string> redirectUri = default;
            Optional<string> apiKey = default;
            Optional<string> applicationKey = default;
            Optional<string> enterpriseAppId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkingAuthCode"))
                {
                    linkingAuthCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("linkingClientId"))
                {
                    linkingClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("redirectUri"))
                {
                    redirectUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiKey"))
                {
                    apiKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationKey"))
                {
                    applicationKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enterpriseAppId"))
                {
                    enterpriseAppId = property.Value.GetString();
                    continue;
                }
            }
            return new DatadogOrganizationProperties(name.Value, id.Value, linkingAuthCode.Value, linkingClientId.Value, redirectUri.Value, apiKey.Value, applicationKey.Value, enterpriseAppId.Value);
        }
    }
}
