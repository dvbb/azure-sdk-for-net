// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class IntegrationRuntimeConnectionInfo
    {
        internal static IntegrationRuntimeConnectionInfo DeserializeIntegrationRuntimeConnectionInfo(JsonElement element)
        {
            Optional<string> serviceToken = default;
            Optional<string> identityCertThumbprint = default;
            Optional<string> hostServiceUri = default;
            Optional<string> version = default;
            Optional<string> publicKey = default;
            Optional<bool> isIdentityCertExprired = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceToken"))
                {
                    serviceToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityCertThumbprint"))
                {
                    identityCertThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostServiceUri"))
                {
                    hostServiceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicKey"))
                {
                    publicKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isIdentityCertExprired"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isIdentityCertExprired = property.Value.GetBoolean();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeConnectionInfo(serviceToken.Value, identityCertThumbprint.Value, hostServiceUri.Value, version.Value, publicKey.Value, Optional.ToNullable(isIdentityCertExprired), additionalProperties);
        }
    }
}
