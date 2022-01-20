// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    public partial class RedisCommonPropertiesRedisConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RdbBackupEnabled))
            {
                writer.WritePropertyName("rdb-backup-enabled");
                writer.WriteStringValue(RdbBackupEnabled);
            }
            if (Optional.IsDefined(RdbBackupFrequency))
            {
                writer.WritePropertyName("rdb-backup-frequency");
                writer.WriteStringValue(RdbBackupFrequency);
            }
            if (Optional.IsDefined(RdbBackupMaxSnapshotCount))
            {
                writer.WritePropertyName("rdb-backup-max-snapshot-count");
                writer.WriteStringValue(RdbBackupMaxSnapshotCount);
            }
            if (Optional.IsDefined(RdbStorageConnectionString))
            {
                writer.WritePropertyName("rdb-storage-connection-string");
                writer.WriteStringValue(RdbStorageConnectionString);
            }
            if (Optional.IsDefined(AofStorageConnectionString0))
            {
                writer.WritePropertyName("aof-storage-connection-string-0");
                writer.WriteStringValue(AofStorageConnectionString0);
            }
            if (Optional.IsDefined(AofStorageConnectionString1))
            {
                writer.WritePropertyName("aof-storage-connection-string-1");
                writer.WriteStringValue(AofStorageConnectionString1);
            }
            if (Optional.IsDefined(MaxfragmentationmemoryReserved))
            {
                writer.WritePropertyName("maxfragmentationmemory-reserved");
                writer.WriteStringValue(MaxfragmentationmemoryReserved);
            }
            if (Optional.IsDefined(MaxmemoryPolicy))
            {
                writer.WritePropertyName("maxmemory-policy");
                writer.WriteStringValue(MaxmemoryPolicy);
            }
            if (Optional.IsDefined(MaxmemoryReserved))
            {
                writer.WritePropertyName("maxmemory-reserved");
                writer.WriteStringValue(MaxmemoryReserved);
            }
            if (Optional.IsDefined(MaxmemoryDelta))
            {
                writer.WritePropertyName("maxmemory-delta");
                writer.WriteStringValue(MaxmemoryDelta);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static RedisCommonPropertiesRedisConfiguration DeserializeRedisCommonPropertiesRedisConfiguration(JsonElement element)
        {
            Optional<string> rdbBackupEnabled = default;
            Optional<string> rdbBackupFrequency = default;
            Optional<string> rdbBackupMaxSnapshotCount = default;
            Optional<string> rdbStorageConnectionString = default;
            Optional<string> aofStorageConnectionString0 = default;
            Optional<string> aofStorageConnectionString1 = default;
            Optional<string> maxfragmentationmemoryReserved = default;
            Optional<string> maxmemoryPolicy = default;
            Optional<string> maxmemoryReserved = default;
            Optional<string> maxmemoryDelta = default;
            Optional<string> maxclients = default;
            Optional<string> preferredDataArchiveAuthMethod = default;
            Optional<string> preferredDataPersistenceAuthMethod = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rdb-backup-enabled"))
                {
                    rdbBackupEnabled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rdb-backup-frequency"))
                {
                    rdbBackupFrequency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rdb-backup-max-snapshot-count"))
                {
                    rdbBackupMaxSnapshotCount = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rdb-storage-connection-string"))
                {
                    rdbStorageConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aof-storage-connection-string-0"))
                {
                    aofStorageConnectionString0 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aof-storage-connection-string-1"))
                {
                    aofStorageConnectionString1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxfragmentationmemory-reserved"))
                {
                    maxfragmentationmemoryReserved = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxmemory-policy"))
                {
                    maxmemoryPolicy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxmemory-reserved"))
                {
                    maxmemoryReserved = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxmemory-delta"))
                {
                    maxmemoryDelta = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxclients"))
                {
                    maxclients = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preferred-data-archive-auth-method"))
                {
                    preferredDataArchiveAuthMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preferred-data-persistence-auth-method"))
                {
                    preferredDataPersistenceAuthMethod = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new RedisCommonPropertiesRedisConfiguration(rdbBackupEnabled.Value, rdbBackupFrequency.Value, rdbBackupMaxSnapshotCount.Value, rdbStorageConnectionString.Value, aofStorageConnectionString0.Value, aofStorageConnectionString1.Value, maxfragmentationmemoryReserved.Value, maxmemoryPolicy.Value, maxmemoryReserved.Value, maxmemoryDelta.Value, maxclients.Value, preferredDataArchiveAuthMethod.Value, preferredDataPersistenceAuthMethod.Value, additionalProperties);
        }
    }
}
