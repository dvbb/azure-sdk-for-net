// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class CustomPersistentDiskProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("mountPath");
            writer.WriteStringValue(MountPath);
            if (Optional.IsDefined(ReadOnly))
            {
                writer.WritePropertyName("readOnly");
                writer.WriteBooleanValue(ReadOnly.Value);
            }
            if (Optional.IsCollectionDefined(MountOptions))
            {
                writer.WritePropertyName("mountOptions");
                writer.WriteStartArray();
                foreach (var item in MountOptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static CustomPersistentDiskProperties DeserializeCustomPersistentDiskProperties(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureFileVolume": return AzureFileVolume.DeserializeAzureFileVolume(element);
                }
            }
            CustomPersistentDiskPropertiesType type = default;
            string mountPath = default;
            Optional<bool> readOnly = default;
            Optional<IList<string>> mountOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new CustomPersistentDiskPropertiesType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mountPath"))
                {
                    mountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    readOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("mountOptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    mountOptions = array;
                    continue;
                }
            }
            return new CustomPersistentDiskProperties(type, mountPath, Optional.ToNullable(readOnly), Optional.ToList(mountOptions));
        }
    }
}
