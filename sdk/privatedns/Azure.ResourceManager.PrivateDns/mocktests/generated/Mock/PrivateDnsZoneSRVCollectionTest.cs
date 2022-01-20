// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.PrivateDns.Tests.Mock;
using Azure.ResourceManager.PrivateDns.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.PrivateDns.Tests.Mock.Tests.Mock
{
    /// <summary> Test for RecordSet. </summary>
    public partial class PrivateDnsZoneSRVCollectionMockTests : MockTestBase
    {
        public PrivateDnsZoneSRVCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: PUT Private DNS Zone A Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.A;
            string relativeRecordSetName = "recordA";
            PrivateDns.Tests.Mock.RecordSetData parameters = new PrivateDns.Tests.Mock.RecordSetData()
            {
                Ttl = 3600,
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.CreateOrUpdateAsync(true, recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdate2()
        {
            // Example: PUT Private DNS Zone AAAA Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.Aaaa;
            string relativeRecordSetName = "recordAAAA";
            PrivateDns.Tests.Mock.RecordSetData parameters = new PrivateDns.Tests.Mock.RecordSetData()
            {
                Ttl = 3600,
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.CreateOrUpdateAsync(true, recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdate3()
        {
            // Example: PUT Private DNS Zone CNAME Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.Cname;
            string relativeRecordSetName = "recordCNAME";
            PrivateDns.Tests.Mock.RecordSetData parameters = new PrivateDns.Tests.Mock.RecordSetData()
            {
                Ttl = 3600,
                CnameRecord = new PrivateDns.Tests.Mock.Models.CnameRecord()
                {
                    Cname = "contoso.com",
                },
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.CreateOrUpdateAsync(true, recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdate4()
        {
            // Example: PUT Private DNS Zone MX Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.MX;
            string relativeRecordSetName = "recordMX";
            PrivateDns.Tests.Mock.RecordSetData parameters = new PrivateDns.Tests.Mock.RecordSetData()
            {
                Ttl = 3600,
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.CreateOrUpdateAsync(true, recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdate5()
        {
            // Example: PUT Private DNS Zone PTR Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.PTR;
            string relativeRecordSetName = "1";
            PrivateDns.Tests.Mock.RecordSetData parameters = new PrivateDns.Tests.Mock.RecordSetData()
            {
                Ttl = 3600,
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "0.0.127.in-addr.arpa");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.CreateOrUpdateAsync(true, recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdate6()
        {
            // Example: PUT Private DNS Zone SOA Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.SOA;
            string relativeRecordSetName = "@";
            PrivateDns.Tests.Mock.RecordSetData parameters = new PrivateDns.Tests.Mock.RecordSetData()
            {
                Ttl = 3600,
                SoaRecord = new PrivateDns.Tests.Mock.Models.SoaRecord()
                {
                    Host = "azureprivatedns.net",
                    Email = "azureprivatedns-hostmaster.microsoft.com",
                    SerialNumber = 1,
                    RefreshTime = 3600,
                    RetryTime = 300,
                    ExpireTime = 2419200,
                },
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.CreateOrUpdateAsync(true, recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdate7()
        {
            // Example: PUT Private DNS Zone SRV Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.SRV;
            string relativeRecordSetName = "recordSRV";
            PrivateDns.Tests.Mock.RecordSetData parameters = new PrivateDns.Tests.Mock.RecordSetData()
            {
                Ttl = 3600,
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.CreateOrUpdateAsync(true, recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task CreateOrUpdate8()
        {
            // Example: PUT Private DNS Zone TXT Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.TXT;
            string relativeRecordSetName = "recordTXT";
            PrivateDns.Tests.Mock.RecordSetData parameters = new PrivateDns.Tests.Mock.RecordSetData()
            {
                Ttl = 3600,
            };
            string ifMatch = null;
            string ifNoneMatch = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.CreateOrUpdateAsync(true, recordType, relativeRecordSetName, parameters, ifMatch, ifNoneMatch);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: GET Private DNS Zone A Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.A;
            string relativeRecordSetName = "recordA";

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task Get2()
        {
            // Example: GET Private DNS Zone AAAA Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.Aaaa;
            string relativeRecordSetName = "recordAAAA";

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task Get3()
        {
            // Example: GET Private DNS Zone CNAME Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.Cname;
            string relativeRecordSetName = "recordCNAME";

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task Get4()
        {
            // Example: GET Private DNS Zone MX Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.MX;
            string relativeRecordSetName = "recordMX";

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task Get5()
        {
            // Example: GET Private DNS Zone PTR Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.PTR;
            string relativeRecordSetName = "1";

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "0.0.127.in-addr.arpa");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task Get6()
        {
            // Example: GET Private DNS Zone SOA Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.SOA;
            string relativeRecordSetName = "@";

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task Get7()
        {
            // Example: GET Private DNS Zone SRV Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.SRV;
            string relativeRecordSetName = "recordSRV";

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task Get8()
        {
            // Example: GET Private DNS Zone TXT Record Set
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.TXT;
            string relativeRecordSetName = "recordTXT";

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await collection.GetAsync(recordType, relativeRecordSetName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: GET Private DNS Zone A Record Sets
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.A;
            int? top = null;
            string recordsetnamesuffix = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await foreach (var _ in collection.GetAllAsync(recordType, top, recordsetnamesuffix))
            {
            }
        }

        [RecordedTest]
        public async Task GetAll2()
        {
            // Example: GET Private DNS Zone AAAA Record Sets
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.Aaaa;
            int? top = null;
            string recordsetnamesuffix = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await foreach (var _ in collection.GetAllAsync(recordType, top, recordsetnamesuffix))
            {
            }
        }

        [RecordedTest]
        public async Task GetAll3()
        {
            // Example: GET Private DNS Zone CNAME Record Sets
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.Cname;
            int? top = null;
            string recordsetnamesuffix = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await foreach (var _ in collection.GetAllAsync(recordType, top, recordsetnamesuffix))
            {
            }
        }

        [RecordedTest]
        public async Task GetAll4()
        {
            // Example: GET Private DNS Zone MX Record Sets
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.MX;
            int? top = null;
            string recordsetnamesuffix = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await foreach (var _ in collection.GetAllAsync(recordType, top, recordsetnamesuffix))
            {
            }
        }

        [RecordedTest]
        public async Task GetAll5()
        {
            // Example: GET Private DNS Zone PTR Record Sets
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.PTR;
            int? top = null;
            string recordsetnamesuffix = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "0.0.127.in-addr.arpa");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await foreach (var _ in collection.GetAllAsync(recordType, top, recordsetnamesuffix))
            {
            }
        }

        [RecordedTest]
        public async Task GetAll6()
        {
            // Example: GET Private DNS Zone SOA Record Sets
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.SOA;
            int? top = null;
            string recordsetnamesuffix = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await foreach (var _ in collection.GetAllAsync(recordType, top, recordsetnamesuffix))
            {
            }
        }

        [RecordedTest]
        public async Task GetAll7()
        {
            // Example: GET Private DNS Zone SRV Record Sets
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.SRV;
            int? top = null;
            string recordsetnamesuffix = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await foreach (var _ in collection.GetAllAsync(recordType, top, recordsetnamesuffix))
            {
            }
        }

        [RecordedTest]
        public async Task GetAll8()
        {
            // Example: GET Private DNS Zone TXT Record Sets
            PrivateDns.Tests.Mock.Models.RecordType recordType = PrivateDns.Tests.Mock.Models.RecordType.TXT;
            int? top = null;
            string recordsetnamesuffix = null;

            var privateZoneId = PrivateDns.Tests.Mock.PrivateZone.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "resourceGroup1", "privatezone1.com");
            var collection = GetArmClient().GetPrivateZone(privateZoneId).GetPrivateDnsZoneSRVs();
            await foreach (var _ in collection.GetAllAsync(recordType, top, recordsetnamesuffix))
            {
            }
        }
    }
}
