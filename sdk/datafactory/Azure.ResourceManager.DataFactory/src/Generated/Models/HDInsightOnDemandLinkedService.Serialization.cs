// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class HDInsightOnDemandLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
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
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            writer.WritePropertyName("clusterSize");
            writer.WriteObjectValue(ClusterSize);
            writer.WritePropertyName("timeToLive");
            writer.WriteObjectValue(TimeToLive);
            writer.WritePropertyName("version");
            writer.WriteObjectValue(Version);
            writer.WritePropertyName("linkedServiceName");
            writer.WriteObjectValue(LinkedServiceName);
            writer.WritePropertyName("hostSubscriptionId");
            writer.WriteObjectValue(HostSubscriptionId);
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId");
                writer.WriteObjectValue(ServicePrincipalId);
            }
            if (Optional.IsDefined(ServicePrincipalKey))
            {
                writer.WritePropertyName("servicePrincipalKey");
                writer.WriteObjectValue(ServicePrincipalKey);
            }
            writer.WritePropertyName("tenant");
            writer.WriteObjectValue(Tenant);
            writer.WritePropertyName("clusterResourceGroup");
            writer.WriteObjectValue(ClusterResourceGroup);
            if (Optional.IsDefined(ClusterNamePrefix))
            {
                writer.WritePropertyName("clusterNamePrefix");
                writer.WriteObjectValue(ClusterNamePrefix);
            }
            if (Optional.IsDefined(ClusterUserName))
            {
                writer.WritePropertyName("clusterUserName");
                writer.WriteObjectValue(ClusterUserName);
            }
            if (Optional.IsDefined(ClusterPassword))
            {
                writer.WritePropertyName("clusterPassword");
                writer.WriteObjectValue(ClusterPassword);
            }
            if (Optional.IsDefined(ClusterSshUserName))
            {
                writer.WritePropertyName("clusterSshUserName");
                writer.WriteObjectValue(ClusterSshUserName);
            }
            if (Optional.IsDefined(ClusterSshPassword))
            {
                writer.WritePropertyName("clusterSshPassword");
                writer.WriteObjectValue(ClusterSshPassword);
            }
            if (Optional.IsCollectionDefined(AdditionalLinkedServiceNames))
            {
                writer.WritePropertyName("additionalLinkedServiceNames");
                writer.WriteStartArray();
                foreach (var item in AdditionalLinkedServiceNames)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HcatalogLinkedServiceName))
            {
                writer.WritePropertyName("hcatalogLinkedServiceName");
                writer.WriteObjectValue(HcatalogLinkedServiceName);
            }
            if (Optional.IsDefined(ClusterType))
            {
                writer.WritePropertyName("clusterType");
                writer.WriteObjectValue(ClusterType);
            }
            if (Optional.IsDefined(SparkVersion))
            {
                writer.WritePropertyName("sparkVersion");
                writer.WriteObjectValue(SparkVersion);
            }
            if (Optional.IsDefined(CoreConfiguration))
            {
                writer.WritePropertyName("coreConfiguration");
                writer.WriteObjectValue(CoreConfiguration);
            }
            if (Optional.IsDefined(HBaseConfiguration))
            {
                writer.WritePropertyName("hBaseConfiguration");
                writer.WriteObjectValue(HBaseConfiguration);
            }
            if (Optional.IsDefined(HdfsConfiguration))
            {
                writer.WritePropertyName("hdfsConfiguration");
                writer.WriteObjectValue(HdfsConfiguration);
            }
            if (Optional.IsDefined(HiveConfiguration))
            {
                writer.WritePropertyName("hiveConfiguration");
                writer.WriteObjectValue(HiveConfiguration);
            }
            if (Optional.IsDefined(MapReduceConfiguration))
            {
                writer.WritePropertyName("mapReduceConfiguration");
                writer.WriteObjectValue(MapReduceConfiguration);
            }
            if (Optional.IsDefined(OozieConfiguration))
            {
                writer.WritePropertyName("oozieConfiguration");
                writer.WriteObjectValue(OozieConfiguration);
            }
            if (Optional.IsDefined(StormConfiguration))
            {
                writer.WritePropertyName("stormConfiguration");
                writer.WriteObjectValue(StormConfiguration);
            }
            if (Optional.IsDefined(YarnConfiguration))
            {
                writer.WritePropertyName("yarnConfiguration");
                writer.WriteObjectValue(YarnConfiguration);
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential");
                writer.WriteObjectValue(EncryptedCredential);
            }
            if (Optional.IsDefined(HeadNodeSize))
            {
                writer.WritePropertyName("headNodeSize");
                writer.WriteObjectValue(HeadNodeSize);
            }
            if (Optional.IsDefined(DataNodeSize))
            {
                writer.WritePropertyName("dataNodeSize");
                writer.WriteObjectValue(DataNodeSize);
            }
            if (Optional.IsDefined(ZookeeperNodeSize))
            {
                writer.WritePropertyName("zookeeperNodeSize");
                writer.WriteObjectValue(ZookeeperNodeSize);
            }
            if (Optional.IsCollectionDefined(ScriptActions))
            {
                writer.WritePropertyName("scriptActions");
                writer.WriteStartArray();
                foreach (var item in ScriptActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VirtualNetworkId))
            {
                writer.WritePropertyName("virtualNetworkId");
                writer.WriteObjectValue(VirtualNetworkId);
            }
            if (Optional.IsDefined(SubnetName))
            {
                writer.WritePropertyName("subnetName");
                writer.WriteObjectValue(SubnetName);
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
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static HDInsightOnDemandLinkedService DeserializeHDInsightOnDemandLinkedService(JsonElement element)
        {
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, ParameterSpecification>> parameters = default;
            Optional<IList<object>> annotations = default;
            object clusterSize = default;
            object timeToLive = default;
            object version = default;
            LinkedServiceReference linkedServiceName = default;
            object hostSubscriptionId = default;
            Optional<object> servicePrincipalId = default;
            Optional<SecretBase> servicePrincipalKey = default;
            object tenant = default;
            object clusterResourceGroup = default;
            Optional<object> clusterNamePrefix = default;
            Optional<object> clusterUserName = default;
            Optional<SecretBase> clusterPassword = default;
            Optional<object> clusterSshUserName = default;
            Optional<SecretBase> clusterSshPassword = default;
            Optional<IList<LinkedServiceReference>> additionalLinkedServiceNames = default;
            Optional<LinkedServiceReference> hcatalogLinkedServiceName = default;
            Optional<object> clusterType = default;
            Optional<object> sparkVersion = default;
            Optional<object> coreConfiguration = default;
            Optional<object> hBaseConfiguration = default;
            Optional<object> hdfsConfiguration = default;
            Optional<object> hiveConfiguration = default;
            Optional<object> mapReduceConfiguration = default;
            Optional<object> oozieConfiguration = default;
            Optional<object> stormConfiguration = default;
            Optional<object> yarnConfiguration = default;
            Optional<object> encryptedCredential = default;
            Optional<object> headNodeSize = default;
            Optional<object> dataNodeSize = default;
            Optional<object> zookeeperNodeSize = default;
            Optional<IList<ScriptAction>> scriptActions = default;
            Optional<object> virtualNetworkId = default;
            Optional<object> subnetName = default;
            Optional<CredentialReference> credential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
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
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetObject());
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
                        if (property0.NameEquals("clusterSize"))
                        {
                            clusterSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("timeToLive"))
                        {
                            timeToLive = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("version"))
                        {
                            version = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("linkedServiceName"))
                        {
                            linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostSubscriptionId"))
                        {
                            hostSubscriptionId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            servicePrincipalId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalKey"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            servicePrincipalKey = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("tenant"))
                        {
                            tenant = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clusterResourceGroup"))
                        {
                            clusterResourceGroup = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clusterNamePrefix"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterNamePrefix = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clusterUserName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterUserName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clusterPassword"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterPassword = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clusterSshUserName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterSshUserName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clusterSshPassword"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterSshPassword = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("additionalLinkedServiceNames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<LinkedServiceReference> array = new List<LinkedServiceReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(LinkedServiceReference.DeserializeLinkedServiceReference(item));
                            }
                            additionalLinkedServiceNames = array;
                            continue;
                        }
                        if (property0.NameEquals("hcatalogLinkedServiceName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hcatalogLinkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("clusterType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterType = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sparkVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sparkVersion = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("coreConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            coreConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("hBaseConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hBaseConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("hdfsConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hdfsConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("hiveConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hiveConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("mapReduceConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            mapReduceConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("oozieConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            oozieConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("stormConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            stormConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("yarnConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            yarnConfiguration = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("headNodeSize"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            headNodeSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("dataNodeSize"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dataNodeSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("zookeeperNodeSize"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            zookeeperNodeSize = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("scriptActions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ScriptAction> array = new List<ScriptAction>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ScriptAction.DeserializeScriptAction(item));
                            }
                            scriptActions = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualNetworkId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("subnetName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            subnetName = property0.Value.GetObject();
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
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new HDInsightOnDemandLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, clusterSize, timeToLive, version, linkedServiceName, hostSubscriptionId, servicePrincipalId.Value, servicePrincipalKey.Value, tenant, clusterResourceGroup, clusterNamePrefix.Value, clusterUserName.Value, clusterPassword.Value, clusterSshUserName.Value, clusterSshPassword.Value, Optional.ToList(additionalLinkedServiceNames), hcatalogLinkedServiceName.Value, clusterType.Value, sparkVersion.Value, coreConfiguration.Value, hBaseConfiguration.Value, hdfsConfiguration.Value, hiveConfiguration.Value, mapReduceConfiguration.Value, oozieConfiguration.Value, stormConfiguration.Value, yarnConfiguration.Value, encryptedCredential.Value, headNodeSize.Value, dataNodeSize.Value, zookeeperNodeSize.Value, Optional.ToList(scriptActions), virtualNetworkId.Value, subnetName.Value, credential.Value);
        }
    }
}
