// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.TrafficManager.Models
{
    public partial class TrafficManagerHeatMapTrafficFlow : IUtf8JsonSerializable, IJsonModel<TrafficManagerHeatMapTrafficFlow>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrafficManagerHeatMapTrafficFlow>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TrafficManagerHeatMapTrafficFlow>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerHeatMapTrafficFlow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficManagerHeatMapTrafficFlow)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SourceIP))
            {
                writer.WritePropertyName("sourceIp"u8);
                writer.WriteStringValue(SourceIP.ToString());
            }
            if (Optional.IsDefined(Latitude))
            {
                writer.WritePropertyName("latitude"u8);
                writer.WriteNumberValue(Latitude.Value);
            }
            if (Optional.IsDefined(Longitude))
            {
                writer.WritePropertyName("longitude"u8);
                writer.WriteNumberValue(Longitude.Value);
            }
            if (Optional.IsCollectionDefined(QueryExperiences))
            {
                writer.WritePropertyName("queryExperiences"u8);
                writer.WriteStartArray();
                foreach (var item in QueryExperiences)
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

        TrafficManagerHeatMapTrafficFlow IJsonModel<TrafficManagerHeatMapTrafficFlow>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerHeatMapTrafficFlow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficManagerHeatMapTrafficFlow)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficManagerHeatMapTrafficFlow(document.RootElement, options);
        }

        internal static TrafficManagerHeatMapTrafficFlow DeserializeTrafficManagerHeatMapTrafficFlow(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IPAddress> sourceIP = default;
            Optional<double> latitude = default;
            Optional<double> longitude = default;
            Optional<IList<TrafficManagerHeatMapQueryExperience>> queryExperiences = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceIp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceIP = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("latitude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latitude = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("longitude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    longitude = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("queryExperiences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TrafficManagerHeatMapQueryExperience> array = new List<TrafficManagerHeatMapQueryExperience>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TrafficManagerHeatMapQueryExperience.DeserializeTrafficManagerHeatMapQueryExperience(item, options));
                    }
                    queryExperiences = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TrafficManagerHeatMapTrafficFlow(sourceIP.Value, Optional.ToNullable(latitude), Optional.ToNullable(longitude), Optional.ToList(queryExperiences), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TrafficManagerHeatMapTrafficFlow>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerHeatMapTrafficFlow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrafficManagerHeatMapTrafficFlow)} does not support '{options.Format}' format.");
            }
        }

        TrafficManagerHeatMapTrafficFlow IPersistableModel<TrafficManagerHeatMapTrafficFlow>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerHeatMapTrafficFlow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrafficManagerHeatMapTrafficFlow(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrafficManagerHeatMapTrafficFlow)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrafficManagerHeatMapTrafficFlow>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
