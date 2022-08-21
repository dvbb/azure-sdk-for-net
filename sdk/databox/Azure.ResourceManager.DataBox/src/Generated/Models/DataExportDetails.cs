// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Details of the data to be used for exporting data from azure. </summary>
    public partial class DataExportDetails
    {
        /// <summary> Initializes a new instance of DataExportDetails. </summary>
        /// <param name="transferConfiguration"> Configuration for the data transfer. </param>
        /// <param name="accountDetails">
        /// Account details of the data to be transferred
        /// Please note <see cref="DataAccountDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedDiskDetails"/> and <see cref="StorageAccountDetails"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="transferConfiguration"/> or <paramref name="accountDetails"/> is null. </exception>
        public DataExportDetails(TransferConfiguration transferConfiguration, DataAccountDetails accountDetails)
        {
            if (transferConfiguration == null)
            {
                throw new ArgumentNullException(nameof(transferConfiguration));
            }
            if (accountDetails == null)
            {
                throw new ArgumentNullException(nameof(accountDetails));
            }

            TransferConfiguration = transferConfiguration;
            AccountDetails = accountDetails;
        }

        /// <summary> Initializes a new instance of DataExportDetails. </summary>
        /// <param name="transferConfiguration"> Configuration for the data transfer. </param>
        /// <param name="logCollectionLevel"> Level of the logs to be collected. </param>
        /// <param name="accountDetails">
        /// Account details of the data to be transferred
        /// Please note <see cref="DataAccountDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedDiskDetails"/> and <see cref="StorageAccountDetails"/>.
        /// </param>
        internal DataExportDetails(TransferConfiguration transferConfiguration, LogCollectionLevel? logCollectionLevel, DataAccountDetails accountDetails)
        {
            TransferConfiguration = transferConfiguration;
            LogCollectionLevel = logCollectionLevel;
            AccountDetails = accountDetails;
        }

        /// <summary> Configuration for the data transfer. </summary>
        public TransferConfiguration TransferConfiguration { get; set; }
        /// <summary> Level of the logs to be collected. </summary>
        public LogCollectionLevel? LogCollectionLevel { get; set; }
        /// <summary>
        /// Account details of the data to be transferred
        /// Please note <see cref="DataAccountDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedDiskDetails"/> and <see cref="StorageAccountDetails"/>.
        /// </summary>
        public DataAccountDetails AccountDetails { get; set; }
    }
}
