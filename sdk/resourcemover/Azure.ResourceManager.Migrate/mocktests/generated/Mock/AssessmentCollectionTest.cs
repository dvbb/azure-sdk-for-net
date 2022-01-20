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
    /// <summary> Test for Assessment. </summary>
    public partial class AssessmentCollectionMockTests : MockTestBase
    {
        public AssessmentCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Assessments_Create
            string assessmentName = "assessment_5_14_2019_16_48_47";
            Migrate.Tests.Mock.AssessmentData assessment = new Migrate.Tests.Mock.AssessmentData(properties: new Migrate.Tests.Mock.Models.AssessmentProperties(azureLocation: new Migrate.Tests.Mock.Models.AzureLocation("NorthEurope"), azureOfferCode: new Migrate.Tests.Mock.Models.AzureOfferCode("MSAZR0003P"), azurePricingTier: new Migrate.Tests.Mock.Models.AzurePricingTier("Standard"), azureStorageRedundancy: new Migrate.Tests.Mock.Models.AzureStorageRedundancy("LocallyRedundant"), scalingFactor: 1, percentile: new Migrate.Tests.Mock.Models.Percentile("Percentile95"), timeRange: new Migrate.Tests.Mock.Models.TimeRange("Day"), stage: new Migrate.Tests.Mock.Models.AssessmentStage("InProgress"), currency: new Migrate.Tests.Mock.Models.Currency("USD"), azureHybridUseBenefit: new Migrate.Tests.Mock.Models.AzureHybridUseBenefit("Yes"), discountPercentage: 100, sizingCriterion: new Migrate.Tests.Mock.Models.AssessmentSizingCriterion("PerformanceBased"), reservedInstance: new Migrate.Tests.Mock.Models.ReservedInstance("RI3Year"), azureVmFamilies: new List<Migrate.Tests.Mock.Models.AzureVmFamily>()
{
new Migrate.Tests.Mock.Models.AzureVmFamily("Dv2_series"),new Migrate.Tests.Mock.Models.AzureVmFamily("F_series"),new Migrate.Tests.Mock.Models.AzureVmFamily("Dv3_series"),new Migrate.Tests.Mock.Models.AzureVmFamily("DS_series"),new Migrate.Tests.Mock.Models.AzureVmFamily("DSv2_series"),new Migrate.Tests.Mock.Models.AzureVmFamily("Fs_series"),new Migrate.Tests.Mock.Models.AzureVmFamily("Dsv3_series"),new Migrate.Tests.Mock.Models.AzureVmFamily("Ev3_series"),new Migrate.Tests.Mock.Models.AzureVmFamily("Esv3_series"),new Migrate.Tests.Mock.Models.AzureVmFamily("D_series"),new Migrate.Tests.Mock.Models.AzureVmFamily("M_series"),new Migrate.Tests.Mock.Models.AzureVmFamily("Fsv2_series"),new Migrate.Tests.Mock.Models.AzureVmFamily("H_series"),}, azureDiskType: new Migrate.Tests.Mock.Models.AzureDiskType("StandardOrPremium"), vmUptime: new Migrate.Tests.Mock.Models.VmUptime()
{
    DaysPerMonth = 31,
    HoursPerDay = 24,
}))
            {
                ETag = "\"1e000c2c-0000-0d00-0000-5cdaa4190000\"",
            };

            var groupId = Migrate.Tests.Mock.Group.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "abgoyal-westEurope", "abgoyalWEselfhostb72bproject", "Group2");
            var collection = GetArmClient().GetGroup(groupId).GetAssessments();
            await collection.CreateOrUpdateAsync(true, assessmentName, assessment);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Assessments_Get
            string assessmentName = "assessment_5_9_2019_16_22_14";

            var groupId = Migrate.Tests.Mock.Group.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "abgoyal-westEurope", "abgoyalWEselfhostb72bproject", "Test1");
            var collection = GetArmClient().GetGroup(groupId).GetAssessments();
            await collection.GetAsync(assessmentName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: Assessments_ListByGroup

            var groupId = Migrate.Tests.Mock.Group.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "abgoyal-westEurope", "abgoyalWEselfhostb72bproject", "Test1");
            var collection = GetArmClient().GetGroup(groupId).GetAssessments();
            await foreach (var _ in collection.GetAllAsync())
            {
            }
        }
    }
}
