// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class SqlDatabaseOutputDataSource : IUtf8JsonSerializable, IJsonModel<SqlDatabaseOutputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlDatabaseOutputDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlDatabaseOutputDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDatabaseOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlDatabaseOutputDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(OutputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Server))
            {
                writer.WritePropertyName("server"u8);
                writer.WriteStringValue(Server);
            }
            if (Optional.IsDefined(Database))
            {
                writer.WritePropertyName("database"u8);
                writer.WriteStringValue(Database);
            }
            if (Optional.IsDefined(User))
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(User);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(Table))
            {
                writer.WritePropertyName("table"u8);
                writer.WriteStringValue(Table);
            }
            if (Optional.IsDefined(MaxBatchCount))
            {
                writer.WritePropertyName("maxBatchCount"u8);
                writer.WriteNumberValue(MaxBatchCount.Value);
            }
            if (Optional.IsDefined(MaxWriterCount))
            {
                writer.WritePropertyName("maxWriterCount"u8);
                writer.WriteNumberValue(MaxWriterCount.Value);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode"u8);
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            writer.WriteEndObject();
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

        SqlDatabaseOutputDataSource IJsonModel<SqlDatabaseOutputDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDatabaseOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlDatabaseOutputDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlDatabaseOutputDataSource(document.RootElement, options);
        }

        internal static SqlDatabaseOutputDataSource DeserializeSqlDatabaseOutputDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string server = default;
            string database = default;
            string user = default;
            string password = default;
            string table = default;
            int? maxBatchCount = default;
            int? maxWriterCount = default;
            StreamAnalyticsAuthenticationMode? authenticationMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("server"u8))
                        {
                            server = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("database"u8))
                        {
                            database = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("user"u8))
                        {
                            user = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            password = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("table"u8))
                        {
                            table = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maxBatchCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxBatchCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxWriterCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxWriterCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationMode = new StreamAnalyticsAuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlDatabaseOutputDataSource(
                type,
                serializedAdditionalRawData,
                server,
                database,
                user,
                password,
                table,
                maxBatchCount,
                maxWriterCount,
                authenticationMode);
        }

        BinaryData IPersistableModel<SqlDatabaseOutputDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDatabaseOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlDatabaseOutputDataSource)} does not support '{options.Format}' format.");
            }
        }

        SqlDatabaseOutputDataSource IPersistableModel<SqlDatabaseOutputDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDatabaseOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlDatabaseOutputDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlDatabaseOutputDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlDatabaseOutputDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
