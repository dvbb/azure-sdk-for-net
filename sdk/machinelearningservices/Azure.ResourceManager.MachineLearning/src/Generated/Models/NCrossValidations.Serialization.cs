// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownNCrossValidations))]
    public partial class NCrossValidations : IUtf8JsonSerializable, IJsonModel<NCrossValidations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NCrossValidations>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NCrossValidations>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NCrossValidations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NCrossValidations)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToString());
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

        NCrossValidations IJsonModel<NCrossValidations>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NCrossValidations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NCrossValidations)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNCrossValidations(document.RootElement, options);
        }

        internal static NCrossValidations DeserializeNCrossValidations(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("mode", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Auto": return AutoNCrossValidations.DeserializeAutoNCrossValidations(element, options);
                    case "Custom": return CustomNCrossValidations.DeserializeCustomNCrossValidations(element, options);
                }
            }
            return UnknownNCrossValidations.DeserializeUnknownNCrossValidations(element, options);
        }

        BinaryData IPersistableModel<NCrossValidations>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NCrossValidations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NCrossValidations)} does not support '{options.Format}' format.");
            }
        }

        NCrossValidations IPersistableModel<NCrossValidations>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NCrossValidations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNCrossValidations(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NCrossValidations)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NCrossValidations>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
