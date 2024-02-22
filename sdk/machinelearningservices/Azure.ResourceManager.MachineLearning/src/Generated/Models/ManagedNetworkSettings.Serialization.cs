// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ManagedNetworkSettings : IUtf8JsonSerializable, IJsonModel<ManagedNetworkSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedNetworkSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedNetworkSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedNetworkSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsolationMode))
            {
                writer.WritePropertyName("isolationMode"u8);
                writer.WriteStringValue(IsolationMode.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(NetworkId))
            {
                writer.WritePropertyName("networkId"u8);
                writer.WriteStringValue(NetworkId);
            }
            if (Optional.IsCollectionDefined(OutboundRules))
            {
                if (OutboundRules != null)
                {
                    writer.WritePropertyName("outboundRules"u8);
                    writer.WriteStartObject();
                    foreach (var item in OutboundRules)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("outboundRules");
                }
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
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

        ManagedNetworkSettings IJsonModel<ManagedNetworkSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedNetworkSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedNetworkSettings(document.RootElement, options);
        }

        internal static ManagedNetworkSettings DeserializeManagedNetworkSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IsolationMode> isolationMode = default;
            Optional<string> networkId = default;
            Optional<IDictionary<string, MachineLearningOutboundRule>> outboundRules = default;
            Optional<ManagedNetworkProvisionStatus> status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isolationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isolationMode = new IsolationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkId"u8))
                {
                    networkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outboundRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        outboundRules = null;
                        continue;
                    }
                    Dictionary<string, MachineLearningOutboundRule> dictionary = new Dictionary<string, MachineLearningOutboundRule>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MachineLearningOutboundRule.DeserializeMachineLearningOutboundRule(property0.Value, options));
                    }
                    outboundRules = dictionary;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ManagedNetworkProvisionStatus.DeserializeManagedNetworkProvisionStatus(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedNetworkSettings(Optional.ToNullable(isolationMode), networkId.Value, Optional.ToDictionary(outboundRules), status.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedNetworkSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedNetworkSettings)} does not support '{options.Format}' format.");
            }
        }

        ManagedNetworkSettings IPersistableModel<ManagedNetworkSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedNetworkSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedNetworkSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedNetworkSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedNetworkSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
