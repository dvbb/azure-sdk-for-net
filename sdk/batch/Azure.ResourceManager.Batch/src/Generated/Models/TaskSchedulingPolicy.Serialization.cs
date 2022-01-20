// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class TaskSchedulingPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("nodeFillType");
            writer.WriteStringValue(NodeFillType.ToSerialString());
            writer.WriteEndObject();
        }

        internal static TaskSchedulingPolicy DeserializeTaskSchedulingPolicy(JsonElement element)
        {
            ComputeNodeFillType nodeFillType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeFillType"))
                {
                    nodeFillType = property.Value.GetString().ToComputeNodeFillType();
                    continue;
                }
            }
            return new TaskSchedulingPolicy(nodeFillType);
        }
    }
}
