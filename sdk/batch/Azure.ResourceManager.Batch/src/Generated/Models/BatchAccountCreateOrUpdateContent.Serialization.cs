// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAccountCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<BatchAccountCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchAccountCreateOrUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchAccountCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountCreateOrUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoStorage))
            {
                writer.WritePropertyName("autoStorage"u8);
                writer.WriteObjectValue(AutoStorage);
            }
            if (Optional.IsDefined(PoolAllocationMode))
            {
                writer.WritePropertyName("poolAllocationMode"u8);
                writer.WriteStringValue(PoolAllocationMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(KeyVaultReference))
            {
                writer.WritePropertyName("keyVaultReference"u8);
                writer.WriteObjectValue(KeyVaultReference);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToSerialString());
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsCollectionDefined(AllowedAuthenticationModes))
            {
                if (AllowedAuthenticationModes != null)
                {
                    writer.WritePropertyName("allowedAuthenticationModes"u8);
                    writer.WriteStartArray();
                    foreach (var item in AllowedAuthenticationModes)
                    {
                        writer.WriteStringValue(item.ToSerialString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("allowedAuthenticationModes");
                }
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        BatchAccountCreateOrUpdateContent IJsonModel<BatchAccountCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAccountCreateOrUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAccountCreateOrUpdateContent(document.RootElement, options);
        }

        internal static BatchAccountCreateOrUpdateContent DeserializeBatchAccountCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<BatchAccountAutoStorageBaseConfiguration> autoStorage = default;
            Optional<BatchAccountPoolAllocationMode> poolAllocationMode = default;
            Optional<BatchKeyVaultReference> keyVaultReference = default;
            Optional<BatchPublicNetworkAccess> publicNetworkAccess = default;
            Optional<BatchNetworkProfile> networkProfile = default;
            Optional<BatchAccountEncryptionConfiguration> encryption = default;
            Optional<IList<BatchAuthenticationMode>> allowedAuthenticationModes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("autoStorage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoStorage = BatchAccountAutoStorageBaseConfiguration.DeserializeBatchAccountAutoStorageBaseConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("poolAllocationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            poolAllocationMode = property0.Value.GetString().ToBatchAccountPoolAllocationMode();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultReference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyVaultReference = BatchKeyVaultReference.DeserializeBatchKeyVaultReference(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = property0.Value.GetString().ToBatchPublicNetworkAccess();
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkProfile = BatchNetworkProfile.DeserializeBatchNetworkProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = BatchAccountEncryptionConfiguration.DeserializeBatchAccountEncryptionConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("allowedAuthenticationModes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                allowedAuthenticationModes = null;
                                continue;
                            }
                            List<BatchAuthenticationMode> array = new List<BatchAuthenticationMode>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString().ToBatchAuthenticationMode());
                            }
                            allowedAuthenticationModes = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchAccountCreateOrUpdateContent(location, Optional.ToDictionary(tags), identity, autoStorage.Value, Optional.ToNullable(poolAllocationMode), keyVaultReference.Value, Optional.ToNullable(publicNetworkAccess), networkProfile.Value, encryption.Value, Optional.ToList(allowedAuthenticationModes), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchAccountCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchAccountCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        BatchAccountCreateOrUpdateContent IPersistableModel<BatchAccountCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAccountCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchAccountCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchAccountCreateOrUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchAccountCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
