// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    [PersistableModelProxy(typeof(UnknownChaosTargetSelector))]
    public partial class ChaosTargetSelector : IUtf8JsonSerializable, IJsonModel<ChaosTargetSelector>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChaosTargetSelector>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ChaosTargetSelector>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetSelector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosTargetSelector)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(SelectorType.ToString());
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteObjectValue(Filter);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        ChaosTargetSelector IJsonModel<ChaosTargetSelector>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetSelector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosTargetSelector)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChaosTargetSelector(document.RootElement, options);
        }

        internal static ChaosTargetSelector DeserializeChaosTargetSelector(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "List": return ChaosTargetListSelector.DeserializeChaosTargetListSelector(element, options);
                    case "Query": return ChaosTargetQuerySelector.DeserializeChaosTargetQuerySelector(element, options);
                }
            }
            return UnknownChaosTargetSelector.DeserializeUnknownChaosTargetSelector(element, options);
        }

        BinaryData IPersistableModel<ChaosTargetSelector>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetSelector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChaosTargetSelector)} does not support '{options.Format}' format.");
            }
        }

        ChaosTargetSelector IPersistableModel<ChaosTargetSelector>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosTargetSelector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChaosTargetSelector(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChaosTargetSelector)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChaosTargetSelector>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
