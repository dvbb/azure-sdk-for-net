// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class WafMetricsResponseSeriesItem : IUtf8JsonSerializable, IJsonModel<WafMetricsResponseSeriesItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WafMetricsResponseSeriesItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WafMetricsResponseSeriesItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WafMetricsResponseSeriesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WafMetricsResponseSeriesItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Metric))
            {
                writer.WritePropertyName("metric"u8);
                writer.WriteStringValue(Metric);
            }
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Groups))
            {
                if (Groups != null)
                {
                    writer.WritePropertyName("groups"u8);
                    writer.WriteStartArray();
                    foreach (var item in Groups)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("groups");
                }
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in Data)
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

        WafMetricsResponseSeriesItem IJsonModel<WafMetricsResponseSeriesItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WafMetricsResponseSeriesItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WafMetricsResponseSeriesItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWafMetricsResponseSeriesItem(document.RootElement, options);
        }

        internal static WafMetricsResponseSeriesItem DeserializeWafMetricsResponseSeriesItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> metric = default;
            Optional<WafMetricsResponseSeriesItemUnit> unit = default;
            Optional<IReadOnlyList<WafMetricsResponseSeriesPropertiesItemsItem>> groups = default;
            Optional<IReadOnlyList<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>> data = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metric"u8))
                {
                    metric = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    unit = new WafMetricsResponseSeriesItemUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("groups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        groups = null;
                        continue;
                    }
                    List<WafMetricsResponseSeriesPropertiesItemsItem> array = new List<WafMetricsResponseSeriesPropertiesItemsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WafMetricsResponseSeriesPropertiesItemsItem.DeserializeWafMetricsResponseSeriesPropertiesItemsItem(item, options));
                    }
                    groups = array;
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems> array = new List<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems.DeserializeComponents18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems(item, options));
                    }
                    data = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WafMetricsResponseSeriesItem(metric.Value, Optional.ToNullable(unit), Optional.ToList(groups), Optional.ToList(data), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WafMetricsResponseSeriesItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WafMetricsResponseSeriesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WafMetricsResponseSeriesItem)} does not support '{options.Format}' format.");
            }
        }

        WafMetricsResponseSeriesItem IPersistableModel<WafMetricsResponseSeriesItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WafMetricsResponseSeriesItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWafMetricsResponseSeriesItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WafMetricsResponseSeriesItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WafMetricsResponseSeriesItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
