// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the restorable database accounts and their properties. </summary>
    internal partial class RestorableDatabaseAccountsListResult
    {
        /// <summary> Initializes a new instance of RestorableDatabaseAccountsListResult. </summary>
        internal RestorableDatabaseAccountsListResult()
        {
            Value = new ChangeTrackingList<RestorableCosmosDBAccountData>();
        }

        /// <summary> Initializes a new instance of RestorableDatabaseAccountsListResult. </summary>
        /// <param name="value"> List of restorable database accounts and their properties. </param>
        internal RestorableDatabaseAccountsListResult(IReadOnlyList<RestorableCosmosDBAccountData> value)
        {
            Value = value;
        }

        /// <summary> List of restorable database accounts and their properties. </summary>
        public IReadOnlyList<RestorableCosmosDBAccountData> Value { get; }
    }
}
