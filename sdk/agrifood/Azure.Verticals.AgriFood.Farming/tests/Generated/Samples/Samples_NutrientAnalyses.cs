// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.Verticals.AgriFood.Farming;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    public partial class Samples_NutrientAnalyses
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNutrientAnalysis_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetNutrientAnalysis("<partyId>", "<nutrientAnalysisId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNutrientAnalysis_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetNutrientAnalysisAsync("<partyId>", "<nutrientAnalysisId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNutrientAnalysis_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            Response response = client.GetNutrientAnalysis("<partyId>", "<nutrientAnalysisId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("parentId").ToString());
            Console.WriteLine(result.GetProperty("parentType").ToString());
            Console.WriteLine(result.GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("referenceValueLow").ToString());
            Console.WriteLine(result.GetProperty("referenceValueHigh").ToString());
            Console.WriteLine(result.GetProperty("classification").ToString());
            Console.WriteLine(result.GetProperty("recommendation").ToString());
            Console.WriteLine(result.GetProperty("products")[0].GetProperty("rate").ToString());
            Console.WriteLine(result.GetProperty("products")[0].GetProperty("instruction").ToString());
            Console.WriteLine(result.GetProperty("products")[0].GetProperty("product").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNutrientAnalysis_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.GetNutrientAnalysisAsync("<partyId>", "<nutrientAnalysisId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("parentId").ToString());
            Console.WriteLine(result.GetProperty("parentType").ToString());
            Console.WriteLine(result.GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("referenceValueLow").ToString());
            Console.WriteLine(result.GetProperty("referenceValueHigh").ToString());
            Console.WriteLine(result.GetProperty("classification").ToString());
            Console.WriteLine(result.GetProperty("recommendation").ToString());
            Console.WriteLine(result.GetProperty("products")[0].GetProperty("rate").ToString());
            Console.WriteLine(result.GetProperty("products")[0].GetProperty("instruction").ToString());
            Console.WriteLine(result.GetProperty("products")[0].GetProperty("product").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.CreateOrUpdate("<partyId>", "<nutrientAnalysisId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.CreateOrUpdateAsync("<partyId>", "<nutrientAnalysisId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                parentId = "<parentId>",
                parentType = "PlantTissueAnalysis",
                unit = "<unit>",
                value = 123.45,
                referenceValueLow = 123.45,
                referenceValueHigh = 123.45,
                classification = "<classification>",
                recommendation = "<recommendation>",
                products = new object[]
            {
new
{
rate = "<rate>",
instruction = "<instruction>",
product = "<product>",
}
            },
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = client.CreateOrUpdate("<partyId>", "<nutrientAnalysisId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("parentId").ToString());
            Console.WriteLine(result.GetProperty("parentType").ToString());
            Console.WriteLine(result.GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("referenceValueLow").ToString());
            Console.WriteLine(result.GetProperty("referenceValueHigh").ToString());
            Console.WriteLine(result.GetProperty("classification").ToString());
            Console.WriteLine(result.GetProperty("recommendation").ToString());
            Console.WriteLine(result.GetProperty("products")[0].GetProperty("rate").ToString());
            Console.WriteLine(result.GetProperty("products")[0].GetProperty("instruction").ToString());
            Console.WriteLine(result.GetProperty("products")[0].GetProperty("product").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            using RequestContent content = RequestContent.Create(new
            {
                parentId = "<parentId>",
                parentType = "PlantTissueAnalysis",
                unit = "<unit>",
                value = 123.45,
                referenceValueLow = 123.45,
                referenceValueHigh = 123.45,
                classification = "<classification>",
                recommendation = "<recommendation>",
                products = new object[]
            {
new
{
rate = "<rate>",
instruction = "<instruction>",
product = "<product>",
}
            },
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = await client.CreateOrUpdateAsync("<partyId>", "<nutrientAnalysisId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("parentId").ToString());
            Console.WriteLine(result.GetProperty("parentType").ToString());
            Console.WriteLine(result.GetProperty("unit").ToString());
            Console.WriteLine(result.GetProperty("value").ToString());
            Console.WriteLine(result.GetProperty("referenceValueLow").ToString());
            Console.WriteLine(result.GetProperty("referenceValueHigh").ToString());
            Console.WriteLine(result.GetProperty("classification").ToString());
            Console.WriteLine(result.GetProperty("recommendation").ToString());
            Console.WriteLine(result.GetProperty("products")[0].GetProperty("rate").ToString());
            Console.WriteLine(result.GetProperty("products")[0].GetProperty("instruction").ToString());
            Console.WriteLine(result.GetProperty("products")[0].GetProperty("product").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<partyId>", "<nutrientAnalysisId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<partyId>", "<nutrientAnalysisId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            Response response = client.Delete("<partyId>", "<nutrientAnalysisId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            Response response = await client.DeleteAsync("<partyId>", "<nutrientAnalysisId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNutrientAnalyses_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetNutrientAnalyses(null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNutrientAnalyses_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetNutrientAnalysesAsync(null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNutrientAnalyses_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetNutrientAnalyses("<parentType>", new string[] { "<parentIds>" }, new string[] { "<classifications>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("partyId").ToString());
                Console.WriteLine(result.GetProperty("parentId").ToString());
                Console.WriteLine(result.GetProperty("parentType").ToString());
                Console.WriteLine(result.GetProperty("unit").ToString());
                Console.WriteLine(result.GetProperty("value").ToString());
                Console.WriteLine(result.GetProperty("referenceValueLow").ToString());
                Console.WriteLine(result.GetProperty("referenceValueHigh").ToString());
                Console.WriteLine(result.GetProperty("classification").ToString());
                Console.WriteLine(result.GetProperty("recommendation").ToString());
                Console.WriteLine(result.GetProperty("products")[0].GetProperty("rate").ToString());
                Console.WriteLine(result.GetProperty("products")[0].GetProperty("instruction").ToString());
                Console.WriteLine(result.GetProperty("products")[0].GetProperty("product").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("source").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNutrientAnalyses_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetNutrientAnalysesAsync("<parentType>", new string[] { "<parentIds>" }, new string[] { "<classifications>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("partyId").ToString());
                Console.WriteLine(result.GetProperty("parentId").ToString());
                Console.WriteLine(result.GetProperty("parentType").ToString());
                Console.WriteLine(result.GetProperty("unit").ToString());
                Console.WriteLine(result.GetProperty("value").ToString());
                Console.WriteLine(result.GetProperty("referenceValueLow").ToString());
                Console.WriteLine(result.GetProperty("referenceValueHigh").ToString());
                Console.WriteLine(result.GetProperty("classification").ToString());
                Console.WriteLine(result.GetProperty("recommendation").ToString());
                Console.WriteLine(result.GetProperty("products")[0].GetProperty("rate").ToString());
                Console.WriteLine(result.GetProperty("products")[0].GetProperty("instruction").ToString());
                Console.WriteLine(result.GetProperty("products")[0].GetProperty("product").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("source").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNutrientAnalysesByPartyId_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetNutrientAnalysesByPartyId("<partyId>", null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNutrientAnalysesByPartyId_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetNutrientAnalysesByPartyIdAsync("<partyId>", null, null, null, null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetNutrientAnalysesByPartyId_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            foreach (BinaryData item in client.GetNutrientAnalysesByPartyId("<partyId>", "<parentType>", new string[] { "<parentIds>" }, new string[] { "<classifications>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("partyId").ToString());
                Console.WriteLine(result.GetProperty("parentId").ToString());
                Console.WriteLine(result.GetProperty("parentType").ToString());
                Console.WriteLine(result.GetProperty("unit").ToString());
                Console.WriteLine(result.GetProperty("value").ToString());
                Console.WriteLine(result.GetProperty("referenceValueLow").ToString());
                Console.WriteLine(result.GetProperty("referenceValueHigh").ToString());
                Console.WriteLine(result.GetProperty("classification").ToString());
                Console.WriteLine(result.GetProperty("recommendation").ToString());
                Console.WriteLine(result.GetProperty("products")[0].GetProperty("rate").ToString());
                Console.WriteLine(result.GetProperty("products")[0].GetProperty("instruction").ToString());
                Console.WriteLine(result.GetProperty("products")[0].GetProperty("product").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("source").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetNutrientAnalysesByPartyId_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            NutrientAnalyses client = new FarmBeatsClient(endpoint, credential).GetNutrientAnalysesClient(apiVersion: "2022-11-01-preview");

            await foreach (BinaryData item in client.GetNutrientAnalysesByPartyIdAsync("<partyId>", "<parentType>", new string[] { "<parentIds>" }, new string[] { "<classifications>" }, new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("partyId").ToString());
                Console.WriteLine(result.GetProperty("parentId").ToString());
                Console.WriteLine(result.GetProperty("parentType").ToString());
                Console.WriteLine(result.GetProperty("unit").ToString());
                Console.WriteLine(result.GetProperty("value").ToString());
                Console.WriteLine(result.GetProperty("referenceValueLow").ToString());
                Console.WriteLine(result.GetProperty("referenceValueHigh").ToString());
                Console.WriteLine(result.GetProperty("classification").ToString());
                Console.WriteLine(result.GetProperty("recommendation").ToString());
                Console.WriteLine(result.GetProperty("products")[0].GetProperty("rate").ToString());
                Console.WriteLine(result.GetProperty("products")[0].GetProperty("instruction").ToString());
                Console.WriteLine(result.GetProperty("products")[0].GetProperty("product").ToString());
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("source").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }
    }
}
