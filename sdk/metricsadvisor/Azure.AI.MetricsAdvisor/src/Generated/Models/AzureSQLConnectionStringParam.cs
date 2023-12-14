// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureSQLConnectionStringParam. </summary>
    internal partial class AzureSQLConnectionStringParam
    {
        /// <summary> Initializes a new instance of <see cref="AzureSQLConnectionStringParam"/>. </summary>
        public AzureSQLConnectionStringParam()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureSQLConnectionStringParam"/>. </summary>
        /// <param name="connectionString"> The connection string to access the Azure SQL. </param>
        internal AzureSQLConnectionStringParam(string connectionString)
        {
            ConnectionString = connectionString;
        }

        /// <summary> The connection string to access the Azure SQL. </summary>
        public string ConnectionString { get; set; }
    }
}
