// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricMesh.Models
{
    public partial class ServiceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ReplicaCount))
            {
                writer.WritePropertyName("replicaCount");
                writer.WriteNumberValue(ReplicaCount.Value);
            }
            if (Optional.IsCollectionDefined(AutoScalingPolicies))
            {
                writer.WritePropertyName("autoScalingPolicies");
                writer.WriteStartArray();
                foreach (var item in AutoScalingPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ServiceProperties DeserializeServiceProperties(JsonElement element)
        {
            Optional<string> description = default;
            Optional<int> replicaCount = default;
            Optional<IList<AutoScalingPolicy>> autoScalingPolicies = default;
            Optional<ResourceStatus> status = default;
            Optional<string> statusDetails = default;
            Optional<HealthState> healthState = default;
            Optional<string> unhealthyEvaluation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicaCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    replicaCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autoScalingPolicies"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AutoScalingPolicy> array = new List<AutoScalingPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutoScalingPolicy.DeserializeAutoScalingPolicy(item));
                    }
                    autoScalingPolicies = array;
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new ResourceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusDetails"))
                {
                    statusDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    healthState = new HealthState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("unhealthyEvaluation"))
                {
                    unhealthyEvaluation = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceProperties(description.Value, Optional.ToNullable(replicaCount), Optional.ToList(autoScalingPolicies), Optional.ToNullable(status), statusDetails.Value, Optional.ToNullable(healthState), unhealthyEvaluation.Value);
        }
    }
}
