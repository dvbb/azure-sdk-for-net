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
    public partial class AzureMLBatchInferencingServer : IUtf8JsonSerializable, IJsonModel<AzureMLBatchInferencingServer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureMLBatchInferencingServer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureMLBatchInferencingServer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLBatchInferencingServer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureMLBatchInferencingServer)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CodeConfiguration))
            {
                if (CodeConfiguration != null)
                {
                    writer.WritePropertyName("codeConfiguration"u8);
                    writer.WriteObjectValue(CodeConfiguration);
                }
                else
                {
                    writer.WriteNull("codeConfiguration");
                }
            }
            writer.WritePropertyName("serverType"u8);
            writer.WriteStringValue(ServerType.ToString());
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

        AzureMLBatchInferencingServer IJsonModel<AzureMLBatchInferencingServer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLBatchInferencingServer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureMLBatchInferencingServer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureMLBatchInferencingServer(document.RootElement, options);
        }

        internal static AzureMLBatchInferencingServer DeserializeAzureMLBatchInferencingServer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningCodeConfiguration> codeConfiguration = default;
            InferencingServerType serverType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("codeConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        codeConfiguration = null;
                        continue;
                    }
                    codeConfiguration = MachineLearningCodeConfiguration.DeserializeMachineLearningCodeConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("serverType"u8))
                {
                    serverType = new InferencingServerType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureMLBatchInferencingServer(serverType, serializedAdditionalRawData, codeConfiguration.Value);
        }

        BinaryData IPersistableModel<AzureMLBatchInferencingServer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLBatchInferencingServer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureMLBatchInferencingServer)} does not support '{options.Format}' format.");
            }
        }

        AzureMLBatchInferencingServer IPersistableModel<AzureMLBatchInferencingServer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMLBatchInferencingServer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureMLBatchInferencingServer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureMLBatchInferencingServer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureMLBatchInferencingServer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
