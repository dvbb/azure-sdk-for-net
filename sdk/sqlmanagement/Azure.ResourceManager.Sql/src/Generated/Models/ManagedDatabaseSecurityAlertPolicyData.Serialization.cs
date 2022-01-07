// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedDatabaseSecurityAlertPolicyData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(DisabledAlerts))
            {
                writer.WritePropertyName("disabledAlerts");
                writer.WriteStartArray();
                foreach (var item in DisabledAlerts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EmailAddresses))
            {
                writer.WritePropertyName("emailAddresses");
                writer.WriteStartArray();
                foreach (var item in EmailAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EmailAccountAdmins))
            {
                writer.WritePropertyName("emailAccountAdmins");
                writer.WriteBooleanValue(EmailAccountAdmins.Value);
            }
            if (Optional.IsDefined(StorageEndpoint))
            {
                writer.WritePropertyName("storageEndpoint");
                writer.WriteStringValue(StorageEndpoint);
            }
            if (Optional.IsDefined(StorageAccountAccessKey))
            {
                writer.WritePropertyName("storageAccountAccessKey");
                writer.WriteStringValue(StorageAccountAccessKey);
            }
            if (Optional.IsDefined(RetentionDays))
            {
                writer.WritePropertyName("retentionDays");
                writer.WriteNumberValue(RetentionDays.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ManagedDatabaseSecurityAlertPolicyData DeserializeManagedDatabaseSecurityAlertPolicyData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SecurityAlertPolicyState> state = default;
            Optional<IList<string>> disabledAlerts = default;
            Optional<IList<string>> emailAddresses = default;
            Optional<bool> emailAccountAdmins = default;
            Optional<string> storageEndpoint = default;
            Optional<string> storageAccountAccessKey = default;
            Optional<int> retentionDays = default;
            Optional<DateTimeOffset> creationTime = default;
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
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = property0.Value.GetString().ToSecurityAlertPolicyState();
                            continue;
                        }
                        if (property0.NameEquals("disabledAlerts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            disabledAlerts = array;
                            continue;
                        }
                        if (property0.NameEquals("emailAddresses"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            emailAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("emailAccountAdmins"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            emailAccountAdmins = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("storageEndpoint"))
                        {
                            storageEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountAccessKey"))
                        {
                            storageAccountAccessKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("retentionDays"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            retentionDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ManagedDatabaseSecurityAlertPolicyData(id, name, type, Optional.ToNullable(state), Optional.ToList(disabledAlerts), Optional.ToList(emailAddresses), Optional.ToNullable(emailAccountAdmins), storageEndpoint.Value, storageAccountAccessKey.Value, Optional.ToNullable(retentionDays), Optional.ToNullable(creationTime));
        }
    }
}
