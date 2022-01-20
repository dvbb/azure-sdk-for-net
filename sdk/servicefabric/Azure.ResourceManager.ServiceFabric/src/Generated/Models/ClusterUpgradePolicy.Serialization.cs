// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterUpgradePolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ForceRestart))
            {
                writer.WritePropertyName("forceRestart");
                writer.WriteBooleanValue(ForceRestart.Value);
            }
            writer.WritePropertyName("upgradeReplicaSetCheckTimeout");
            writer.WriteStringValue(UpgradeReplicaSetCheckTimeout);
            writer.WritePropertyName("healthCheckWaitDuration");
            writer.WriteStringValue(HealthCheckWaitDuration);
            writer.WritePropertyName("healthCheckStableDuration");
            writer.WriteStringValue(HealthCheckStableDuration);
            writer.WritePropertyName("healthCheckRetryTimeout");
            writer.WriteStringValue(HealthCheckRetryTimeout);
            writer.WritePropertyName("upgradeTimeout");
            writer.WriteStringValue(UpgradeTimeout);
            writer.WritePropertyName("upgradeDomainTimeout");
            writer.WriteStringValue(UpgradeDomainTimeout);
            writer.WritePropertyName("healthPolicy");
            writer.WriteObjectValue(HealthPolicy);
            if (Optional.IsDefined(DeltaHealthPolicy))
            {
                writer.WritePropertyName("deltaHealthPolicy");
                writer.WriteObjectValue(DeltaHealthPolicy);
            }
            writer.WriteEndObject();
        }

        internal static ClusterUpgradePolicy DeserializeClusterUpgradePolicy(JsonElement element)
        {
            Optional<bool> forceRestart = default;
            string upgradeReplicaSetCheckTimeout = default;
            string healthCheckWaitDuration = default;
            string healthCheckStableDuration = default;
            string healthCheckRetryTimeout = default;
            string upgradeTimeout = default;
            string upgradeDomainTimeout = default;
            ClusterHealthPolicy healthPolicy = default;
            Optional<ClusterUpgradeDeltaHealthPolicy> deltaHealthPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("forceRestart"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    forceRestart = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("upgradeReplicaSetCheckTimeout"))
                {
                    upgradeReplicaSetCheckTimeout = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthCheckWaitDuration"))
                {
                    healthCheckWaitDuration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthCheckStableDuration"))
                {
                    healthCheckStableDuration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthCheckRetryTimeout"))
                {
                    healthCheckRetryTimeout = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgradeTimeout"))
                {
                    upgradeTimeout = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgradeDomainTimeout"))
                {
                    upgradeDomainTimeout = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthPolicy"))
                {
                    healthPolicy = ClusterHealthPolicy.DeserializeClusterHealthPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("deltaHealthPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deltaHealthPolicy = ClusterUpgradeDeltaHealthPolicy.DeserializeClusterUpgradeDeltaHealthPolicy(property.Value);
                    continue;
                }
            }
            return new ClusterUpgradePolicy(Optional.ToNullable(forceRestart), upgradeReplicaSetCheckTimeout, healthCheckWaitDuration, healthCheckStableDuration, healthCheckRetryTimeout, upgradeTimeout, upgradeDomainTimeout, healthPolicy, deltaHealthPolicy.Value);
        }
    }
}
