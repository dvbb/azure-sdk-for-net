// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class AuthBaseInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("authType");
            writer.WriteStringValue(AuthType.ToString());
            writer.WriteEndObject();
        }

        internal static AuthBaseInfo DeserializeAuthBaseInfo(JsonElement element)
        {
            if (element.TryGetProperty("authType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "secret": return SecretAuthInfo.DeserializeSecretAuthInfo(element);
                    case "servicePrincipalCertificate": return ServicePrincipalCertificateAuthInfo.DeserializeServicePrincipalCertificateAuthInfo(element);
                    case "servicePrincipalSecret": return ServicePrincipalSecretAuthInfo.DeserializeServicePrincipalSecretAuthInfo(element);
                    case "systemAssignedIdentity": return SystemAssignedIdentityAuthInfo.DeserializeSystemAssignedIdentityAuthInfo(element);
                    case "userAssignedIdentity": return UserAssignedIdentityAuthInfo.DeserializeUserAssignedIdentityAuthInfo(element);
                }
            }
            LinkerAuthType authType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authType"))
                {
                    authType = new LinkerAuthType(property.Value.GetString());
                    continue;
                }
            }
            return new AuthBaseInfo(authType);
        }
    }
}
