// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class UpdateTopicSpacesConfigurationInfo : IUtf8JsonSerializable, IJsonModel<UpdateTopicSpacesConfigurationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateTopicSpacesConfigurationInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UpdateTopicSpacesConfigurationInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateTopicSpacesConfigurationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateTopicSpacesConfigurationInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(RouteTopicResourceId))
            {
                writer.WritePropertyName("routeTopicResourceId"u8);
                writer.WriteStringValue(RouteTopicResourceId);
            }
            if (Optional.IsDefined(RoutingEnrichments))
            {
                writer.WritePropertyName("routingEnrichments"u8);
                writer.WriteObjectValue(RoutingEnrichments);
            }
            if (Optional.IsDefined(ClientAuthentication))
            {
                writer.WritePropertyName("clientAuthentication"u8);
                writer.WriteObjectValue(ClientAuthentication);
            }
            if (Optional.IsDefined(MaximumSessionExpiryInHours))
            {
                writer.WritePropertyName("maximumSessionExpiryInHours"u8);
                writer.WriteNumberValue(MaximumSessionExpiryInHours.Value);
            }
            if (Optional.IsDefined(MaximumClientSessionsPerAuthenticationName))
            {
                writer.WritePropertyName("maximumClientSessionsPerAuthenticationName"u8);
                writer.WriteNumberValue(MaximumClientSessionsPerAuthenticationName.Value);
            }
            if (Optional.IsDefined(RoutingIdentityInfo))
            {
                writer.WritePropertyName("routingIdentityInfo"u8);
                writer.WriteObjectValue(RoutingIdentityInfo);
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

        UpdateTopicSpacesConfigurationInfo IJsonModel<UpdateTopicSpacesConfigurationInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateTopicSpacesConfigurationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateTopicSpacesConfigurationInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateTopicSpacesConfigurationInfo(document.RootElement, options);
        }

        internal static UpdateTopicSpacesConfigurationInfo DeserializeUpdateTopicSpacesConfigurationInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TopicSpacesConfigurationState> state = default;
            Optional<string> routeTopicResourceId = default;
            Optional<RoutingEnrichments> routingEnrichments = default;
            Optional<ClientAuthenticationSettings> clientAuthentication = default;
            Optional<int> maximumSessionExpiryInHours = default;
            Optional<int> maximumClientSessionsPerAuthenticationName = default;
            Optional<RoutingIdentityInfo> routingIdentityInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new TopicSpacesConfigurationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("routeTopicResourceId"u8))
                {
                    routeTopicResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routingEnrichments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingEnrichments = RoutingEnrichments.DeserializeRoutingEnrichments(property.Value, options);
                    continue;
                }
                if (property.NameEquals("clientAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientAuthentication = ClientAuthenticationSettings.DeserializeClientAuthenticationSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("maximumSessionExpiryInHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumSessionExpiryInHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximumClientSessionsPerAuthenticationName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumClientSessionsPerAuthenticationName = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("routingIdentityInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingIdentityInfo = RoutingIdentityInfo.DeserializeRoutingIdentityInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UpdateTopicSpacesConfigurationInfo(Optional.ToNullable(state), routeTopicResourceId.Value, routingEnrichments.Value, clientAuthentication.Value, Optional.ToNullable(maximumSessionExpiryInHours), Optional.ToNullable(maximumClientSessionsPerAuthenticationName), routingIdentityInfo.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdateTopicSpacesConfigurationInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateTopicSpacesConfigurationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpdateTopicSpacesConfigurationInfo)} does not support '{options.Format}' format.");
            }
        }

        UpdateTopicSpacesConfigurationInfo IPersistableModel<UpdateTopicSpacesConfigurationInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateTopicSpacesConfigurationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpdateTopicSpacesConfigurationInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateTopicSpacesConfigurationInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateTopicSpacesConfigurationInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
