// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary>
    /// Base properties for any task step.
    /// Please note <see cref="ContainerRegistryTaskStepProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ContainerRegistryDockerBuildStep"/>, <see cref="ContainerRegistryEncodedTaskStep"/> and <see cref="ContainerRegistryFileTaskStep"/>.
    /// </summary>
    public abstract partial class ContainerRegistryTaskStepProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTaskStepProperties"/>. </summary>
        protected ContainerRegistryTaskStepProperties()
        {
            BaseImageDependencies = new ChangeTrackingList<ContainerRegistryBaseImageDependency>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTaskStepProperties"/>. </summary>
        /// <param name="containerRegistryTaskStepType"> The type of the step. </param>
        /// <param name="baseImageDependencies"> List of base image dependencies for a step. </param>
        /// <param name="contextPath"> The URL(absolute or relative) of the source context for the task step. </param>
        /// <param name="contextAccessToken"> The token (git PAT or SAS token of storage account blob) associated with the context for a step. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryTaskStepProperties(ContainerRegistryTaskStepType containerRegistryTaskStepType, IReadOnlyList<ContainerRegistryBaseImageDependency> baseImageDependencies, string contextPath, string contextAccessToken, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContainerRegistryTaskStepType = containerRegistryTaskStepType;
            BaseImageDependencies = baseImageDependencies;
            ContextPath = contextPath;
            ContextAccessToken = contextAccessToken;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of the step. </summary>
        internal ContainerRegistryTaskStepType ContainerRegistryTaskStepType { get; set; }
        /// <summary> List of base image dependencies for a step. </summary>
        public IReadOnlyList<ContainerRegistryBaseImageDependency> BaseImageDependencies { get; }
        /// <summary> The URL(absolute or relative) of the source context for the task step. </summary>
        public string ContextPath { get; set; }
        /// <summary> The token (git PAT or SAS token of storage account blob) associated with the context for a step. </summary>
        public string ContextAccessToken { get; set; }
    }
}
