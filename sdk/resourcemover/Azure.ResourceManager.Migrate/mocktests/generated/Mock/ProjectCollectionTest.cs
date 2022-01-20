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
using Azure.ResourceManager.Migrate.Tests.Mock;
using Azure.ResourceManager.Migrate.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Migrate.Tests.Mock.Tests.Mock
{
    /// <summary> Test for Project. </summary>
    public partial class ProjectCollectionMockTests : MockTestBase
    {
        public ProjectCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Projects_Create
            string projectName = "abGoyalProject2";
            Migrate.Tests.Mock.ProjectData project = new Migrate.Tests.Mock.ProjectData()
            {
                ETag = "",
                Location = "West Europe",
                Tags = new Dictionary<string, object>()
                {
                }
            ,
                Properties = new Migrate.Tests.Mock.Models.ProjectProperties()
                {
                    AssessmentSolutionId = "/subscriptions/6393a73f-8d55-47ef-b6dd-179b3e0c7910/resourcegroups/abgoyal-westeurope/providers/microsoft.migrate/migrateprojects/abgoyalweselfhost/Solutions/Servers-Assessment-ServerAssessment",
                    ProjectStatus = new Migrate.Tests.Mock.Models.ProjectStatus("Active"),
                    CustomerWorkspaceId = null,
                    CustomerWorkspaceLocation = null,
                },
            };

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/abgoyal-westEurope")).GetProjects();
            await collection.CreateOrUpdateAsync(true, projectName, project);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Projects_Get
            string projectName = "abgoyalWEselfhostb72bproject";

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/abgoyal-westEurope")).GetProjects();
            await collection.GetAsync(projectName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: Projects_List

            var collection = GetArmClient().GetResourceGroup(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/abgoyal-westEurope")).GetProjects();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
