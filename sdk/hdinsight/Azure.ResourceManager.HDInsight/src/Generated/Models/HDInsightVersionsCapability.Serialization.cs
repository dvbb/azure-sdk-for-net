// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightVersionsCapability : IUtf8JsonSerializable, IJsonModel<HDInsightVersionsCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightVersionsCapability>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightVersionsCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightVersionsCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightVersionsCapability)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Available))
            {
                writer.WritePropertyName("available"u8);
                writer.WriteStartArray();
                foreach (var item in Available)
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

        HDInsightVersionsCapability IJsonModel<HDInsightVersionsCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightVersionsCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightVersionsCapability)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightVersionsCapability(document.RootElement, options);
        }

        internal static HDInsightVersionsCapability DeserializeHDInsightVersionsCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<HDInsightVersionSpec>> available = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("available"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightVersionSpec> array = new List<HDInsightVersionSpec>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightVersionSpec.DeserializeHDInsightVersionSpec(item, options));
                    }
                    available = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightVersionsCapability(Optional.ToList(available), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightVersionsCapability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightVersionsCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightVersionsCapability)} does not support '{options.Format}' format.");
            }
        }

        HDInsightVersionsCapability IPersistableModel<HDInsightVersionsCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightVersionsCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightVersionsCapability(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightVersionsCapability)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightVersionsCapability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
