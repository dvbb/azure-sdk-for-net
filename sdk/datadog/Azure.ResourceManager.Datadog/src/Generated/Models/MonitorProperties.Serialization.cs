// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    public partial class MonitorProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MonitoringStatus))
            {
                writer.WritePropertyName("monitoringStatus");
                writer.WriteStringValue(MonitoringStatus.Value.ToString());
            }
            if (Optional.IsDefined(DatadogOrganizationProperties))
            {
                writer.WritePropertyName("datadogOrganizationProperties");
                writer.WriteObjectValue(DatadogOrganizationProperties);
            }
            if (Optional.IsDefined(UserInfo))
            {
                writer.WritePropertyName("userInfo");
                writer.WriteObjectValue(UserInfo);
            }
            writer.WriteEndObject();
        }

        internal static MonitorProperties DeserializeMonitorProperties(JsonElement element)
        {
            Optional<ProvisioningState> provisioningState = default;
            Optional<MonitoringStatus> monitoringStatus = default;
            Optional<MarketplaceSubscriptionStatus> marketplaceSubscriptionStatus = default;
            Optional<DatadogOrganizationProperties> datadogOrganizationProperties = default;
            Optional<UserInfo> userInfo = default;
            Optional<LiftrResourceCategories> liftrResourceCategory = default;
            Optional<int> liftrResourcePreference = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("monitoringStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    monitoringStatus = new MonitoringStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("marketplaceSubscriptionStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    marketplaceSubscriptionStatus = new MarketplaceSubscriptionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("datadogOrganizationProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    datadogOrganizationProperties = DatadogOrganizationProperties.DeserializeDatadogOrganizationProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("userInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    userInfo = UserInfo.DeserializeUserInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("liftrResourceCategory"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    liftrResourceCategory = new LiftrResourceCategories(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("liftrResourcePreference"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    liftrResourcePreference = property.Value.GetInt32();
                    continue;
                }
            }
            return new MonitorProperties(Optional.ToNullable(provisioningState), Optional.ToNullable(monitoringStatus), Optional.ToNullable(marketplaceSubscriptionStatus), datadogOrganizationProperties.Value, userInfo.Value, Optional.ToNullable(liftrResourceCategory), Optional.ToNullable(liftrResourcePreference));
        }
    }
}
