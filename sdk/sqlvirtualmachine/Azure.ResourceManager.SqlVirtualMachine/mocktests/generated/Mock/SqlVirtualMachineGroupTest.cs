// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.SqlVirtualMachine.Tests.Mock;
using Azure.ResourceManager.SqlVirtualMachine.Tests.Mock.Models;
using Azure.ResourceManager.TestFramework;

namespace Azure.ResourceManager.SqlVirtualMachine.Tests.Mock.Tests.Mock
{
    /// <summary> Test for SqlVirtualMachineGroup. </summary>
    public partial class SqlVirtualMachineGroupMockTests : MockTestBase
    {
        public SqlVirtualMachineGroupMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Gets a SQL virtual machine group.
            var sqlVirtualMachineGroupId = SqlVirtualMachine.Tests.Mock.SqlVirtualMachineGroup.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg", "testvmgroup");
            var sqlVirtualMachineGroup = GetArmClient().GetSqlVirtualMachineGroup(sqlVirtualMachineGroupId);

            await sqlVirtualMachineGroup.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Deletes a SQL virtual machine group.
            var sqlVirtualMachineGroupId = SqlVirtualMachine.Tests.Mock.SqlVirtualMachineGroup.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg", "testvmgroup");
            var sqlVirtualMachineGroup = GetArmClient().GetSqlVirtualMachineGroup(sqlVirtualMachineGroupId);

            await sqlVirtualMachineGroup.DeleteAsync(true);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: Updates a SQL virtual machine group tags.
            var sqlVirtualMachineGroupId = SqlVirtualMachine.Tests.Mock.SqlVirtualMachineGroup.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg", "testvmgroup");
            var sqlVirtualMachineGroup = GetArmClient().GetSqlVirtualMachineGroup(sqlVirtualMachineGroupId);
            SqlVirtualMachine.Tests.Mock.Models.SqlVirtualMachineGroupUpdate parameters = new SqlVirtualMachine.Tests.Mock.Models.SqlVirtualMachineGroupUpdate();

            await sqlVirtualMachineGroup.UpdateAsync(true, parameters);
        }

        [RecordedTest]
        public async Task GetSqlVirtualMachinesBySqlVmGroup()
        {
            // Example: Gets the list of sql virtual machines in a SQL virtual machine group.
            var sqlVirtualMachineGroupId = SqlVirtualMachine.Tests.Mock.SqlVirtualMachineGroup.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "testrg", "testvm");
            var sqlVirtualMachineGroup = GetArmClient().GetSqlVirtualMachineGroup(sqlVirtualMachineGroupId);

            await foreach (var _ in sqlVirtualMachineGroup.GetSqlVirtualMachinesBySqlVmGroupAsync())
            {
            }
        }
    }
}
