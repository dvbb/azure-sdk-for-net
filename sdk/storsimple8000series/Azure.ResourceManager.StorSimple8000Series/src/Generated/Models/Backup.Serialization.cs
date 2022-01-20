// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    public partial class Backup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("createdOn");
            writer.WriteStringValue(CreatedOn, "O");
            writer.WritePropertyName("sizeInBytes");
            writer.WriteNumberValue(SizeInBytes);
            if (Optional.IsDefined(BackupType))
            {
                writer.WritePropertyName("backupType");
                writer.WriteStringValue(BackupType.Value.ToSerialString());
            }
            if (Optional.IsDefined(BackupJobCreationType))
            {
                writer.WritePropertyName("backupJobCreationType");
                writer.WriteStringValue(BackupJobCreationType.Value.ToSerialString());
            }
            if (Optional.IsDefined(BackupPolicyId))
            {
                writer.WritePropertyName("backupPolicyId");
                writer.WriteStringValue(BackupPolicyId);
            }
            if (Optional.IsDefined(SsmHostName))
            {
                writer.WritePropertyName("ssmHostName");
                writer.WriteStringValue(SsmHostName);
            }
            writer.WritePropertyName("elements");
            writer.WriteStartArray();
            foreach (var item in Elements)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static Backup DeserializeBackup(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            DateTimeOffset createdOn = default;
            long sizeInBytes = default;
            Optional<BackupType> backupType = default;
            Optional<BackupJobCreationType> backupJobCreationType = default;
            Optional<string> backupPolicyId = default;
            Optional<string> ssmHostName = default;
            IList<BackupElement> elements = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("createdOn"))
                        {
                            createdOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("sizeInBytes"))
                        {
                            sizeInBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("backupType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            backupType = property0.Value.GetString().ToBackupType();
                            continue;
                        }
                        if (property0.NameEquals("backupJobCreationType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            backupJobCreationType = property0.Value.GetString().ToBackupJobCreationType();
                            continue;
                        }
                        if (property0.NameEquals("backupPolicyId"))
                        {
                            backupPolicyId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ssmHostName"))
                        {
                            ssmHostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("elements"))
                        {
                            List<BackupElement> array = new List<BackupElement>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BackupElement.DeserializeBackupElement(item));
                            }
                            elements = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Backup(id, name, type, kind.Value, createdOn, sizeInBytes, Optional.ToNullable(backupType), Optional.ToNullable(backupJobCreationType), backupPolicyId.Value, ssmHostName.Value, elements);
        }
    }
}
