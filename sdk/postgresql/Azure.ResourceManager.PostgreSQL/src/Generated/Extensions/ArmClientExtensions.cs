// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.PostgreSQL
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region Server
        /// <summary> Gets an object representing a Server along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Server" /> object. </returns>
        public static Server GetServer(this ArmClient armClient, ResourceIdentifier id)
        {
            Server.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Server(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region FirewallRule
        /// <summary> Gets an object representing a FirewallRule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FirewallRule" /> object. </returns>
        public static FirewallRule GetFirewallRule(this ArmClient armClient, ResourceIdentifier id)
        {
            FirewallRule.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new FirewallRule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Configuration
        /// <summary> Gets an object representing a Configuration along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Configuration" /> object. </returns>
        public static Configuration GetConfiguration(this ArmClient armClient, ResourceIdentifier id)
        {
            Configuration.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Configuration(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Database
        /// <summary> Gets an object representing a Database along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Database" /> object. </returns>
        public static Database GetDatabase(this ArmClient armClient, ResourceIdentifier id)
        {
            Database.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Database(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
