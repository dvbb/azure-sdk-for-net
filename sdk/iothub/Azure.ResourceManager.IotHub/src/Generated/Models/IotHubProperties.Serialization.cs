// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.IotHub;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubProperties : IUtf8JsonSerializable, IJsonModel<IotHubProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IotHubProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AuthorizationPolicies))
            {
                writer.WritePropertyName("authorizationPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizationPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (Optional.IsDefined(DisableDeviceSas))
            {
                writer.WritePropertyName("disableDeviceSAS"u8);
                writer.WriteBooleanValue(DisableDeviceSas.Value);
            }
            if (Optional.IsDefined(DisableModuleSas))
            {
                writer.WritePropertyName("disableModuleSAS"u8);
                writer.WriteBooleanValue(DisableModuleSas.Value);
            }
            if (Optional.IsDefined(RestrictOutboundNetworkAccess))
            {
                writer.WritePropertyName("restrictOutboundNetworkAccess"u8);
                writer.WriteBooleanValue(RestrictOutboundNetworkAccess.Value);
            }
            if (Optional.IsCollectionDefined(AllowedFqdns))
            {
                writer.WritePropertyName("allowedFqdnList"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedFqdns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IPFilterRules))
            {
                writer.WritePropertyName("ipFilterRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPFilterRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NetworkRuleSets))
            {
                writer.WritePropertyName("networkRuleSets"u8);
                writer.WriteObjectValue(NetworkRuleSets);
            }
            if (Optional.IsDefined(MinTlsVersion))
            {
                writer.WritePropertyName("minTlsVersion"u8);
                writer.WriteStringValue(MinTlsVersion);
            }
            if (Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (options.Format != "W" && Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsCollectionDefined(EventHubEndpoints))
            {
                writer.WritePropertyName("eventHubEndpoints"u8);
                writer.WriteStartObject();
                foreach (var item in EventHubEndpoints)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Routing))
            {
                writer.WritePropertyName("routing"u8);
                writer.WriteObjectValue(Routing);
            }
            if (Optional.IsCollectionDefined(StorageEndpoints))
            {
                writer.WritePropertyName("storageEndpoints"u8);
                writer.WriteStartObject();
                foreach (var item in StorageEndpoints)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(MessagingEndpoints))
            {
                writer.WritePropertyName("messagingEndpoints"u8);
                writer.WriteStartObject();
                foreach (var item in MessagingEndpoints)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(EnableFileUploadNotifications))
            {
                writer.WritePropertyName("enableFileUploadNotifications"u8);
                writer.WriteBooleanValue(EnableFileUploadNotifications.Value);
            }
            if (Optional.IsDefined(CloudToDevice))
            {
                writer.WritePropertyName("cloudToDevice"u8);
                writer.WriteObjectValue(CloudToDevice);
            }
            if (Optional.IsDefined(Comments))
            {
                writer.WritePropertyName("comments"u8);
                writer.WriteStringValue(Comments);
            }
            if (Optional.IsDefined(Features))
            {
                writer.WritePropertyName("features"u8);
                writer.WriteStringValue(Features.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableDataResidency))
            {
                writer.WritePropertyName("enableDataResidency"u8);
                writer.WriteBooleanValue(EnableDataResidency.Value);
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

        IotHubProperties IJsonModel<IotHubProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubProperties(document.RootElement, options);
        }

        internal static IotHubProperties DeserializeIotHubProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<SharedAccessSignatureAuthorizationRule> authorizationPolicies = default;
            bool? disableLocalAuth = default;
            bool? disableDeviceSas = default;
            bool? disableModuleSas = default;
            bool? restrictOutboundNetworkAccess = default;
            IList<string> allowedFqdnList = default;
            IotHubPublicNetworkAccess? publicNetworkAccess = default;
            IList<IotHubIPFilterRule> ipFilterRules = default;
            IotHubNetworkRuleSetProperties networkRuleSets = default;
            string minTlsVersion = default;
            IList<IotHubPrivateEndpointConnectionData> privateEndpointConnections = default;
            string provisioningState = default;
            string state = default;
            string hostName = default;
            IDictionary<string, EventHubCompatibleEndpointProperties> eventHubEndpoints = default;
            IotHubRoutingProperties routing = default;
            IDictionary<string, IotHubStorageEndpointProperties> storageEndpoints = default;
            IDictionary<string, MessagingEndpointProperties> messagingEndpoints = default;
            bool? enableFileUploadNotifications = default;
            CloudToDeviceProperties cloudToDevice = default;
            string comments = default;
            IotHubCapability? features = default;
            IReadOnlyList<IotHubLocationDescription> locations = default;
            bool? enableDataResidency = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizationPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SharedAccessSignatureAuthorizationRule> array = new List<SharedAccessSignatureAuthorizationRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SharedAccessSignatureAuthorizationRule.DeserializeSharedAccessSignatureAuthorizationRule(item, options));
                    }
                    authorizationPolicies = array;
                    continue;
                }
                if (property.NameEquals("disableLocalAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableLocalAuth = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableDeviceSAS"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableDeviceSas = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableModuleSAS"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableModuleSas = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("restrictOutboundNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restrictOutboundNetworkAccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedFqdnList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedFqdnList = array;
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new IotHubPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipFilterRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotHubIPFilterRule> array = new List<IotHubIPFilterRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubIPFilterRule.DeserializeIotHubIPFilterRule(item, options));
                    }
                    ipFilterRules = array;
                    continue;
                }
                if (property.NameEquals("networkRuleSets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkRuleSets = IotHubNetworkRuleSetProperties.DeserializeIotHubNetworkRuleSetProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("minTlsVersion"u8))
                {
                    minTlsVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotHubPrivateEndpointConnectionData> array = new List<IotHubPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubPrivateEndpointConnectionData.DeserializeIotHubPrivateEndpointConnectionData(item, options));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventHubEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EventHubCompatibleEndpointProperties> dictionary = new Dictionary<string, EventHubCompatibleEndpointProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EventHubCompatibleEndpointProperties.DeserializeEventHubCompatibleEndpointProperties(property0.Value, options));
                    }
                    eventHubEndpoints = dictionary;
                    continue;
                }
                if (property.NameEquals("routing"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routing = IotHubRoutingProperties.DeserializeIotHubRoutingProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("storageEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IotHubStorageEndpointProperties> dictionary = new Dictionary<string, IotHubStorageEndpointProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, IotHubStorageEndpointProperties.DeserializeIotHubStorageEndpointProperties(property0.Value, options));
                    }
                    storageEndpoints = dictionary;
                    continue;
                }
                if (property.NameEquals("messagingEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, MessagingEndpointProperties> dictionary = new Dictionary<string, MessagingEndpointProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MessagingEndpointProperties.DeserializeMessagingEndpointProperties(property0.Value, options));
                    }
                    messagingEndpoints = dictionary;
                    continue;
                }
                if (property.NameEquals("enableFileUploadNotifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableFileUploadNotifications = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloudToDevice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloudToDevice = CloudToDeviceProperties.DeserializeCloudToDeviceProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("comments"u8))
                {
                    comments = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("features"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    features = new IotHubCapability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotHubLocationDescription> array = new List<IotHubLocationDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubLocationDescription.DeserializeIotHubLocationDescription(item, options));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("enableDataResidency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDataResidency = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotHubProperties(
                authorizationPolicies ?? new ChangeTrackingList<SharedAccessSignatureAuthorizationRule>(),
                disableLocalAuth,
                disableDeviceSas,
                disableModuleSas,
                restrictOutboundNetworkAccess,
                allowedFqdnList ?? new ChangeTrackingList<string>(),
                publicNetworkAccess,
                ipFilterRules ?? new ChangeTrackingList<IotHubIPFilterRule>(),
                networkRuleSets,
                minTlsVersion,
                privateEndpointConnections ?? new ChangeTrackingList<IotHubPrivateEndpointConnectionData>(),
                provisioningState,
                state,
                hostName,
                eventHubEndpoints ?? new ChangeTrackingDictionary<string, EventHubCompatibleEndpointProperties>(),
                routing,
                storageEndpoints ?? new ChangeTrackingDictionary<string, IotHubStorageEndpointProperties>(),
                messagingEndpoints ?? new ChangeTrackingDictionary<string, MessagingEndpointProperties>(),
                enableFileUploadNotifications,
                cloudToDevice,
                comments,
                features,
                locations ?? new ChangeTrackingList<IotHubLocationDescription>(),
                enableDataResidency,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotHubProperties)} does not support '{options.Format}' format.");
            }
        }

        IotHubProperties IPersistableModel<IotHubProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotHubProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotHubProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
