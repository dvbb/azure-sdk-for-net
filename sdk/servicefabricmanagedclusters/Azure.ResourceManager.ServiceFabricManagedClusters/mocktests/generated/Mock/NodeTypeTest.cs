// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.ServiceFabricManagedClusters.Tests.Mock;
using Azure.ResourceManager.ServiceFabricManagedClusters.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Tests.Mock.Tests.Mock
{
    /// <summary> Test for NodeType. </summary>
    public partial class NodeTypeMockTests : MockTestBase
    {
        public NodeTypeMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get a node type
            var nodeTypeId = ServiceFabricManagedClusters.Tests.Mock.NodeType.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster", "FE");
            var nodeType = GetArmClient().GetNodeType(nodeTypeId);

            await nodeType.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete a node type
            var nodeTypeId = ServiceFabricManagedClusters.Tests.Mock.NodeType.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster", "BE");
            var nodeType = GetArmClient().GetNodeType(nodeTypeId);

            await nodeType.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: Patch a node type
            var nodeTypeId = ServiceFabricManagedClusters.Tests.Mock.NodeType.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster", "BE");
            var nodeType = GetArmClient().GetNodeType(nodeTypeId);
            ServiceFabricManagedClusters.Tests.Mock.Models.NodeTypeUpdateParameters parameters = new ServiceFabricManagedClusters.Tests.Mock.Models.NodeTypeUpdateParameters();

            await nodeType.UpdateAsync(parameters);
        }

        [RecordedTest]
        public async Task Update2()
        {
            // Example: Patch a node type while auto-scaling
            var nodeTypeId = ServiceFabricManagedClusters.Tests.Mock.NodeType.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster", "BE");
            var nodeType = GetArmClient().GetNodeType(nodeTypeId);
            ServiceFabricManagedClusters.Tests.Mock.Models.NodeTypeUpdateParameters parameters = new ServiceFabricManagedClusters.Tests.Mock.Models.NodeTypeUpdateParameters()
            {
                Sku = new ServiceFabricManagedClusters.Tests.Mock.Models.NodeTypeSku(capacity: 10)
                {
                    Name = "Standard_S0",
                    Tier = "Standard",
                },
            };

            await nodeType.UpdateAsync(parameters);
        }

        [RecordedTest]
        public async Task Restart()
        {
            // Example: Restart nodes
            var nodeTypeId = ServiceFabricManagedClusters.Tests.Mock.NodeType.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster", "BE");
            var nodeType = GetArmClient().GetNodeType(nodeTypeId);
            ServiceFabricManagedClusters.Tests.Mock.Models.NodeTypeActionParameters parameters = new ServiceFabricManagedClusters.Tests.Mock.Models.NodeTypeActionParameters(nodes: new List<string>()
{
"BE_0","BE_3",});

            await nodeType.RestartAsync(true, parameters);
        }

        [RecordedTest]
        public async Task Reimage()
        {
            // Example: Reimage nodes
            var nodeTypeId = ServiceFabricManagedClusters.Tests.Mock.NodeType.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster", "BE");
            var nodeType = GetArmClient().GetNodeType(nodeTypeId);
            ServiceFabricManagedClusters.Tests.Mock.Models.NodeTypeActionParameters parameters = new ServiceFabricManagedClusters.Tests.Mock.Models.NodeTypeActionParameters(nodes: new List<string>()
{
"BE_0","BE_3",});

            await nodeType.ReimageAsync(true, parameters);
        }

        [RecordedTest]
        public async Task DeleteNode()
        {
            // Example: Delete nodes
            var nodeTypeId = ServiceFabricManagedClusters.Tests.Mock.NodeType.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster", "BE");
            var nodeType = GetArmClient().GetNodeType(nodeTypeId);
            ServiceFabricManagedClusters.Tests.Mock.Models.NodeTypeActionParameters parameters = new ServiceFabricManagedClusters.Tests.Mock.Models.NodeTypeActionParameters(nodes: new List<string>()
{
"BE_0","BE_3",});

            await nodeType.DeleteNodeAsync(true, parameters);
        }

        [RecordedTest]
        public async Task GetNodeTypeSkus()
        {
            // Example: List a node type SKUs
            var nodeTypeId = ServiceFabricManagedClusters.Tests.Mock.NodeType.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster", "BE");
            var nodeType = GetArmClient().GetNodeType(nodeTypeId);

            await foreach (var _ in nodeType.GetNodeTypeSkusAsync())
            {
            }
        }
    }
}
