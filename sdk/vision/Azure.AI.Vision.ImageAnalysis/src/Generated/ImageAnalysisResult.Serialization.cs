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

namespace Azure.AI.Vision.ImageAnalysis
{
    public partial class ImageAnalysisResult : IUtf8JsonSerializable, IJsonModel<ImageAnalysisResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImageAnalysisResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImageAnalysisResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageAnalysisResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Caption))
            {
                writer.WritePropertyName("captionResult"u8);
                writer.WriteObjectValue(Caption);
            }
            if (Optional.IsDefined(DenseCaptions))
            {
                writer.WritePropertyName("denseCaptionsResult"u8);
                writer.WriteObjectValue(DenseCaptions);
            }
            writer.WritePropertyName("metadata"u8);
            writer.WriteObjectValue(Metadata);
            writer.WritePropertyName("modelVersion"u8);
            writer.WriteStringValue(ModelVersion);
            if (Optional.IsDefined(Objects))
            {
                writer.WritePropertyName("objectsResult"u8);
                writer.WriteObjectValue(Objects);
            }
            if (Optional.IsDefined(People))
            {
                writer.WritePropertyName("peopleResult"u8);
                writer.WriteObjectValue(People);
            }
            if (Optional.IsDefined(Read))
            {
                writer.WritePropertyName("readResult"u8);
                writer.WriteObjectValue(Read);
            }
            if (Optional.IsDefined(SmartCrops))
            {
                writer.WritePropertyName("smartCropsResult"u8);
                writer.WriteObjectValue(SmartCrops);
            }
            if (Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tagsResult"u8);
                writer.WriteObjectValue(Tags);
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

        ImageAnalysisResult IJsonModel<ImageAnalysisResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImageAnalysisResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImageAnalysisResult(document.RootElement, options);
        }

        internal static ImageAnalysisResult DeserializeImageAnalysisResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CaptionResult> captionResult = default;
            Optional<DenseCaptionsResult> denseCaptionsResult = default;
            ImageMetadata metadata = default;
            string modelVersion = default;
            Optional<ObjectsResult> objectsResult = default;
            Optional<PeopleResult> peopleResult = default;
            Optional<ReadResult> readResult = default;
            Optional<SmartCropsResult> smartCropsResult = default;
            Optional<TagsResult> tagsResult = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("captionResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    captionResult = CaptionResult.DeserializeCaptionResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("denseCaptionsResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    denseCaptionsResult = DenseCaptionsResult.DeserializeDenseCaptionsResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    metadata = ImageMetadata.DeserializeImageMetadata(property.Value, options);
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectsResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    objectsResult = ObjectsResult.DeserializeObjectsResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("peopleResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peopleResult = PeopleResult.DeserializePeopleResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("readResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readResult = ReadResult.DeserializeReadResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("smartCropsResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    smartCropsResult = SmartCropsResult.DeserializeSmartCropsResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tagsResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tagsResult = TagsResult.DeserializeTagsResult(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImageAnalysisResult(captionResult.Value, denseCaptionsResult.Value, metadata, modelVersion, objectsResult.Value, peopleResult.Value, readResult.Value, smartCropsResult.Value, tagsResult.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImageAnalysisResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImageAnalysisResult)} does not support '{options.Format}' format.");
            }
        }

        ImageAnalysisResult IPersistableModel<ImageAnalysisResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImageAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImageAnalysisResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImageAnalysisResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImageAnalysisResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ImageAnalysisResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeImageAnalysisResult(document.RootElement);
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
