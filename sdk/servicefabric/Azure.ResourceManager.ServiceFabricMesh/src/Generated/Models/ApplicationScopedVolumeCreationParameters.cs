// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricMesh.Models
{
    /// <summary> Describes parameters for creating application-scoped volumes. </summary>
    public partial class ApplicationScopedVolumeCreationParameters
    {
        /// <summary> Initializes a new instance of ApplicationScopedVolumeCreationParameters. </summary>
        public ApplicationScopedVolumeCreationParameters()
        {
        }

        /// <summary> Initializes a new instance of ApplicationScopedVolumeCreationParameters. </summary>
        /// <param name="kind"> Specifies the application-scoped volume kind. </param>
        /// <param name="description"> User readable description of the volume. </param>
        internal ApplicationScopedVolumeCreationParameters(ApplicationScopedVolumeKind kind, string description)
        {
            Kind = kind;
            Description = description;
        }

        /// <summary> Specifies the application-scoped volume kind. </summary>
        internal ApplicationScopedVolumeKind Kind { get; set; }
        /// <summary> User readable description of the volume. </summary>
        public string Description { get; set; }
    }
}
