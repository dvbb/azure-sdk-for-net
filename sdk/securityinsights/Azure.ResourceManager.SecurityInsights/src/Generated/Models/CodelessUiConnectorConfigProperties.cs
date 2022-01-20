// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Config to describe the instructions blade. </summary>
    public partial class CodelessUiConnectorConfigProperties
    {
        /// <summary> Initializes a new instance of CodelessUiConnectorConfigProperties. </summary>
        /// <param name="title"> Connector blade title. </param>
        /// <param name="publisher"> Connector publisher name. </param>
        /// <param name="descriptionMarkdown"> Connector description. </param>
        /// <param name="graphQueriesTableName"> Name of the table the connector will insert the data to. </param>
        /// <param name="graphQueries"> The graph query to show the current data status. </param>
        /// <param name="sampleQueries"> The sample queries for the connector. </param>
        /// <param name="dataTypes"> Data types to check for last data received. </param>
        /// <param name="connectivityCriteria"> Define the way the connector check connectivity. </param>
        /// <param name="availability"> Connector Availability Status. </param>
        /// <param name="permissions"> Permissions required for the connector. </param>
        /// <param name="instructionSteps"> Instruction steps to enable the connector. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="title"/>, <paramref name="publisher"/>, <paramref name="descriptionMarkdown"/>, <paramref name="graphQueriesTableName"/>, <paramref name="graphQueries"/>, <paramref name="sampleQueries"/>, <paramref name="dataTypes"/>, <paramref name="connectivityCriteria"/>, <paramref name="availability"/>, <paramref name="permissions"/>, or <paramref name="instructionSteps"/> is null. </exception>
        public CodelessUiConnectorConfigProperties(string title, string publisher, string descriptionMarkdown, string graphQueriesTableName, IEnumerable<CodelessUiConnectorConfigPropertiesGraphQueriesItem> graphQueries, IEnumerable<CodelessUiConnectorConfigPropertiesSampleQueriesItem> sampleQueries, IEnumerable<CodelessUiConnectorConfigPropertiesDataTypesItem> dataTypes, IEnumerable<CodelessUiConnectorConfigPropertiesConnectivityCriteriaItem> connectivityCriteria, Availability availability, Permissions permissions, IEnumerable<CodelessUiConnectorConfigPropertiesInstructionStepsItem> instructionSteps)
        {
            if (title == null)
            {
                throw new ArgumentNullException(nameof(title));
            }
            if (publisher == null)
            {
                throw new ArgumentNullException(nameof(publisher));
            }
            if (descriptionMarkdown == null)
            {
                throw new ArgumentNullException(nameof(descriptionMarkdown));
            }
            if (graphQueriesTableName == null)
            {
                throw new ArgumentNullException(nameof(graphQueriesTableName));
            }
            if (graphQueries == null)
            {
                throw new ArgumentNullException(nameof(graphQueries));
            }
            if (sampleQueries == null)
            {
                throw new ArgumentNullException(nameof(sampleQueries));
            }
            if (dataTypes == null)
            {
                throw new ArgumentNullException(nameof(dataTypes));
            }
            if (connectivityCriteria == null)
            {
                throw new ArgumentNullException(nameof(connectivityCriteria));
            }
            if (availability == null)
            {
                throw new ArgumentNullException(nameof(availability));
            }
            if (permissions == null)
            {
                throw new ArgumentNullException(nameof(permissions));
            }
            if (instructionSteps == null)
            {
                throw new ArgumentNullException(nameof(instructionSteps));
            }

            Title = title;
            Publisher = publisher;
            DescriptionMarkdown = descriptionMarkdown;
            GraphQueriesTableName = graphQueriesTableName;
            GraphQueries = graphQueries.ToList();
            SampleQueries = sampleQueries.ToList();
            DataTypes = dataTypes.ToList();
            ConnectivityCriteria = connectivityCriteria.ToList();
            Availability = availability;
            Permissions = permissions;
            InstructionSteps = instructionSteps.ToList();
        }

        /// <summary> Initializes a new instance of CodelessUiConnectorConfigProperties. </summary>
        /// <param name="title"> Connector blade title. </param>
        /// <param name="publisher"> Connector publisher name. </param>
        /// <param name="descriptionMarkdown"> Connector description. </param>
        /// <param name="customImage"> An optional custom image to be used when displaying the connector within Azure Sentinel&apos;s connector&apos;s gallery. </param>
        /// <param name="graphQueriesTableName"> Name of the table the connector will insert the data to. </param>
        /// <param name="graphQueries"> The graph query to show the current data status. </param>
        /// <param name="sampleQueries"> The sample queries for the connector. </param>
        /// <param name="dataTypes"> Data types to check for last data received. </param>
        /// <param name="connectivityCriteria"> Define the way the connector check connectivity. </param>
        /// <param name="availability"> Connector Availability Status. </param>
        /// <param name="permissions"> Permissions required for the connector. </param>
        /// <param name="instructionSteps"> Instruction steps to enable the connector. </param>
        internal CodelessUiConnectorConfigProperties(string title, string publisher, string descriptionMarkdown, string customImage, string graphQueriesTableName, IList<CodelessUiConnectorConfigPropertiesGraphQueriesItem> graphQueries, IList<CodelessUiConnectorConfigPropertiesSampleQueriesItem> sampleQueries, IList<CodelessUiConnectorConfigPropertiesDataTypesItem> dataTypes, IList<CodelessUiConnectorConfigPropertiesConnectivityCriteriaItem> connectivityCriteria, Availability availability, Permissions permissions, IList<CodelessUiConnectorConfigPropertiesInstructionStepsItem> instructionSteps)
        {
            Title = title;
            Publisher = publisher;
            DescriptionMarkdown = descriptionMarkdown;
            CustomImage = customImage;
            GraphQueriesTableName = graphQueriesTableName;
            GraphQueries = graphQueries;
            SampleQueries = sampleQueries;
            DataTypes = dataTypes;
            ConnectivityCriteria = connectivityCriteria;
            Availability = availability;
            Permissions = permissions;
            InstructionSteps = instructionSteps;
        }

        /// <summary> Connector blade title. </summary>
        public string Title { get; set; }
        /// <summary> Connector publisher name. </summary>
        public string Publisher { get; set; }
        /// <summary> Connector description. </summary>
        public string DescriptionMarkdown { get; set; }
        /// <summary> An optional custom image to be used when displaying the connector within Azure Sentinel&apos;s connector&apos;s gallery. </summary>
        public string CustomImage { get; set; }
        /// <summary> Name of the table the connector will insert the data to. </summary>
        public string GraphQueriesTableName { get; set; }
        /// <summary> The graph query to show the current data status. </summary>
        public IList<CodelessUiConnectorConfigPropertiesGraphQueriesItem> GraphQueries { get; }
        /// <summary> The sample queries for the connector. </summary>
        public IList<CodelessUiConnectorConfigPropertiesSampleQueriesItem> SampleQueries { get; }
        /// <summary> Data types to check for last data received. </summary>
        public IList<CodelessUiConnectorConfigPropertiesDataTypesItem> DataTypes { get; }
        /// <summary> Define the way the connector check connectivity. </summary>
        public IList<CodelessUiConnectorConfigPropertiesConnectivityCriteriaItem> ConnectivityCriteria { get; }
        /// <summary> Connector Availability Status. </summary>
        public Availability Availability { get; set; }
        /// <summary> Permissions required for the connector. </summary>
        public Permissions Permissions { get; set; }
        /// <summary> Instruction steps to enable the connector. </summary>
        public IList<CodelessUiConnectorConfigPropertiesInstructionStepsItem> InstructionSteps { get; }
    }
}
