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
    public partial class ComputeStartStopRecurrenceSchedule : IUtf8JsonSerializable, IJsonModel<ComputeStartStopRecurrenceSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeStartStopRecurrenceSchedule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ComputeStartStopRecurrenceSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeStartStopRecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeStartStopRecurrenceSchedule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Frequency))
            {
                writer.WritePropertyName("frequency"u8);
                writer.WriteStringValue(Frequency.Value.ToString());
            }
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval"u8);
                writer.WriteNumberValue(Interval.Value);
            }
            if (Optional.IsDefined(StartTime))
            {
                if (StartTime != null)
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartTime);
                }
                else
                {
                    writer.WriteNull("startTime");
                }
            }
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsDefined(Schedule))
            {
                writer.WritePropertyName("schedule"u8);
                writer.WriteObjectValue(Schedule);
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

        ComputeStartStopRecurrenceSchedule IJsonModel<ComputeStartStopRecurrenceSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeStartStopRecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeStartStopRecurrenceSchedule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeStartStopRecurrenceSchedule(document.RootElement, options);
        }

        internal static ComputeStartStopRecurrenceSchedule DeserializeComputeStartStopRecurrenceSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningRecurrenceFrequency> frequency = default;
            Optional<int> interval = default;
            Optional<string> startTime = default;
            Optional<string> timeZone = default;
            Optional<MachineLearningRecurrenceSchedule> schedule = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("frequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frequency = new MachineLearningRecurrenceFrequency(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("interval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startTime = null;
                        continue;
                    }
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schedule = MachineLearningRecurrenceSchedule.DeserializeMachineLearningRecurrenceSchedule(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ComputeStartStopRecurrenceSchedule(Optional.ToNullable(frequency), Optional.ToNullable(interval), startTime.Value, timeZone.Value, schedule.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeStartStopRecurrenceSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeStartStopRecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputeStartStopRecurrenceSchedule)} does not support '{options.Format}' format.");
            }
        }

        ComputeStartStopRecurrenceSchedule IPersistableModel<ComputeStartStopRecurrenceSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeStartStopRecurrenceSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputeStartStopRecurrenceSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeStartStopRecurrenceSchedule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeStartStopRecurrenceSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
