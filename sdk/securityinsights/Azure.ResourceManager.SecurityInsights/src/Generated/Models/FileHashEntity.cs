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
    /// <summary> Represents a file hash entity. </summary>
    public partial class FileHashEntity : EntityData
    {
        /// <summary> Initializes a new instance of FileHashEntity. </summary>
        public FileHashEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, object>();
            Kind = EntityKind.FileHash;
        }

        /// <summary> Initializes a new instance of FileHashEntity. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="algorithm"> The hash algorithm type. </param>
        /// <param name="hashValue"> The file hash value. </param>
        internal FileHashEntity(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, EntityKind kind, IReadOnlyDictionary<string, object> additionalData, string friendlyName, FileHashAlgorithm? algorithm, string hashValue) : base(id, name, type, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            Algorithm = algorithm;
            HashValue = hashValue;
            Kind = kind;
        }

        /// <summary> A bag of custom fields that should be part of the entity and will be presented to the user. </summary>
        public IReadOnlyDictionary<string, object> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> The hash algorithm type. </summary>
        public FileHashAlgorithm? Algorithm { get; }
        /// <summary> The file hash value. </summary>
        public string HashValue { get; }
    }
}
