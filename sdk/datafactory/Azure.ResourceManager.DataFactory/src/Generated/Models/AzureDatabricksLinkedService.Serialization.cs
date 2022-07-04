// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AzureDatabricksLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(LinkedServiceType);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia");
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
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
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("domain");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Domain);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(Domain.ToString()).RootElement);
#endif
            if (Optional.IsDefined(AccessToken))
            {
                writer.WritePropertyName("accessToken");
                writer.WriteObjectValue(AccessToken);
            }
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Authentication);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Authentication.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(WorkspaceResourceId))
            {
                writer.WritePropertyName("workspaceResourceId");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(WorkspaceResourceId);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(WorkspaceResourceId.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ExistingClusterId))
            {
                writer.WritePropertyName("existingClusterId");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ExistingClusterId);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ExistingClusterId.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(InstancePoolId))
            {
                writer.WritePropertyName("instancePoolId");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(InstancePoolId);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(InstancePoolId.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(NewClusterVersion))
            {
                writer.WritePropertyName("newClusterVersion");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(NewClusterVersion);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(NewClusterVersion.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(NewClusterNumOfWorker))
            {
                writer.WritePropertyName("newClusterNumOfWorker");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(NewClusterNumOfWorker);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(NewClusterNumOfWorker.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(NewClusterNodeType))
            {
                writer.WritePropertyName("newClusterNodeType");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(NewClusterNodeType);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(NewClusterNodeType.ToString()).RootElement);
#endif
            }
            if (Optional.IsCollectionDefined(NewClusterSparkConf))
            {
                writer.WritePropertyName("newClusterSparkConf");
                writer.WriteStartObject();
                foreach (var item in NewClusterSparkConf)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(NewClusterSparkEnvVars))
            {
                writer.WritePropertyName("newClusterSparkEnvVars");
                writer.WriteStartObject();
                foreach (var item in NewClusterSparkEnvVars)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(NewClusterCustomTags))
            {
                writer.WritePropertyName("newClusterCustomTags");
                writer.WriteStartObject();
                foreach (var item in NewClusterCustomTags)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(NewClusterLogDestination))
            {
                writer.WritePropertyName("newClusterLogDestination");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(NewClusterLogDestination);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(NewClusterLogDestination.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(NewClusterDriverNodeType))
            {
                writer.WritePropertyName("newClusterDriverNodeType");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(NewClusterDriverNodeType);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(NewClusterDriverNodeType.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(NewClusterInitScripts))
            {
                writer.WritePropertyName("newClusterInitScripts");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(NewClusterInitScripts);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(NewClusterInitScripts.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(NewClusterEnableElasticDisk))
            {
                writer.WritePropertyName("newClusterEnableElasticDisk");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(NewClusterEnableElasticDisk);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(NewClusterEnableElasticDisk.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EncryptedCredential);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(EncryptedCredential.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(PolicyId);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(PolicyId.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential");
                writer.WriteObjectValue(Credential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static AzureDatabricksLinkedService DeserializeAzureDatabricksLinkedService(JsonElement element)
        {
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            BinaryData domain = default;
            Optional<SecretBase> accessToken = default;
            Optional<BinaryData> authentication = default;
            Optional<BinaryData> workspaceResourceId = default;
            Optional<BinaryData> existingClusterId = default;
            Optional<BinaryData> instancePoolId = default;
            Optional<BinaryData> newClusterVersion = default;
            Optional<BinaryData> newClusterNumOfWorker = default;
            Optional<BinaryData> newClusterNodeType = default;
            Optional<IDictionary<string, BinaryData>> newClusterSparkConf = default;
            Optional<IDictionary<string, BinaryData>> newClusterSparkEnvVars = default;
            Optional<IDictionary<string, BinaryData>> newClusterCustomTags = default;
            Optional<BinaryData> newClusterLogDestination = default;
            Optional<BinaryData> newClusterDriverNodeType = default;
            Optional<BinaryData> newClusterInitScripts = default;
            Optional<BinaryData> newClusterEnableElasticDisk = default;
            Optional<BinaryData> encryptedCredential = default;
            Optional<BinaryData> policyId = default;
            Optional<CredentialReference> credential = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BinaryData.FromString(item.GetRawText()));
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("domain"))
                        {
                            domain = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("accessToken"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            accessToken = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("authentication"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            authentication = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("workspaceResourceId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            workspaceResourceId = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("existingClusterId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            existingClusterId = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("instancePoolId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            instancePoolId = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("newClusterVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            newClusterVersion = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("newClusterNumOfWorker"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            newClusterNumOfWorker = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("newClusterNodeType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            newClusterNodeType = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("newClusterSparkConf"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                            }
                            newClusterSparkConf = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("newClusterSparkEnvVars"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                            }
                            newClusterSparkEnvVars = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("newClusterCustomTags"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                            }
                            newClusterCustomTags = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("newClusterLogDestination"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            newClusterLogDestination = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("newClusterDriverNodeType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            newClusterDriverNodeType = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("newClusterInitScripts"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            newClusterInitScripts = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("newClusterEnableElasticDisk"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            newClusterEnableElasticDisk = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptedCredential = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("policyId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            policyId = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("credential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            credential = CredentialReference.DeserializeCredentialReference(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureDatabricksLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, domain, accessToken.Value, authentication.Value, workspaceResourceId.Value, existingClusterId.Value, instancePoolId.Value, newClusterVersion.Value, newClusterNumOfWorker.Value, newClusterNodeType.Value, Optional.ToDictionary(newClusterSparkConf), Optional.ToDictionary(newClusterSparkEnvVars), Optional.ToDictionary(newClusterCustomTags), newClusterLogDestination.Value, newClusterDriverNodeType.Value, newClusterInitScripts.Value, newClusterEnableElasticDisk.Value, encryptedCredential.Value, policyId.Value, credential.Value);
        }
    }
}
