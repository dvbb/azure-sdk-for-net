// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure ML Batch Execution activity. </summary>
    public partial class AzureMLBatchExecutionActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of AzureMLBatchExecutionActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public AzureMLBatchExecutionActivity(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            GlobalParameters = new ChangeTrackingDictionary<string, object>();
            WebServiceOutputs = new ChangeTrackingDictionary<string, AzureMLWebServiceFile>();
            WebServiceInputs = new ChangeTrackingDictionary<string, AzureMLWebServiceFile>();
            Type = "AzureMLBatchExecution";
        }

        /// <summary> Initializes a new instance of AzureMLBatchExecutionActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="globalParameters"> Key,Value pairs to be passed to the Azure ML Batch Execution Service endpoint. Keys must match the names of web service parameters defined in the published Azure ML web service. Values will be passed in the GlobalParameters property of the Azure ML batch execution request. </param>
        /// <param name="webServiceOutputs"> Key,Value pairs, mapping the names of Azure ML endpoint&apos;s Web Service Outputs to AzureMLWebServiceFile objects specifying the output Blob locations. This information will be passed in the WebServiceOutputs property of the Azure ML batch execution request. </param>
        /// <param name="webServiceInputs"> Key,Value pairs, mapping the names of Azure ML endpoint&apos;s Web Service Inputs to AzureMLWebServiceFile objects specifying the input Blob locations.. This information will be passed in the WebServiceInputs property of the Azure ML batch execution request. </param>
        internal AzureMLBatchExecutionActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, IDictionary<string, object> globalParameters, IDictionary<string, AzureMLWebServiceFile> webServiceOutputs, IDictionary<string, AzureMLWebServiceFile> webServiceInputs) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            GlobalParameters = globalParameters;
            WebServiceOutputs = webServiceOutputs;
            WebServiceInputs = webServiceInputs;
            Type = type ?? "AzureMLBatchExecution";
        }

        /// <summary> Key,Value pairs to be passed to the Azure ML Batch Execution Service endpoint. Keys must match the names of web service parameters defined in the published Azure ML web service. Values will be passed in the GlobalParameters property of the Azure ML batch execution request. </summary>
        public IDictionary<string, object> GlobalParameters { get; }
        /// <summary> Key,Value pairs, mapping the names of Azure ML endpoint&apos;s Web Service Outputs to AzureMLWebServiceFile objects specifying the output Blob locations. This information will be passed in the WebServiceOutputs property of the Azure ML batch execution request. </summary>
        public IDictionary<string, AzureMLWebServiceFile> WebServiceOutputs { get; }
        /// <summary> Key,Value pairs, mapping the names of Azure ML endpoint&apos;s Web Service Inputs to AzureMLWebServiceFile objects specifying the input Blob locations.. This information will be passed in the WebServiceInputs property of the Azure ML batch execution request. </summary>
        public IDictionary<string, AzureMLWebServiceFile> WebServiceInputs { get; }
    }
}
