// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class UploadCertificateResponse
    {
        internal static UploadCertificateResponse DeserializeUploadCertificateResponse(JsonElement element)
        {
            Optional<DataBoxEdgeAuthenticationType> authType = default;
            Optional<string> resourceId = default;
            Optional<string> aadAuthority = default;
            Optional<Guid> aadTenantId = default;
            Optional<Guid> servicePrincipalClientId = default;
            Optional<Guid> servicePrincipalObjectId = default;
            Optional<string> azureManagementEndpointAudience = default;
            Optional<string> aadAudience = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    authType = new DataBoxEdgeAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadAuthority"))
                {
                    aadAuthority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadTenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    aadTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("servicePrincipalClientId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    servicePrincipalClientId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("servicePrincipalObjectId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    servicePrincipalObjectId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("azureManagementEndpointAudience"))
                {
                    azureManagementEndpointAudience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aadAudience"))
                {
                    aadAudience = property.Value.GetString();
                    continue;
                }
            }
            return new UploadCertificateResponse(Optional.ToNullable(authType), resourceId.Value, aadAuthority.Value, Optional.ToNullable(aadTenantId), Optional.ToNullable(servicePrincipalClientId), Optional.ToNullable(servicePrincipalObjectId), azureManagementEndpointAudience.Value, aadAudience.Value);
        }
    }
}
