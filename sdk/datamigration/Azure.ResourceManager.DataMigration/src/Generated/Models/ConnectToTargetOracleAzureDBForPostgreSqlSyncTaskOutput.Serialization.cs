// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput : IUtf8JsonSerializable, IJsonModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(TargetServerVersion))
            {
                writer.WritePropertyName("targetServerVersion"u8);
                writer.WriteStringValue(TargetServerVersion);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Databases))
            {
                writer.WritePropertyName("databases"u8);
                writer.WriteStartArray();
                foreach (var item in Databases)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(TargetServerBrandVersion))
            {
                writer.WritePropertyName("targetServerBrandVersion"u8);
                writer.WriteStringValue(TargetServerBrandVersion);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ValidationErrors))
            {
                writer.WritePropertyName("validationErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DatabaseSchemaMap))
            {
                writer.WritePropertyName("databaseSchemaMap"u8);
                writer.WriteStartArray();
                foreach (var item in DatabaseSchemaMap)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput IJsonModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput(document.RootElement, options);
        }

        internal static ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput DeserializeConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> targetServerVersion = default;
            Optional<IReadOnlyList<string>> databases = default;
            Optional<string> targetServerBrandVersion = default;
            Optional<IReadOnlyList<ReportableException>> validationErrors = default;
            Optional<IReadOnlyList<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem>> databaseSchemaMap = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetServerVersion"u8))
                {
                    targetServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databases"u8))
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
                    databases = array;
                    continue;
                }
                if (property.NameEquals("targetServerBrandVersion"u8))
                {
                    targetServerBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item, options));
                    }
                    validationErrors = array;
                    continue;
                }
                if (property.NameEquals("databaseSchemaMap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem> array = new List<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem.DeserializeConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutputDatabaseSchemaMapItem(item, options));
                    }
                    databaseSchemaMap = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput(targetServerVersion.Value, Optional.ToList(databases), targetServerBrandVersion.Value, Optional.ToList(validationErrors), Optional.ToList(databaseSchemaMap), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectToTargetOracleAzureDBForPostgreSqlSyncTaskOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
