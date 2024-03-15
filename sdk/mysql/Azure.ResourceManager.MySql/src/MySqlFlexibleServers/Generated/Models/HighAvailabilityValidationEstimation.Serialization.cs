// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class HighAvailabilityValidationEstimation : IUtf8JsonSerializable, IJsonModel<HighAvailabilityValidationEstimation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HighAvailabilityValidationEstimation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HighAvailabilityValidationEstimation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HighAvailabilityValidationEstimation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HighAvailabilityValidationEstimation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(EstimatedDowntime))
            {
                writer.WritePropertyName("estimatedDowntime"u8);
                writer.WriteNumberValue(EstimatedDowntime.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ScheduledStandbyAvailabilityZone))
            {
                writer.WritePropertyName("scheduledStandbyAvailabilityZone"u8);
                writer.WriteStringValue(ScheduledStandbyAvailabilityZone);
            }
            if (Optional.IsDefined(ExpectedStandbyAvailabilityZone))
            {
                writer.WritePropertyName("expectedStandbyAvailabilityZone"u8);
                writer.WriteStringValue(ExpectedStandbyAvailabilityZone);
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

        HighAvailabilityValidationEstimation IJsonModel<HighAvailabilityValidationEstimation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HighAvailabilityValidationEstimation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HighAvailabilityValidationEstimation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHighAvailabilityValidationEstimation(document.RootElement, options);
        }

        internal static HighAvailabilityValidationEstimation DeserializeHighAvailabilityValidationEstimation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? estimatedDowntime = default;
            string scheduledStandbyAvailabilityZone = default;
            string expectedStandbyAvailabilityZone = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("estimatedDowntime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    estimatedDowntime = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scheduledStandbyAvailabilityZone"u8))
                {
                    scheduledStandbyAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expectedStandbyAvailabilityZone"u8))
                {
                    expectedStandbyAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HighAvailabilityValidationEstimation(estimatedDowntime, scheduledStandbyAvailabilityZone, expectedStandbyAvailabilityZone, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HighAvailabilityValidationEstimation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HighAvailabilityValidationEstimation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HighAvailabilityValidationEstimation)} does not support '{options.Format}' format.");
            }
        }

        HighAvailabilityValidationEstimation IPersistableModel<HighAvailabilityValidationEstimation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HighAvailabilityValidationEstimation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHighAvailabilityValidationEstimation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HighAvailabilityValidationEstimation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HighAvailabilityValidationEstimation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
