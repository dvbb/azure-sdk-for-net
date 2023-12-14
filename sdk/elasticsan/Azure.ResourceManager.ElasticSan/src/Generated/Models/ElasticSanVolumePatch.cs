// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Response for Volume request. </summary>
    public partial class ElasticSanVolumePatch
    {
        /// <summary> Initializes a new instance of <see cref="ElasticSanVolumePatch"/>. </summary>
        public ElasticSanVolumePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ElasticSanVolumePatch"/>. </summary>
        /// <param name="sizeGiB"> Volume size. </param>
        /// <param name="managedBy"> Parent resource information. </param>
        internal ElasticSanVolumePatch(long? sizeGiB, ManagedByInfo managedBy)
        {
            SizeGiB = sizeGiB;
            ManagedBy = managedBy;
        }

        /// <summary> Volume size. </summary>
        public long? SizeGiB { get; set; }
        /// <summary> Parent resource information. </summary>
        internal ManagedByInfo ManagedBy { get; set; }
        /// <summary> Resource ID of the resource managing the volume, this is a restricted field and can only be set for internal use. </summary>
        public ResourceIdentifier ManagedByResourceId
        {
            get => ManagedBy is null ? default : ManagedBy.ResourceId;
            set
            {
                if (ManagedBy is null)
                    ManagedBy = new ManagedByInfo();
                ManagedBy.ResourceId = value;
            }
        }
    }
}
