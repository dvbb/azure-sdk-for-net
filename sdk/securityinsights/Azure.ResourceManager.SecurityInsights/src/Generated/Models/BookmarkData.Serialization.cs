// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class BookmarkData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Created))
            {
                writer.WritePropertyName("created");
                writer.WriteStringValue(Created.Value, "O");
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy");
                writer.WriteObjectValue(CreatedBy);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels");
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes");
                writer.WriteStringValue(Notes);
            }
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query");
                writer.WriteStringValue(Query);
            }
            if (Optional.IsDefined(QueryResult))
            {
                writer.WritePropertyName("queryResult");
                writer.WriteStringValue(QueryResult);
            }
            if (Optional.IsDefined(Updated))
            {
                writer.WritePropertyName("updated");
                writer.WriteStringValue(Updated.Value, "O");
            }
            if (Optional.IsDefined(UpdatedBy))
            {
                writer.WritePropertyName("updatedBy");
                writer.WriteObjectValue(UpdatedBy);
            }
            if (Optional.IsDefined(EventTime))
            {
                writer.WritePropertyName("eventTime");
                writer.WriteStringValue(EventTime.Value, "O");
            }
            if (Optional.IsDefined(QueryStartTime))
            {
                writer.WritePropertyName("queryStartTime");
                writer.WriteStringValue(QueryStartTime.Value, "O");
            }
            if (Optional.IsDefined(QueryEndTime))
            {
                writer.WritePropertyName("queryEndTime");
                writer.WriteStringValue(QueryEndTime.Value, "O");
            }
            if (Optional.IsDefined(IncidentInfo))
            {
                writer.WritePropertyName("incidentInfo");
                writer.WriteObjectValue(IncidentInfo);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BookmarkData DeserializeBookmarkData(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<SystemData> systemData = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<DateTimeOffset> created = default;
            Optional<UserInfo> createdBy = default;
            Optional<string> displayName = default;
            Optional<IList<string>> labels = default;
            Optional<string> notes = default;
            Optional<string> query = default;
            Optional<string> queryResult = default;
            Optional<DateTimeOffset> updated = default;
            Optional<UserInfo> updatedBy = default;
            Optional<DateTimeOffset> eventTime = default;
            Optional<DateTimeOffset> queryStartTime = default;
            Optional<DateTimeOffset> queryEndTime = default;
            Optional<IncidentInfo> incidentInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("created"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdBy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdBy = UserInfo.DeserializeUserInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("labels"))
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
                            labels = array;
                            continue;
                        }
                        if (property0.NameEquals("notes"))
                        {
                            notes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("query"))
                        {
                            query = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("queryResult"))
                        {
                            queryResult = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("updated"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            updated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updatedBy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            updatedBy = UserInfo.DeserializeUserInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("eventTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            eventTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("queryStartTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            queryStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("queryEndTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            queryEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("incidentInfo"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            incidentInfo = IncidentInfo.DeserializeIncidentInfo(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BookmarkData(id, name, type, systemData, etag.Value, Optional.ToNullable(created), createdBy.Value, displayName.Value, Optional.ToList(labels), notes.Value, query.Value, queryResult.Value, Optional.ToNullable(updated), updatedBy.Value, Optional.ToNullable(eventTime), Optional.ToNullable(queryStartTime), Optional.ToNullable(queryEndTime), incidentInfo.Value);
        }
    }
}
