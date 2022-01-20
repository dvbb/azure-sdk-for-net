// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class EncryptionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("vaultBaseUrl");
            writer.WriteStringValue(VaultBaseUrl);
            writer.WritePropertyName("keyName");
            writer.WriteStringValue(KeyName);
            writer.WritePropertyName("keyVersion");
            writer.WriteStringValue(KeyVersion);
            writer.WriteEndObject();
        }

        internal static EncryptionProperties DeserializeEncryptionProperties(JsonElement element)
        {
            string vaultBaseUrl = default;
            string keyName = default;
            string keyVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vaultBaseUrl"))
                {
                    vaultBaseUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyName"))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVersion"))
                {
                    keyVersion = property.Value.GetString();
                    continue;
                }
            }
            return new EncryptionProperties(vaultBaseUrl, keyName, keyVersion);
        }
    }
}
