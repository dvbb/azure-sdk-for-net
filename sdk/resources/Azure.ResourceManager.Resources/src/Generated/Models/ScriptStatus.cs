// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Generic object modeling results of script execution. </summary>
    public partial class ScriptStatus
    {
        /// <summary> Initializes a new instance of <see cref="ScriptStatus"/>. </summary>
        internal ScriptStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScriptStatus"/>. </summary>
        /// <param name="containerInstanceId"> ACI resource Id. </param>
        /// <param name="storageAccountId"> Storage account resource Id. </param>
        /// <param name="startOn"> Start time of the script execution. </param>
        /// <param name="endOn"> End time of the script execution. </param>
        /// <param name="expireOn"> Time the deployment script resource will expire. </param>
        /// <param name="error"> Error that is relayed from the script execution. </param>
        internal ScriptStatus(string containerInstanceId, string storageAccountId, DateTimeOffset? startOn, DateTimeOffset? endOn, DateTimeOffset? expireOn, ResponseError error)
        {
            ContainerInstanceId = containerInstanceId;
            StorageAccountId = storageAccountId;
            StartOn = startOn;
            EndOn = endOn;
            ExpireOn = expireOn;
            Error = error;
        }

        /// <summary> ACI resource Id. </summary>
        public string ContainerInstanceId { get; }
        /// <summary> Storage account resource Id. </summary>
        public string StorageAccountId { get; }
        /// <summary> Start time of the script execution. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> End time of the script execution. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Time the deployment script resource will expire. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> Error that is relayed from the script execution. </summary>
        public ResponseError Error { get; }
    }
}
