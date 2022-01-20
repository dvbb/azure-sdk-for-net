// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridDataManager.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridDataManager
{
    /// <summary> A class representing the JobDefinition data model. </summary>
    public partial class JobDefinitionData : ResourceManager.Models.Resource
    {
        /// <summary> Initializes a new instance of JobDefinitionData. </summary>
        /// <param name="dataSourceId"> Data Source Id associated to the job definition. </param>
        /// <param name="dataSinkId"> Data Sink Id associated to the job definition. </param>
        /// <param name="state"> State of the job definition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceId"/> or <paramref name="dataSinkId"/> is null. </exception>
        public JobDefinitionData(string dataSourceId, string dataSinkId, State state)
        {
            if (dataSourceId == null)
            {
                throw new ArgumentNullException(nameof(dataSourceId));
            }
            if (dataSinkId == null)
            {
                throw new ArgumentNullException(nameof(dataSinkId));
            }

            DataSourceId = dataSourceId;
            DataSinkId = dataSinkId;
            Schedules = new ChangeTrackingList<Schedule>();
            State = state;
            CustomerSecrets = new ChangeTrackingList<CustomerSecret>();
        }

        /// <summary> Initializes a new instance of JobDefinitionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="dataSourceId"> Data Source Id associated to the job definition. </param>
        /// <param name="dataSinkId"> Data Sink Id associated to the job definition. </param>
        /// <param name="schedules"> Schedule for running the job definition. </param>
        /// <param name="state"> State of the job definition. </param>
        /// <param name="lastModifiedTime"> Last modified time of the job definition. </param>
        /// <param name="runLocation"> This is the preferred geo location for the job to run. </param>
        /// <param name="userConfirmation"> Enum to detect if user confirmation is required. If not passed will default to NotRequired. </param>
        /// <param name="dataServiceInput"> A generic json used differently by each data service type. </param>
        /// <param name="customerSecrets"> List of customer secrets containing a key identifier and key value. The key identifier is a way for the specific data source to understand the key. Value contains customer secret encrypted by the encryptionKeys. </param>
        internal JobDefinitionData(ResourceIdentifier id, string name, ResourceType type, string dataSourceId, string dataSinkId, IList<Schedule> schedules, State state, DateTimeOffset? lastModifiedTime, RunLocation? runLocation, UserConfirmation? userConfirmation, object dataServiceInput, IList<CustomerSecret> customerSecrets) : base(id, name, type)
        {
            DataSourceId = dataSourceId;
            DataSinkId = dataSinkId;
            Schedules = schedules;
            State = state;
            LastModifiedTime = lastModifiedTime;
            RunLocation = runLocation;
            UserConfirmation = userConfirmation;
            DataServiceInput = dataServiceInput;
            CustomerSecrets = customerSecrets;
        }

        /// <summary> Data Source Id associated to the job definition. </summary>
        public string DataSourceId { get; set; }
        /// <summary> Data Sink Id associated to the job definition. </summary>
        public string DataSinkId { get; set; }
        /// <summary> Schedule for running the job definition. </summary>
        public IList<Schedule> Schedules { get; }
        /// <summary> State of the job definition. </summary>
        public State State { get; set; }
        /// <summary> Last modified time of the job definition. </summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary> This is the preferred geo location for the job to run. </summary>
        public RunLocation? RunLocation { get; set; }
        /// <summary> Enum to detect if user confirmation is required. If not passed will default to NotRequired. </summary>
        public UserConfirmation? UserConfirmation { get; set; }
        /// <summary> A generic json used differently by each data service type. </summary>
        public object DataServiceInput { get; set; }
        /// <summary> List of customer secrets containing a key identifier and key value. The key identifier is a way for the specific data source to understand the key. Value contains customer secret encrypted by the encryptionKeys. </summary>
        public IList<CustomerSecret> CustomerSecrets { get; }
    }
}
