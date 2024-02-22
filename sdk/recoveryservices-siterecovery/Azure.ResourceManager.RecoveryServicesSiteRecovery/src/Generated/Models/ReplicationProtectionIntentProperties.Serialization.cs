// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ReplicationProtectionIntentProperties : IUtf8JsonSerializable, IJsonModel<ReplicationProtectionIntentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReplicationProtectionIntentProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReplicationProtectionIntentProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProtectionIntentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationProtectionIntentProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            if (options.Format != "W" && Optional.IsDefined(JobState))
            {
                writer.WritePropertyName("jobState"u8);
                writer.WriteStringValue(JobState);
            }
            if (options.Format != "W" && Optional.IsDefined(IsActive))
            {
                writer.WritePropertyName("isActive"u8);
                writer.WriteBooleanValue(IsActive.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTimeUTC"u8);
                writer.WriteStringValue(CreatedOn);
            }
            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteObjectValue(ProviderSpecificDetails);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ReplicationProtectionIntentProperties IJsonModel<ReplicationProtectionIntentProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProtectionIntentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplicationProtectionIntentProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReplicationProtectionIntentProperties(document.RootElement, options);
        }

        internal static ReplicationProtectionIntentProperties DeserializeReplicationProtectionIntentProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> friendlyName = default;
            Optional<ResourceIdentifier> jobId = default;
            Optional<string> jobState = default;
            Optional<bool> isActive = default;
            Optional<string> creationTimeUTC = default;
            Optional<ReplicationProtectionIntentProviderSpecificSettings> providerSpecificDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobState"u8))
                {
                    jobState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isActive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isActive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("creationTimeUTC"u8))
                {
                    creationTimeUTC = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificDetails = ReplicationProtectionIntentProviderSpecificSettings.DeserializeReplicationProtectionIntentProviderSpecificSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReplicationProtectionIntentProperties(friendlyName.Value, jobId.Value, jobState.Value, Optional.ToNullable(isActive), creationTimeUTC.Value, providerSpecificDetails.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReplicationProtectionIntentProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProtectionIntentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReplicationProtectionIntentProperties)} does not support '{options.Format}' format.");
            }
        }

        ReplicationProtectionIntentProperties IPersistableModel<ReplicationProtectionIntentProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplicationProtectionIntentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReplicationProtectionIntentProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReplicationProtectionIntentProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReplicationProtectionIntentProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
