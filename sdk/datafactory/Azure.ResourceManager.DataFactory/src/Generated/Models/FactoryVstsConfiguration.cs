// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Factory&apos;s VSTS repo information. </summary>
    public partial class FactoryVstsConfiguration : FactoryRepoConfiguration
    {
        /// <summary> Initializes a new instance of FactoryVstsConfiguration. </summary>
        /// <param name="accountName"> Account name. </param>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="collaborationBranch"> Collaboration branch. </param>
        /// <param name="rootFolder"> Root folder. </param>
        /// <param name="projectName"> VSTS project name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/>, <paramref name="repositoryName"/>, <paramref name="collaborationBranch"/>, <paramref name="rootFolder"/>, or <paramref name="projectName"/> is null. </exception>
        public FactoryVstsConfiguration(string accountName, string repositoryName, string collaborationBranch, string rootFolder, string projectName) : base(accountName, repositoryName, collaborationBranch, rootFolder)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (repositoryName == null)
            {
                throw new ArgumentNullException(nameof(repositoryName));
            }
            if (collaborationBranch == null)
            {
                throw new ArgumentNullException(nameof(collaborationBranch));
            }
            if (rootFolder == null)
            {
                throw new ArgumentNullException(nameof(rootFolder));
            }
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }

            ProjectName = projectName;
            Type = "FactoryVSTSConfiguration";
        }

        /// <summary> Initializes a new instance of FactoryVstsConfiguration. </summary>
        /// <param name="type"> Type of repo configuration. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="collaborationBranch"> Collaboration branch. </param>
        /// <param name="rootFolder"> Root folder. </param>
        /// <param name="lastCommitId"> Last commit id. </param>
        /// <param name="projectName"> VSTS project name. </param>
        /// <param name="tenantId"> VSTS tenant id. </param>
        internal FactoryVstsConfiguration(string type, string accountName, string repositoryName, string collaborationBranch, string rootFolder, string lastCommitId, string projectName, string tenantId) : base(type, accountName, repositoryName, collaborationBranch, rootFolder, lastCommitId)
        {
            ProjectName = projectName;
            TenantId = tenantId;
            Type = type ?? "FactoryVSTSConfiguration";
        }

        /// <summary> VSTS project name. </summary>
        public string ProjectName { get; set; }
        /// <summary> VSTS tenant id. </summary>
        public string TenantId { get; set; }
    }
}
