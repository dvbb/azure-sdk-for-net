// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class AS2AgreementContent : IUtf8JsonSerializable, IJsonModel<AS2AgreementContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AS2AgreementContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AS2AgreementContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2AgreementContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AS2AgreementContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("receiveAgreement"u8);
            writer.WriteObjectValue(ReceiveAgreement);
            writer.WritePropertyName("sendAgreement"u8);
            writer.WriteObjectValue(SendAgreement);
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

        AS2AgreementContent IJsonModel<AS2AgreementContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2AgreementContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AS2AgreementContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAS2AgreementContent(document.RootElement, options);
        }

        internal static AS2AgreementContent DeserializeAS2AgreementContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AS2OneWayAgreement receiveAgreement = default;
            AS2OneWayAgreement sendAgreement = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("receiveAgreement"u8))
                {
                    receiveAgreement = AS2OneWayAgreement.DeserializeAS2OneWayAgreement(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sendAgreement"u8))
                {
                    sendAgreement = AS2OneWayAgreement.DeserializeAS2OneWayAgreement(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AS2AgreementContent(receiveAgreement, sendAgreement, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AS2AgreementContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2AgreementContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AS2AgreementContent)} does not support '{options.Format}' format.");
            }
        }

        AS2AgreementContent IPersistableModel<AS2AgreementContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AS2AgreementContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAS2AgreementContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AS2AgreementContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AS2AgreementContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
