// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetUpgradePolicy : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetUpgradePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetUpgradePolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineScaleSetUpgradePolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpgradePolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToSerialString());
            }
            if (Optional.IsDefined(RollingUpgradePolicy))
            {
                writer.WritePropertyName("rollingUpgradePolicy"u8);
                writer.WriteObjectValue(RollingUpgradePolicy);
            }
            if (Optional.IsDefined(AutomaticOSUpgradePolicy))
            {
                writer.WritePropertyName("automaticOSUpgradePolicy"u8);
                writer.WriteObjectValue(AutomaticOSUpgradePolicy);
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

        VirtualMachineScaleSetUpgradePolicy IJsonModel<VirtualMachineScaleSetUpgradePolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpgradePolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetUpgradePolicy(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetUpgradePolicy DeserializeVirtualMachineScaleSetUpgradePolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VirtualMachineScaleSetUpgradeMode> mode = default;
            Optional<RollingUpgradePolicy> rollingUpgradePolicy = default;
            Optional<AutomaticOSUpgradePolicy> automaticOSUpgradePolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = property.Value.GetString().ToVirtualMachineScaleSetUpgradeMode();
                    continue;
                }
                if (property.NameEquals("rollingUpgradePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rollingUpgradePolicy = RollingUpgradePolicy.DeserializeRollingUpgradePolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("automaticOSUpgradePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automaticOSUpgradePolicy = AutomaticOSUpgradePolicy.DeserializeAutomaticOSUpgradePolicy(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineScaleSetUpgradePolicy(Optional.ToNullable(mode), rollingUpgradePolicy.Value, automaticOSUpgradePolicy.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetUpgradePolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpgradePolicy)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetUpgradePolicy IPersistableModel<VirtualMachineScaleSetUpgradePolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetUpgradePolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetUpgradePolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetUpgradePolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
