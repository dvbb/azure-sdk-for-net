// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Unknown version of AzureOperatorNexusNetworkFunctionApplication. </summary>
    internal partial class UnknownAzureOperatorNexusNetworkFunctionApplication : AzureOperatorNexusNetworkFunctionApplication
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAzureOperatorNexusNetworkFunctionApplication"/>. </summary>
        /// <param name="name"> The name of the network function application. </param>
        /// <param name="dependsOnProfile"> Depends on profile definition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="artifactType"> The artifact type. </param>
        internal UnknownAzureOperatorNexusNetworkFunctionApplication(string name, DependsOnProfile dependsOnProfile, IDictionary<string, BinaryData> serializedAdditionalRawData, AzureOperatorNexusArtifactType artifactType) : base(name, dependsOnProfile, serializedAdditionalRawData, artifactType)
        {
            ArtifactType = artifactType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownAzureOperatorNexusNetworkFunctionApplication"/> for deserialization. </summary>
        internal UnknownAzureOperatorNexusNetworkFunctionApplication()
        {
        }
    }
}
