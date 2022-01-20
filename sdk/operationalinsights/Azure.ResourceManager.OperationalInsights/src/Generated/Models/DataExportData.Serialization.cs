// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.OperationalInsights.Models;

namespace Azure.ResourceManager.OperationalInsights
{
    public partial class DataExportData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DataExportId))
            {
                writer.WritePropertyName("dataExportId");
                writer.WriteStringValue(DataExportId);
            }
            if (Optional.IsCollectionDefined(TableNames))
            {
                writer.WritePropertyName("tableNames");
                writer.WriteStartArray();
                foreach (var item in TableNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Enable))
            {
                writer.WritePropertyName("enable");
                writer.WriteBooleanValue(Enable.Value);
            }
            if (Optional.IsDefined(CreatedDate))
            {
                writer.WritePropertyName("createdDate");
                writer.WriteStringValue(CreatedDate);
            }
            if (Optional.IsDefined(LastModifiedDate))
            {
                writer.WritePropertyName("lastModifiedDate");
                writer.WriteStringValue(LastModifiedDate);
            }
            writer.WritePropertyName("destination");
            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId");
                writer.WriteStringValue(ResourceId);
            }
            writer.WritePropertyName("metaData");
            writer.WriteStartObject();
            if (Optional.IsDefined(EventHubName))
            {
                writer.WritePropertyName("eventHubName");
                writer.WriteStringValue(EventHubName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DataExportData DeserializeDataExportData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> dataExportId = default;
            Optional<IList<string>> tableNames = default;
            Optional<bool> enable = default;
            Optional<string> createdDate = default;
            Optional<string> lastModifiedDate = default;
            Optional<string> resourceId = default;
            Optional<Type> type0 = default;
            Optional<string> eventHubName = default;
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
                        if (property0.NameEquals("dataExportId"))
                        {
                            dataExportId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tableNames"))
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
                            tableNames = array;
                            continue;
                        }
                        if (property0.NameEquals("enable"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enable = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("createdDate"))
                        {
                            createdDate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedDate"))
                        {
                            lastModifiedDate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("destination"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("resourceId"))
                                {
                                    resourceId = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("type"))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    type0 = new Type(property1.Value.GetString());
                                    continue;
                                }
                                if (property1.NameEquals("metaData"))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    foreach (var property2 in property1.Value.EnumerateObject())
                                    {
                                        if (property2.NameEquals("eventHubName"))
                                        {
                                            eventHubName = property2.Value.GetString();
                                            continue;
                                        }
                                    }
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DataExportData(id, name, type, dataExportId.Value, Optional.ToList(tableNames), Optional.ToNullable(enable), createdDate.Value, lastModifiedDate.Value, resourceId.Value, Optional.ToNullable(type0), eventHubName.Value);
        }
    }
}
