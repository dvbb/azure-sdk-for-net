// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure arc kubernetes helm application configurations. </summary>
    public partial class AzureArcKubernetesHelmApplication : AzureArcKubernetesNetworkFunctionApplication
    {
        /// <summary> Initializes a new instance of AzureArcKubernetesHelmApplication. </summary>
        public AzureArcKubernetesHelmApplication()
        {
            ArtifactType = AzureArcKubernetesArtifactType.HelmPackage;
        }

        /// <summary> Initializes a new instance of AzureArcKubernetesHelmApplication. </summary>
        /// <param name="name"> The name of the network function application. </param>
        /// <param name="dependsOnProfile"> Depends on profile definition. </param>
        /// <param name="artifactType"> The artifact type. </param>
        /// <param name="artifactProfile"> Azure arc kubernetes artifact profile. </param>
        /// <param name="deployParametersMappingRuleProfile"> Deploy mapping rule profile. </param>
        internal AzureArcKubernetesHelmApplication(string name, DependsOnProfile dependsOnProfile, AzureArcKubernetesArtifactType artifactType, AzureArcKubernetesArtifactProfile artifactProfile, AzureArcKubernetesDeployMappingRuleProfile deployParametersMappingRuleProfile) : base(name, dependsOnProfile, artifactType)
        {
            ArtifactProfile = artifactProfile;
            DeployParametersMappingRuleProfile = deployParametersMappingRuleProfile;
            ArtifactType = artifactType;
        }

        /// <summary> Azure arc kubernetes artifact profile. </summary>
        public AzureArcKubernetesArtifactProfile ArtifactProfile { get; set; }
        /// <summary> Deploy mapping rule profile. </summary>
        public AzureArcKubernetesDeployMappingRuleProfile DeployParametersMappingRuleProfile { get; set; }
    }
}
