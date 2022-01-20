// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class LogAnalytics : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("workspaceId");
            writer.WriteStringValue(WorkspaceId);
            writer.WritePropertyName("workspaceKey");
            writer.WriteStringValue(WorkspaceKey);
            if (Optional.IsDefined(LogType))
            {
                writer.WritePropertyName("logType");
                writer.WriteStringValue(LogType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(WorkspaceResourceId))
            {
                writer.WritePropertyName("workspaceResourceId");
                writer.WriteStringValue(WorkspaceResourceId);
            }
            writer.WriteEndObject();
        }

        internal static LogAnalytics DeserializeLogAnalytics(JsonElement element)
        {
            string workspaceId = default;
            string workspaceKey = default;
            Optional<LogAnalyticsLogType> logType = default;
            Optional<IDictionary<string, string>> metadata = default;
            Optional<string> workspaceResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaceId"))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceKey"))
                {
                    workspaceKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    logType = new LogAnalyticsLogType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("workspaceResourceId"))
                {
                    workspaceResourceId = property.Value.GetString();
                    continue;
                }
            }
            return new LogAnalytics(workspaceId, workspaceKey, Optional.ToNullable(logType), Optional.ToDictionary(metadata), workspaceResourceId.Value);
        }
    }
}
