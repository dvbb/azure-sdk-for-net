// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class JitNetworkAccessPolicyInitiateVirtualMachine : IUtf8JsonSerializable, IJsonModel<JitNetworkAccessPolicyInitiateVirtualMachine>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JitNetworkAccessPolicyInitiateVirtualMachine>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JitNetworkAccessPolicyInitiateVirtualMachine>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessPolicyInitiateVirtualMachine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JitNetworkAccessPolicyInitiateVirtualMachine)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("ports"u8);
            writer.WriteStartArray();
            foreach (var item in Ports)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        JitNetworkAccessPolicyInitiateVirtualMachine IJsonModel<JitNetworkAccessPolicyInitiateVirtualMachine>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessPolicyInitiateVirtualMachine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JitNetworkAccessPolicyInitiateVirtualMachine)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJitNetworkAccessPolicyInitiateVirtualMachine(document.RootElement, options);
        }

        internal static JitNetworkAccessPolicyInitiateVirtualMachine DeserializeJitNetworkAccessPolicyInitiateVirtualMachine(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            IList<JitNetworkAccessPolicyInitiatePort> ports = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ports"u8))
                {
                    List<JitNetworkAccessPolicyInitiatePort> array = new List<JitNetworkAccessPolicyInitiatePort>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JitNetworkAccessPolicyInitiatePort.DeserializeJitNetworkAccessPolicyInitiatePort(item, options));
                    }
                    ports = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new JitNetworkAccessPolicyInitiateVirtualMachine(id, ports, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<JitNetworkAccessPolicyInitiateVirtualMachine>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessPolicyInitiateVirtualMachine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(JitNetworkAccessPolicyInitiateVirtualMachine)} does not support '{options.Format}' format.");
            }
        }

        JitNetworkAccessPolicyInitiateVirtualMachine IPersistableModel<JitNetworkAccessPolicyInitiateVirtualMachine>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessPolicyInitiateVirtualMachine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJitNetworkAccessPolicyInitiateVirtualMachine(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JitNetworkAccessPolicyInitiateVirtualMachine)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<JitNetworkAccessPolicyInitiateVirtualMachine>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
