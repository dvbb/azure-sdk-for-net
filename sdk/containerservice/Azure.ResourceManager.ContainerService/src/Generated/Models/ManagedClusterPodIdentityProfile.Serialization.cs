// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterPodIdentityProfile : IUtf8JsonSerializable, IJsonModel<ManagedClusterPodIdentityProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterPodIdentityProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterPodIdentityProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterPodIdentityProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(AllowNetworkPluginKubenet))
            {
                writer.WritePropertyName("allowNetworkPluginKubenet"u8);
                writer.WriteBooleanValue(AllowNetworkPluginKubenet.Value);
            }
            if (Optional.IsCollectionDefined(UserAssignedIdentities))
            {
                writer.WritePropertyName("userAssignedIdentities"u8);
                writer.WriteStartArray();
                foreach (var item in UserAssignedIdentities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserAssignedIdentityExceptions))
            {
                writer.WritePropertyName("userAssignedIdentityExceptions"u8);
                writer.WriteStartArray();
                foreach (var item in UserAssignedIdentityExceptions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        ManagedClusterPodIdentityProfile IJsonModel<ManagedClusterPodIdentityProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterPodIdentityProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterPodIdentityProfile(document.RootElement, options);
        }

        internal static ManagedClusterPodIdentityProfile DeserializeManagedClusterPodIdentityProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<bool> allowNetworkPluginKubenet = default;
            Optional<IList<ManagedClusterPodIdentity>> userAssignedIdentities = default;
            Optional<IList<ManagedClusterPodIdentityException>> userAssignedIdentityExceptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowNetworkPluginKubenet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowNetworkPluginKubenet = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("userAssignedIdentities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedClusterPodIdentity> array = new List<ManagedClusterPodIdentity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedClusterPodIdentity.DeserializeManagedClusterPodIdentity(item, options));
                    }
                    userAssignedIdentities = array;
                    continue;
                }
                if (property.NameEquals("userAssignedIdentityExceptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedClusterPodIdentityException> array = new List<ManagedClusterPodIdentityException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedClusterPodIdentityException.DeserializeManagedClusterPodIdentityException(item, options));
                    }
                    userAssignedIdentityExceptions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterPodIdentityProfile(Optional.ToNullable(enabled), Optional.ToNullable(allowNetworkPluginKubenet), Optional.ToList(userAssignedIdentities), Optional.ToList(userAssignedIdentityExceptions), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterPodIdentityProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterPodIdentityProfile)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterPodIdentityProfile IPersistableModel<ManagedClusterPodIdentityProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterPodIdentityProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterPodIdentityProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterPodIdentityProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
