// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFlowStagingInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedService))
            {
                writer.WritePropertyName("linkedService");
                writer.WriteObjectValue(LinkedService);
            }
            if (Optional.IsDefined(FolderPath))
            {
                writer.WritePropertyName("folderPath");
                writer.WriteObjectValue(FolderPath);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowStagingInfo DeserializeDataFlowStagingInfo(JsonElement element)
        {
            Optional<LinkedServiceReference> linkedService = default;
            Optional<object> folderPath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedService"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("folderPath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    folderPath = property.Value.GetObject();
                    continue;
                }
            }
            return new DataFlowStagingInfo(linkedService.Value, folderPath.Value);
        }
    }
}
