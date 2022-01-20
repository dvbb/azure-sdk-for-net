// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class ServerConfigurationsManagementSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SqlConnectivityUpdateSettings))
            {
                writer.WritePropertyName("sqlConnectivityUpdateSettings");
                writer.WriteObjectValue(SqlConnectivityUpdateSettings);
            }
            if (Optional.IsDefined(SqlWorkloadTypeUpdateSettings))
            {
                writer.WritePropertyName("sqlWorkloadTypeUpdateSettings");
                writer.WriteObjectValue(SqlWorkloadTypeUpdateSettings);
            }
            if (Optional.IsDefined(SqlStorageUpdateSettings))
            {
                writer.WritePropertyName("sqlStorageUpdateSettings");
                writer.WriteObjectValue(SqlStorageUpdateSettings);
            }
            if (Optional.IsDefined(AdditionalFeaturesServerConfigurations))
            {
                writer.WritePropertyName("additionalFeaturesServerConfigurations");
                writer.WriteObjectValue(AdditionalFeaturesServerConfigurations);
            }
            writer.WriteEndObject();
        }

        internal static ServerConfigurationsManagementSettings DeserializeServerConfigurationsManagementSettings(JsonElement element)
        {
            Optional<SqlConnectivityUpdateSettings> sqlConnectivityUpdateSettings = default;
            Optional<SqlWorkloadTypeUpdateSettings> sqlWorkloadTypeUpdateSettings = default;
            Optional<SqlStorageUpdateSettings> sqlStorageUpdateSettings = default;
            Optional<AdditionalFeaturesServerConfigurations> additionalFeaturesServerConfigurations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlConnectivityUpdateSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sqlConnectivityUpdateSettings = SqlConnectivityUpdateSettings.DeserializeSqlConnectivityUpdateSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("sqlWorkloadTypeUpdateSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sqlWorkloadTypeUpdateSettings = SqlWorkloadTypeUpdateSettings.DeserializeSqlWorkloadTypeUpdateSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("sqlStorageUpdateSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sqlStorageUpdateSettings = SqlStorageUpdateSettings.DeserializeSqlStorageUpdateSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("additionalFeaturesServerConfigurations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    additionalFeaturesServerConfigurations = AdditionalFeaturesServerConfigurations.DeserializeAdditionalFeaturesServerConfigurations(property.Value);
                    continue;
                }
            }
            return new ServerConfigurationsManagementSettings(sqlConnectivityUpdateSettings.Value, sqlWorkloadTypeUpdateSettings.Value, sqlStorageUpdateSettings.Value, additionalFeaturesServerConfigurations.Value);
        }
    }
}
