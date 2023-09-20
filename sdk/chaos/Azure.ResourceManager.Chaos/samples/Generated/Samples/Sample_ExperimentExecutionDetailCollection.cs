// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Chaos;

namespace Azure.ResourceManager.Chaos.Samples
{
    public partial class Sample_ExperimentExecutionDetailCollection
    {
        // List experiment executions details
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListExperimentExecutionsDetails()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/preview/2023-04-15-preview/examples/ListExperimentExecutionsDetails.json
            // this example is just showing the usage of "Experiments_ListExecutionDetails" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExperimentResource created on azure
            // for more information of creating ExperimentResource, please refer to the document of ExperimentResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string experimentName = "exampleExperiment";
            ResourceIdentifier experimentResourceId = ExperimentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, experimentName);
            ExperimentResource experiment = client.GetExperimentResource(experimentResourceId);

            // get the collection of this ExperimentExecutionDetailResource
            ExperimentExecutionDetailCollection collection = experiment.GetExperimentExecutionDetails();

            // invoke the operation and iterate over the result
            await foreach (ExperimentExecutionDetailResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExperimentExecutionDetailData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get experiment execution details
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetExperimentExecutionDetails()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/preview/2023-04-15-preview/examples/GetAExperimentExecutionDetails.json
            // this example is just showing the usage of "Experiments_GetExecutionDetails" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExperimentResource created on azure
            // for more information of creating ExperimentResource, please refer to the document of ExperimentResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string experimentName = "exampleExperiment";
            ResourceIdentifier experimentResourceId = ExperimentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, experimentName);
            ExperimentResource experiment = client.GetExperimentResource(experimentResourceId);

            // get the collection of this ExperimentExecutionDetailResource
            ExperimentExecutionDetailCollection collection = experiment.GetExperimentExecutionDetails();

            // invoke the operation
            string executionDetailsId = "f24500ad-744e-4a26-864b-b76199eac333";
            ExperimentExecutionDetailResource result = await collection.GetAsync(executionDetailsId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExperimentExecutionDetailData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get experiment execution details
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetExperimentExecutionDetails()
        {
            // Generated from example definition: specification/chaos/resource-manager/Microsoft.Chaos/preview/2023-04-15-preview/examples/GetAExperimentExecutionDetails.json
            // this example is just showing the usage of "Experiments_GetExecutionDetails" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExperimentResource created on azure
            // for more information of creating ExperimentResource, please refer to the document of ExperimentResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string experimentName = "exampleExperiment";
            ResourceIdentifier experimentResourceId = ExperimentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, experimentName);
            ExperimentResource experiment = client.GetExperimentResource(experimentResourceId);

            // get the collection of this ExperimentExecutionDetailResource
            ExperimentExecutionDetailCollection collection = experiment.GetExperimentExecutionDetails();

            // invoke the operation
            string executionDetailsId = "f24500ad-744e-4a26-864b-b76199eac333";
            bool result = await collection.ExistsAsync(executionDetailsId);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
