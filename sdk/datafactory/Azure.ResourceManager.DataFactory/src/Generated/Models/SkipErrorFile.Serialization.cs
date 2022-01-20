// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SkipErrorFile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FileMissing))
            {
                writer.WritePropertyName("fileMissing");
                writer.WriteObjectValue(FileMissing);
            }
            if (Optional.IsDefined(DataInconsistency))
            {
                writer.WritePropertyName("dataInconsistency");
                writer.WriteObjectValue(DataInconsistency);
            }
            writer.WriteEndObject();
        }

        internal static SkipErrorFile DeserializeSkipErrorFile(JsonElement element)
        {
            Optional<object> fileMissing = default;
            Optional<object> dataInconsistency = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileMissing"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fileMissing = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("dataInconsistency"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataInconsistency = property.Value.GetObject();
                    continue;
                }
            }
            return new SkipErrorFile(fileMissing.Value, dataInconsistency.Value);
        }
    }
}
