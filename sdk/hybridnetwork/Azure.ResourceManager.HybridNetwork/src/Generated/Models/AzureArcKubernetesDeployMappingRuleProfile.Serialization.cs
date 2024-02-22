// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureArcKubernetesDeployMappingRuleProfile : IUtf8JsonSerializable, IJsonModel<AzureArcKubernetesDeployMappingRuleProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureArcKubernetesDeployMappingRuleProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureArcKubernetesDeployMappingRuleProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureArcKubernetesDeployMappingRuleProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(HelmMappingRuleProfile))
            {
                writer.WritePropertyName("helmMappingRuleProfile"u8);
                writer.WriteObjectValue(HelmMappingRuleProfile);
            }
            if (Optional.IsDefined(ApplicationEnablement))
            {
                writer.WritePropertyName("applicationEnablement"u8);
                writer.WriteStringValue(ApplicationEnablement.Value.ToString());
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

        AzureArcKubernetesDeployMappingRuleProfile IJsonModel<AzureArcKubernetesDeployMappingRuleProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureArcKubernetesDeployMappingRuleProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureArcKubernetesDeployMappingRuleProfile(document.RootElement, options);
        }

        internal static AzureArcKubernetesDeployMappingRuleProfile DeserializeAzureArcKubernetesDeployMappingRuleProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HelmMappingRuleProfile> helmMappingRuleProfile = default;
            Optional<ApplicationEnablement> applicationEnablement = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("helmMappingRuleProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    helmMappingRuleProfile = HelmMappingRuleProfile.DeserializeHelmMappingRuleProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("applicationEnablement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationEnablement = new ApplicationEnablement(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureArcKubernetesDeployMappingRuleProfile(Optional.ToNullable(applicationEnablement), serializedAdditionalRawData, helmMappingRuleProfile.Value);
        }

        BinaryData IPersistableModel<AzureArcKubernetesDeployMappingRuleProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureArcKubernetesDeployMappingRuleProfile)} does not support '{options.Format}' format.");
            }
        }

        AzureArcKubernetesDeployMappingRuleProfile IPersistableModel<AzureArcKubernetesDeployMappingRuleProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureArcKubernetesDeployMappingRuleProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureArcKubernetesDeployMappingRuleProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureArcKubernetesDeployMappingRuleProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
