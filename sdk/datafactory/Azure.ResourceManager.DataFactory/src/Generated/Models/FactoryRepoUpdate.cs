// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Factory&apos;s git repo information. </summary>
    public partial class FactoryRepoUpdate
    {
        /// <summary> Initializes a new instance of FactoryRepoUpdate. </summary>
        public FactoryRepoUpdate()
        {
        }

        /// <summary> The factory resource id. </summary>
        public string FactoryResourceId { get; set; }
        /// <summary> Git repo information of the factory. </summary>
        public FactoryRepoConfiguration RepoConfiguration { get; set; }
    }
}
