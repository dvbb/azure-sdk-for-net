// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ResourceHealthEventRecommendedActions : IUtf8JsonSerializable, IJsonModel<ResourceHealthEventRecommendedActions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceHealthEventRecommendedActions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceHealthEventRecommendedActions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventRecommendedActions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthEventRecommendedActions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LocaleCode))
            {
                writer.WritePropertyName("localeCode"u8);
                writer.WriteStringValue(LocaleCode);
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

        ResourceHealthEventRecommendedActions IJsonModel<ResourceHealthEventRecommendedActions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventRecommendedActions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceHealthEventRecommendedActions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceHealthEventRecommendedActions(document.RootElement, options);
        }

        internal static ResourceHealthEventRecommendedActions DeserializeResourceHealthEventRecommendedActions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> message = default;
            Optional<IReadOnlyList<ResourceHealthEventRecommendedActionsItem>> actions = default;
            Optional<string> localeCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceHealthEventRecommendedActionsItem> array = new List<ResourceHealthEventRecommendedActionsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceHealthEventRecommendedActionsItem.DeserializeResourceHealthEventRecommendedActionsItem(item, options));
                    }
                    actions = array;
                    continue;
                }
                if (property.NameEquals("localeCode"u8))
                {
                    localeCode = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceHealthEventRecommendedActions(message.Value, Optional.ToList(actions), localeCode.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceHealthEventRecommendedActions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventRecommendedActions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthEventRecommendedActions)} does not support '{options.Format}' format.");
            }
        }

        ResourceHealthEventRecommendedActions IPersistableModel<ResourceHealthEventRecommendedActions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceHealthEventRecommendedActions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceHealthEventRecommendedActions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceHealthEventRecommendedActions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceHealthEventRecommendedActions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
