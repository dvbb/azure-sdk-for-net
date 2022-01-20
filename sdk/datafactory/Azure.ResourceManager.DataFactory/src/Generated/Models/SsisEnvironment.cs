// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Ssis environment. </summary>
    public partial class SsisEnvironment : SsisObjectMetadata
    {
        /// <summary> Initializes a new instance of SsisEnvironment. </summary>
        internal SsisEnvironment()
        {
            Variables = new ChangeTrackingList<SsisVariable>();
            Type = SsisObjectMetadataType.Environment;
        }

        /// <summary> Initializes a new instance of SsisEnvironment. </summary>
        /// <param name="type"> Type of metadata. </param>
        /// <param name="id"> Metadata id. </param>
        /// <param name="name"> Metadata name. </param>
        /// <param name="description"> Metadata description. </param>
        /// <param name="folderId"> Folder id which contains environment. </param>
        /// <param name="variables"> Variable in environment. </param>
        internal SsisEnvironment(SsisObjectMetadataType type, long? id, string name, string description, long? folderId, IReadOnlyList<SsisVariable> variables) : base(type, id, name, description)
        {
            FolderId = folderId;
            Variables = variables;
            Type = type;
        }

        /// <summary> Folder id which contains environment. </summary>
        public long? FolderId { get; }
        /// <summary> Variable in environment. </summary>
        public IReadOnlyList<SsisVariable> Variables { get; }
    }
}
