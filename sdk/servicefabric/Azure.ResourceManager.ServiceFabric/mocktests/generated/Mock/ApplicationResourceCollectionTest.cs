// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.ServiceFabric.Tests.Mock;
using Azure.ResourceManager.ServiceFabric.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.ServiceFabric.Tests.Mock.Tests.Mock
{
    /// <summary> Test for ApplicationResource. </summary>
    public partial class ApplicationResourceCollectionMockTests : MockTestBase
    {
        public ApplicationResourceCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Put an application with maximum parameters
            string applicationName = "myApp";
            ServiceFabric.Tests.Mock.ApplicationResourceData parameters = new ServiceFabric.Tests.Mock.ApplicationResourceData(location: AzureLocation.WestUS)
            {
                TypeVersion = "1.0",
                UpgradePolicy = new ServiceFabric.Tests.Mock.Models.ApplicationUpgradePolicy()
                {
                    UpgradeReplicaSetCheckTimeout = "01:00:00",
                    ForceRestart = false,
                    RollingUpgradeMonitoringPolicy = new ServiceFabric.Tests.Mock.Models.ArmRollingUpgradeMonitoringPolicy()
                    {
                        FailureAction = new ServiceFabric.Tests.Mock.Models.ArmUpgradeFailureAction("Rollback"),
                        HealthCheckWaitDuration = "00:02:00",
                        HealthCheckStableDuration = "00:05:00",
                        HealthCheckRetryTimeout = "00:10:00",
                        UpgradeTimeout = "01:00:00",
                        UpgradeDomainTimeout = "1.06:00:00",
                    },
                    ApplicationHealthPolicy = new ServiceFabric.Tests.Mock.Models.ArmApplicationHealthPolicy()
                    {
                        ConsiderWarningAsError = true,
                        MaxPercentUnhealthyDeployedApplications = 0,
                        DefaultServiceTypeHealthPolicy = new ServiceFabric.Tests.Mock.Models.ArmServiceTypeHealthPolicy()
                        {
                            MaxPercentUnhealthyServices = 0,
                            MaxPercentUnhealthyPartitionsPerService = 0,
                            MaxPercentUnhealthyReplicasPerPartition = 0,
                        },
                    },
                    UpgradeMode = new ServiceFabric.Tests.Mock.Models.RollingUpgradeMode("Monitored"),
                },
                MinimumNodes = 1,
                MaximumNodes = 3,
                RemoveApplicationCapacity = false,
                TypeName = "myAppType",
            };
            parameters.Tags.ReplaceWith(new Dictionary<string, string>()
            {
            });

            var clusterId = ServiceFabric.Tests.Mock.Cluster.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster");
            var collection = GetArmClient().GetCluster(clusterId).GetApplicationResources();
            await collection.CreateOrUpdateAsync(true, applicationName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate2()
        {
            // Example: Put an application with minimum parameters
            string applicationName = "myApp";
            ServiceFabric.Tests.Mock.ApplicationResourceData parameters = new ServiceFabric.Tests.Mock.ApplicationResourceData(location: "eastus")
            {
                TypeVersion = "1.0",
                RemoveApplicationCapacity = false,
                TypeName = "myAppType",
            };
            parameters.Tags.ReplaceWith(new Dictionary<string, string>()
            {
            });

            var clusterId = ServiceFabric.Tests.Mock.Cluster.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster");
            var collection = GetArmClient().GetCluster(clusterId).GetApplicationResources();
            await collection.CreateOrUpdateAsync(true, applicationName, parameters);
        }

        [RecordedTest]
        public async Task CreateOrUpdate3()
        {
            // Example: Put an application with recreate option
            string applicationName = "myApp";
            ServiceFabric.Tests.Mock.ApplicationResourceData parameters = new ServiceFabric.Tests.Mock.ApplicationResourceData(location: AzureLocation.WestUS)
            {
                TypeVersion = "1.0",
                UpgradePolicy = new ServiceFabric.Tests.Mock.Models.ApplicationUpgradePolicy()
                {
                    RecreateApplication = true,
                },
                TypeName = "myAppType",
            };
            parameters.Tags.ReplaceWith(new Dictionary<string, string>()
            {
            });

            var clusterId = ServiceFabric.Tests.Mock.Cluster.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster");
            var collection = GetArmClient().GetCluster(clusterId).GetApplicationResources();
            await collection.CreateOrUpdateAsync(true, applicationName, parameters);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Get an application
            string applicationName = "myApp";

            var clusterId = ServiceFabric.Tests.Mock.Cluster.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster");
            var collection = GetArmClient().GetCluster(clusterId).GetApplicationResources();
            await collection.GetAsync(applicationName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: Get a list of application resources

            var clusterId = ServiceFabric.Tests.Mock.Cluster.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resRg", "myCluster");
            var collection = GetArmClient().GetCluster(clusterId).GetApplicationResources();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
