// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class SiteSourceControlData : IUtf8JsonSerializable, IJsonModel<SiteSourceControlData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteSourceControlData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteSourceControlData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteSourceControlData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteSourceControlData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RepoUri))
            {
                writer.WritePropertyName("repoUrl"u8);
                writer.WriteStringValue(RepoUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Branch))
            {
                writer.WritePropertyName("branch"u8);
                writer.WriteStringValue(Branch);
            }
            if (Optional.IsDefined(IsManualIntegration))
            {
                writer.WritePropertyName("isManualIntegration"u8);
                writer.WriteBooleanValue(IsManualIntegration.Value);
            }
            if (Optional.IsDefined(IsGitHubAction))
            {
                writer.WritePropertyName("isGitHubAction"u8);
                writer.WriteBooleanValue(IsGitHubAction.Value);
            }
            if (Optional.IsDefined(IsDeploymentRollbackEnabled))
            {
                writer.WritePropertyName("deploymentRollbackEnabled"u8);
                writer.WriteBooleanValue(IsDeploymentRollbackEnabled.Value);
            }
            if (Optional.IsDefined(IsMercurial))
            {
                writer.WritePropertyName("isMercurial"u8);
                writer.WriteBooleanValue(IsMercurial.Value);
            }
            if (Optional.IsDefined(GitHubActionConfiguration))
            {
                if (GitHubActionConfiguration != null)
                {
                    writer.WritePropertyName("gitHubActionConfiguration"u8);
                    writer.WriteObjectValue(GitHubActionConfiguration);
                }
                else
                {
                    writer.WriteNull("gitHubActionConfiguration");
                }
            }
            writer.WriteEndObject();
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

        SiteSourceControlData IJsonModel<SiteSourceControlData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteSourceControlData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteSourceControlData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteSourceControlData(document.RootElement, options);
        }

        internal static SiteSourceControlData DeserializeSiteSourceControlData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Uri> repoUrl = default;
            Optional<string> branch = default;
            Optional<bool> isManualIntegration = default;
            Optional<bool> isGitHubAction = default;
            Optional<bool> deploymentRollbackEnabled = default;
            Optional<bool> isMercurial = default;
            Optional<GitHubActionConfiguration> gitHubActionConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("repoUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            repoUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("branch"u8))
                        {
                            branch = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isManualIntegration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isManualIntegration = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isGitHubAction"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isGitHubAction = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("deploymentRollbackEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deploymentRollbackEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isMercurial"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isMercurial = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("gitHubActionConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                gitHubActionConfiguration = null;
                                continue;
                            }
                            gitHubActionConfiguration = GitHubActionConfiguration.DeserializeGitHubActionConfiguration(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteSourceControlData(id, name, type, systemData.Value, repoUrl.Value, branch.Value, Optional.ToNullable(isManualIntegration), Optional.ToNullable(isGitHubAction), Optional.ToNullable(deploymentRollbackEnabled), Optional.ToNullable(isMercurial), gitHubActionConfiguration.Value, kind.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteSourceControlData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteSourceControlData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteSourceControlData)} does not support '{options.Format}' format.");
            }
        }

        SiteSourceControlData IPersistableModel<SiteSourceControlData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteSourceControlData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteSourceControlData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteSourceControlData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteSourceControlData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
