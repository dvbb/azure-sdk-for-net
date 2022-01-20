// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class CertificateCreateOrUpdateParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ThumbprintAlgorithm))
            {
                writer.WritePropertyName("thumbprintAlgorithm");
                writer.WriteStringValue(ThumbprintAlgorithm);
            }
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint");
                writer.WriteStringValue(Thumbprint);
            }
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format");
                writer.WriteStringValue(Format.Value.ToSerialString());
            }
            if (Optional.IsDefined(Data))
            {
                writer.WritePropertyName("data");
                writer.WriteStringValue(Data);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteStringValue(Password);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CertificateCreateOrUpdateParameters DeserializeCertificateCreateOrUpdateParameters(JsonElement element)
        {
            Optional<string> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> thumbprintAlgorithm = default;
            Optional<string> thumbprint = default;
            Optional<CertificateFormat> format = default;
            Optional<string> data = default;
            Optional<string> password = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
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
                        if (property0.NameEquals("thumbprintAlgorithm"))
                        {
                            thumbprintAlgorithm = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"))
                        {
                            thumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("format"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            format = property0.Value.GetString().ToCertificateFormat();
                            continue;
                        }
                        if (property0.NameEquals("data"))
                        {
                            data = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("password"))
                        {
                            password = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CertificateCreateOrUpdateParameters(id, name, type, etag.Value, thumbprintAlgorithm.Value, thumbprint.Value, Optional.ToNullable(format), data.Value, password.Value);
        }
    }
}
