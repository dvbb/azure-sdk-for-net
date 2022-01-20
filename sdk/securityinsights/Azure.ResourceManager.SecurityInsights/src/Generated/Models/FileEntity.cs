// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a file entity. </summary>
    public partial class FileEntity : EntityData
    {
        /// <summary> Initializes a new instance of FileEntity. </summary>
        public FileEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, object>();
            FileHashEntityIds = new ChangeTrackingList<string>();
            Kind = EntityKind.File;
        }

        /// <summary> Initializes a new instance of FileEntity. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="directory"> The full path to the file. </param>
        /// <param name="fileHashEntityIds"> The file hash entity identifiers associated with this file. </param>
        /// <param name="fileName"> The file name without path (some alerts might not include path). </param>
        /// <param name="hostEntityId"> The Host entity id which the file belongs to. </param>
        internal FileEntity(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, EntityKind kind, IReadOnlyDictionary<string, object> additionalData, string friendlyName, string directory, IReadOnlyList<string> fileHashEntityIds, string fileName, string hostEntityId) : base(id, name, type, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            Directory = directory;
            FileHashEntityIds = fileHashEntityIds;
            FileName = fileName;
            HostEntityId = hostEntityId;
            Kind = kind;
        }

        /// <summary> A bag of custom fields that should be part of the entity and will be presented to the user. </summary>
        public IReadOnlyDictionary<string, object> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> The full path to the file. </summary>
        public string Directory { get; }
        /// <summary> The file hash entity identifiers associated with this file. </summary>
        public IReadOnlyList<string> FileHashEntityIds { get; }
        /// <summary> The file name without path (some alerts might not include path). </summary>
        public string FileName { get; }
        /// <summary> The Host entity id which the file belongs to. </summary>
        public string HostEntityId { get; }
    }
}
