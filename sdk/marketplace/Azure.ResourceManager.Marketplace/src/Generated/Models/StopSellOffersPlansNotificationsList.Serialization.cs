// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class StopSellOffersPlansNotificationsList : IUtf8JsonSerializable, IJsonModel<StopSellOffersPlansNotificationsList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StopSellOffersPlansNotificationsList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StopSellOffersPlansNotificationsList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StopSellOffersPlansNotificationsList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StopSellOffersPlansNotificationsList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(StopSellNotifications))
            {
                writer.WritePropertyName("stopSellNotifications"u8);
                writer.WriteStartArray();
                foreach (var item in StopSellNotifications)
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

        StopSellOffersPlansNotificationsList IJsonModel<StopSellOffersPlansNotificationsList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StopSellOffersPlansNotificationsList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StopSellOffersPlansNotificationsList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStopSellOffersPlansNotificationsList(document.RootElement, options);
        }

        internal static StopSellOffersPlansNotificationsList DeserializeStopSellOffersPlansNotificationsList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<StopSellOffersPlansNotificationsResult>> stopSellNotifications = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stopSellNotifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StopSellOffersPlansNotificationsResult> array = new List<StopSellOffersPlansNotificationsResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StopSellOffersPlansNotificationsResult.DeserializeStopSellOffersPlansNotificationsResult(item, options));
                    }
                    stopSellNotifications = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StopSellOffersPlansNotificationsList(Optional.ToList(stopSellNotifications), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StopSellOffersPlansNotificationsList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StopSellOffersPlansNotificationsList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StopSellOffersPlansNotificationsList)} does not support '{options.Format}' format.");
            }
        }

        StopSellOffersPlansNotificationsList IPersistableModel<StopSellOffersPlansNotificationsList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StopSellOffersPlansNotificationsList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStopSellOffersPlansNotificationsList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StopSellOffersPlansNotificationsList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StopSellOffersPlansNotificationsList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
