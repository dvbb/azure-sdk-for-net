// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Migrate.Tests.Mock;
using Azure.ResourceManager.Migrate.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.Migrate.Tests.Mock.Tests.Mock
{
    /// <summary> Test for Project. </summary>
    public partial class ProjectMockTests : MockTestBase
    {
        public ProjectMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Projects_Get
            var projectId = Migrate.Tests.Mock.Project.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "abgoyal-westEurope", "abgoyalWEselfhostb72bproject");
            var project = GetArmClient().GetProject(projectId);

            await project.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Projects_Delete
            var projectId = Migrate.Tests.Mock.Project.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "abgoyal-westEurope", "abGoyalProject2");
            var project = GetArmClient().GetProject(projectId);

            await project.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: Projects_Update
            var projectId = Migrate.Tests.Mock.Project.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "abgoyal-westEurope", "abGoyalProject2");
            var project = GetArmClient().GetProject(projectId);
            Migrate.Tests.Mock.ProjectData project2 = new Migrate.Tests.Mock.ProjectData()
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

            await project.UpdateAsync(project2);
        }

        [RecordedTest]
        public async Task AssessmentOptions()
        {
            // Example: AssessmentOptions_Get
            var projectId = Migrate.Tests.Mock.Project.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "abgoyal-westEurope", "abgoyalWEselfhostb72bproject");
            var project = GetArmClient().GetProject(projectId);
            string assessmentOptionsName = "default";

            await project.AssessmentOptionsAsync(assessmentOptionsName);
        }

        [RecordedTest]
        public async Task AssessmentOptionsList()
        {
            // Example: AssessmentOptions_Get
            var projectId = Migrate.Tests.Mock.Project.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "abgoyal-westEurope", "abgoyalWEselfhostb72bproject");
            var project = GetArmClient().GetProject(projectId);

            await foreach (var _ in project.AssessmentOptionsListAsync())
            {
            }
        }

        [RecordedTest]
        public async Task GetAssessments()
        {
            // Example: Assessments_ListByProject
            var projectId = Migrate.Tests.Mock.Project.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "abgoyal-westEurope", "abgoyalWEselfhostb72bproject");
            var project = GetArmClient().GetProject(projectId);

            await foreach (var _ in project.GetAssessmentsAsync())
            {
            }
        }
    }
}
