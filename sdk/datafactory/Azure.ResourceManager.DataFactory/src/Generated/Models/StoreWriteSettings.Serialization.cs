// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class StoreWriteSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections");
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection");
                writer.WriteObjectValue(DisableMetricsCollection);
            }
            if (Optional.IsDefined(CopyBehavior))
            {
                writer.WritePropertyName("copyBehavior");
                writer.WriteObjectValue(CopyBehavior);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static StoreWriteSettings DeserializeStoreWriteSettings(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBlobFSWriteSettings": return AzureBlobFSWriteSettings.DeserializeAzureBlobFSWriteSettings(element);
                    case "AzureBlobStorageWriteSettings": return AzureBlobStorageWriteSettings.DeserializeAzureBlobStorageWriteSettings(element);
                    case "AzureDataLakeStoreWriteSettings": return AzureDataLakeStoreWriteSettings.DeserializeAzureDataLakeStoreWriteSettings(element);
                    case "AzureFileStorageWriteSettings": return AzureFileStorageWriteSettings.DeserializeAzureFileStorageWriteSettings(element);
                    case "FileServerWriteSettings": return FileServerWriteSettings.DeserializeFileServerWriteSettings(element);
                    case "SftpWriteSettings": return SftpWriteSettings.DeserializeSftpWriteSettings(element);
                }
            }
            string type = default;
            Optional<object> maxConcurrentConnections = default;
            Optional<object> disableMetricsCollection = default;
            Optional<object> copyBehavior = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableMetricsCollection = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("copyBehavior"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    copyBehavior = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new StoreWriteSettings(type, maxConcurrentConnections.Value, disableMetricsCollection.Value, copyBehavior.Value, additionalProperties);
        }
    }
}
