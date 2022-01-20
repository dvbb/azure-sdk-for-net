// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SqlVirtualMachine.Models;

namespace Azure.ResourceManager.SqlVirtualMachine
{
    public partial class AvailabilityGroupListenerData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AvailabilityGroupName))
            {
                writer.WritePropertyName("availabilityGroupName");
                writer.WriteStringValue(AvailabilityGroupName);
            }
            if (Optional.IsCollectionDefined(LoadBalancerConfigurations))
            {
                writer.WritePropertyName("loadBalancerConfigurations");
                writer.WriteStartArray();
                foreach (var item in LoadBalancerConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CreateDefaultAvailabilityGroupIfNotExist))
            {
                writer.WritePropertyName("createDefaultAvailabilityGroupIfNotExist");
                writer.WriteBooleanValue(CreateDefaultAvailabilityGroupIfNotExist.Value);
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port");
                writer.WriteNumberValue(Port.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AvailabilityGroupListenerData DeserializeAvailabilityGroupListenerData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> provisioningState = default;
            Optional<string> availabilityGroupName = default;
            Optional<IList<LoadBalancerConfiguration>> loadBalancerConfigurations = default;
            Optional<bool> createDefaultAvailabilityGroupIfNotExist = default;
            Optional<int> port = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("availabilityGroupName"))
                        {
                            availabilityGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<LoadBalancerConfiguration> array = new List<LoadBalancerConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LoadBalancerConfiguration.DeserializeLoadBalancerConfiguration(item));
                            }
                            loadBalancerConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("createDefaultAvailabilityGroupIfNotExist"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createDefaultAvailabilityGroupIfNotExist = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("port"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AvailabilityGroupListenerData(id, name, type, provisioningState.Value, availabilityGroupName.Value, Optional.ToList(loadBalancerConfigurations), Optional.ToNullable(createDefaultAvailabilityGroupIfNotExist), Optional.ToNullable(port));
        }
    }
}
