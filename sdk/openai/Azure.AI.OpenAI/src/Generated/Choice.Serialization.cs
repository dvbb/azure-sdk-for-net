// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class Choice : IUtf8JsonSerializable, IJsonModel<Choice>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Choice>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Choice>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Choice>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Choice)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            writer.WritePropertyName("index"u8);
            writer.WriteNumberValue(Index);
            if (Optional.IsDefined(ContentFilterResults))
            {
                writer.WritePropertyName("content_filter_results"u8);
                writer.WriteObjectValue(ContentFilterResults);
            }
            if (LogProbabilityModel != null)
            {
                writer.WritePropertyName("logprobs"u8);
                writer.WriteObjectValue(LogProbabilityModel);
            }
            else
            {
                writer.WriteNull("logprobs");
            }
            if (FinishReason != null)
            {
                writer.WritePropertyName("finish_reason"u8);
                writer.WriteStringValue(FinishReason.Value.ToString());
            }
            else
            {
                writer.WriteNull("finish_reason");
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

        Choice IJsonModel<Choice>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Choice>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Choice)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChoice(document.RootElement, options);
        }

        internal static Choice DeserializeChoice(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            int index = default;
            Optional<ContentFilterResultsForChoice> contentFilterResults = default;
            CompletionsLogProbabilityModel logprobs = default;
            CompletionsFinishReason? finishReason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("index"u8))
                {
                    index = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("content_filter_results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentFilterResults = ContentFilterResultsForChoice.DeserializeContentFilterResultsForChoice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("logprobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        logprobs = null;
                        continue;
                    }
                    logprobs = CompletionsLogProbabilityModel.DeserializeCompletionsLogProbabilityModel(property.Value, options);
                    continue;
                }
                if (property.NameEquals("finish_reason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        finishReason = null;
                        continue;
                    }
                    finishReason = new CompletionsFinishReason(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new Choice(text, index, contentFilterResults.Value, logprobs, finishReason, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Choice>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Choice>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Choice)} does not support '{options.Format}' format.");
            }
        }

        Choice IPersistableModel<Choice>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Choice>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChoice(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Choice)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<Choice>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Choice FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChoice(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
