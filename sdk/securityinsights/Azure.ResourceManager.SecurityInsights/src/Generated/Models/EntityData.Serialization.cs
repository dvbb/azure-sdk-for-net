// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class EntityData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static EntityData DeserializeEntityData(JsonElement element)
        {
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Account": return AccountEntity.DeserializeAccountEntity(element);
                    case "AzureResource": return AzureResourceEntity.DeserializeAzureResourceEntity(element);
                    case "Bookmark": return HuntingBookmark.DeserializeHuntingBookmark(element);
                    case "CloudApplication": return CloudApplicationEntity.DeserializeCloudApplicationEntity(element);
                    case "DnsResolution": return DnsEntity.DeserializeDnsEntity(element);
                    case "File": return FileEntity.DeserializeFileEntity(element);
                    case "FileHash": return FileHashEntity.DeserializeFileHashEntity(element);
                    case "Host": return HostEntity.DeserializeHostEntity(element);
                    case "IoTDevice": return IoTDeviceEntity.DeserializeIoTDeviceEntity(element);
                    case "Ip": return IpEntity.DeserializeIpEntity(element);
                    case "MailCluster": return MailClusterEntity.DeserializeMailClusterEntity(element);
                    case "MailMessage": return MailMessageEntity.DeserializeMailMessageEntity(element);
                    case "Mailbox": return MailboxEntity.DeserializeMailboxEntity(element);
                    case "Malware": return MalwareEntity.DeserializeMalwareEntity(element);
                    case "Process": return ProcessEntity.DeserializeProcessEntity(element);
                    case "RegistryKey": return RegistryKeyEntity.DeserializeRegistryKeyEntity(element);
                    case "RegistryValue": return RegistryValueEntity.DeserializeRegistryValueEntity(element);
                    case "SecurityAlert": return SecurityAlert.DeserializeSecurityAlert(element);
                    case "SecurityGroup": return SecurityGroupEntity.DeserializeSecurityGroupEntity(element);
                    case "SubmissionMail": return SubmissionMailEntity.DeserializeSubmissionMailEntity(element);
                    case "Url": return UrlEntity.DeserializeUrlEntity(element);
                }
            }
            EntityKind kind = default;
            Optional<SystemData> systemData = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new EntityKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
            }
            return new EntityData(id, name, type, systemData, kind);
        }
    }
}
