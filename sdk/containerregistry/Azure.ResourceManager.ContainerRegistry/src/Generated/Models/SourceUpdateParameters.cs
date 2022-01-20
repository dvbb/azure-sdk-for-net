// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties for updating the source code repository. </summary>
    public partial class SourceUpdateParameters
    {
        /// <summary> Initializes a new instance of SourceUpdateParameters. </summary>
        public SourceUpdateParameters()
        {
        }

        /// <summary> The type of source control service. </summary>
        public SourceControlType? SourceControlType { get; set; }
        /// <summary> The full URL to the source code repository. </summary>
        public string RepositoryUrl { get; set; }
        /// <summary> The branch name of the source code. </summary>
        public string Branch { get; set; }
        /// <summary>
        /// The authorization properties for accessing the source code repository and to set up
        /// webhooks for notifications.
        /// </summary>
        public AuthInfoUpdateParameters SourceControlAuthProperties { get; set; }
    }
}
