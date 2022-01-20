// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    public partial class ExportRDBParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format");
                writer.WriteStringValue(Format);
            }
            writer.WritePropertyName("prefix");
            writer.WriteStringValue(Prefix);
            writer.WritePropertyName("container");
            writer.WriteStringValue(Container);
            writer.WriteEndObject();
        }
    }
}
