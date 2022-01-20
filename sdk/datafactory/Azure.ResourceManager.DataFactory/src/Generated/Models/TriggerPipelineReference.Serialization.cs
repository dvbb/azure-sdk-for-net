// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class TriggerPipelineReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PipelineReference))
            {
                writer.WritePropertyName("pipelineReference");
                writer.WriteObjectValue(PipelineReference);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static TriggerPipelineReference DeserializeTriggerPipelineReference(JsonElement element)
        {
            Optional<PipelineReference> pipelineReference = default;
            Optional<IDictionary<string, object>> parameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipelineReference"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    pipelineReference = PipelineReference.DeserializePipelineReference(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    parameters = dictionary;
                    continue;
                }
            }
            return new TriggerPipelineReference(pipelineReference.Value, Optional.ToDictionary(parameters));
        }
    }
}
