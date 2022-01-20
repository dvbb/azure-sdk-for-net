// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Datadog
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region DatadogMonitorResource
        /// <summary> Gets an object representing a DatadogMonitorResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DatadogMonitorResource" /> object. </returns>
        public static DatadogMonitorResource GetDatadogMonitorResource(this ArmClient armClient, ResourceIdentifier id)
        {
            DatadogMonitorResource.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DatadogMonitorResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region MonitoringTagRules
        /// <summary> Gets an object representing a MonitoringTagRules along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MonitoringTagRules" /> object. </returns>
        public static MonitoringTagRules GetMonitoringTagRules(this ArmClient armClient, ResourceIdentifier id)
        {
            MonitoringTagRules.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new MonitoringTagRules(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DatadogSingleSignOnResource
        /// <summary> Gets an object representing a DatadogSingleSignOnResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DatadogSingleSignOnResource" /> object. </returns>
        public static DatadogSingleSignOnResource GetDatadogSingleSignOnResource(this ArmClient armClient, ResourceIdentifier id)
        {
            DatadogSingleSignOnResource.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DatadogSingleSignOnResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
