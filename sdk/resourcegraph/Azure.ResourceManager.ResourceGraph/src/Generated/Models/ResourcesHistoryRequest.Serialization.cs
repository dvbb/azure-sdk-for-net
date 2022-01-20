// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    public partial class ResourcesHistoryRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Subscriptions))
            {
                writer.WritePropertyName("subscriptions");
                writer.WriteStartArray();
                foreach (var item in Subscriptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query");
                writer.WriteStringValue(Query);
            }
            if (Optional.IsDefined(Options))
            {
                writer.WritePropertyName("options");
                writer.WriteObjectValue(Options);
            }
            if (Optional.IsCollectionDefined(ManagementGroups))
            {
                writer.WritePropertyName("managementGroups");
                writer.WriteStartArray();
                foreach (var item in ManagementGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
