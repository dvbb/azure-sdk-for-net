// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ManagedIntegrationRuntime : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedVirtualNetwork))
            {
                writer.WritePropertyName("managedVirtualNetwork");
                writer.WriteObjectValue(ManagedVirtualNetwork);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ComputeProperties))
            {
                writer.WritePropertyName("computeProperties");
                writer.WriteObjectValue(ComputeProperties);
            }
            if (Optional.IsDefined(SsisProperties))
            {
                writer.WritePropertyName("ssisProperties");
                writer.WriteObjectValue(SsisProperties);
            }
            if (Optional.IsDefined(CustomerVirtualNetwork))
            {
                writer.WritePropertyName("customerVirtualNetwork");
                writer.WriteObjectValue(CustomerVirtualNetwork);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static ManagedIntegrationRuntime DeserializeManagedIntegrationRuntime(JsonElement element)
        {
            Optional<IntegrationRuntimeState> state = default;
            Optional<ManagedVirtualNetworkReference> managedVirtualNetwork = default;
            IntegrationRuntimeType type = default;
            Optional<string> description = default;
            Optional<IntegrationRuntimeComputeProperties> computeProperties = default;
            Optional<IntegrationRuntimeSsisProperties> ssisProperties = default;
            Optional<IntegrationRuntimeCustomerVirtualNetwork> customerVirtualNetwork = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new IntegrationRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedVirtualNetwork"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    managedVirtualNetwork = ManagedVirtualNetworkReference.DeserializeManagedVirtualNetworkReference(property.Value);
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("computeProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            computeProperties = IntegrationRuntimeComputeProperties.DeserializeIntegrationRuntimeComputeProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ssisProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ssisProperties = IntegrationRuntimeSsisProperties.DeserializeIntegrationRuntimeSsisProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customerVirtualNetwork"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            customerVirtualNetwork = IntegrationRuntimeCustomerVirtualNetwork.DeserializeIntegrationRuntimeCustomerVirtualNetwork(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ManagedIntegrationRuntime(type, description.Value, additionalProperties, Optional.ToNullable(state), managedVirtualNetwork.Value, computeProperties.Value, ssisProperties.Value, customerVirtualNetwork.Value);
        }
    }
}
