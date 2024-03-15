// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmAgentUpgradeBlockingErrorDetails : IUtf8JsonSerializable, IJsonModel<InMageRcmAgentUpgradeBlockingErrorDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmAgentUpgradeBlockingErrorDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageRcmAgentUpgradeBlockingErrorDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmAgentUpgradeBlockingErrorDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmAgentUpgradeBlockingErrorDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteStringValue(ErrorCode);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(PossibleCauses))
            {
                writer.WritePropertyName("possibleCauses"u8);
                writer.WriteStringValue(PossibleCauses);
            }
            if (options.Format != "W" && Optional.IsDefined(RecommendedAction))
            {
                writer.WritePropertyName("recommendedAction"u8);
                writer.WriteStringValue(RecommendedAction);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ErrorMessageParameters))
            {
                writer.WritePropertyName("errorMessageParameters"u8);
                writer.WriteStartObject();
                foreach (var item in ErrorMessageParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ErrorTags))
            {
                writer.WritePropertyName("errorTags"u8);
                writer.WriteStartObject();
                foreach (var item in ErrorTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        InMageRcmAgentUpgradeBlockingErrorDetails IJsonModel<InMageRcmAgentUpgradeBlockingErrorDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmAgentUpgradeBlockingErrorDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageRcmAgentUpgradeBlockingErrorDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmAgentUpgradeBlockingErrorDetails(document.RootElement, options);
        }

        internal static InMageRcmAgentUpgradeBlockingErrorDetails DeserializeInMageRcmAgentUpgradeBlockingErrorDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string errorCode = default;
            string errorMessage = default;
            string possibleCauses = default;
            string recommendedAction = default;
            IReadOnlyDictionary<string, string> errorMessageParameters = default;
            IReadOnlyDictionary<string, string> errorTags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("possibleCauses"u8))
                {
                    possibleCauses = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendedAction"u8))
                {
                    recommendedAction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessageParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    errorMessageParameters = dictionary;
                    continue;
                }
                if (property.NameEquals("errorTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    errorTags = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageRcmAgentUpgradeBlockingErrorDetails(
                errorCode,
                errorMessage,
                possibleCauses,
                recommendedAction,
                errorMessageParameters ?? new ChangeTrackingDictionary<string, string>(),
                errorTags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageRcmAgentUpgradeBlockingErrorDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmAgentUpgradeBlockingErrorDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageRcmAgentUpgradeBlockingErrorDetails)} does not support '{options.Format}' format.");
            }
        }

        InMageRcmAgentUpgradeBlockingErrorDetails IPersistableModel<InMageRcmAgentUpgradeBlockingErrorDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageRcmAgentUpgradeBlockingErrorDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageRcmAgentUpgradeBlockingErrorDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageRcmAgentUpgradeBlockingErrorDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageRcmAgentUpgradeBlockingErrorDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
