// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The ImportImageParameters. </summary>
    public partial class ImportImageParameters
    {
        /// <summary> Initializes a new instance of ImportImageParameters. </summary>
        /// <param name="source"> The source of the image. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> is null. </exception>
        public ImportImageParameters(ImportSource source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            Source = source;
            TargetTags = new ChangeTrackingList<string>();
            UntaggedTargetRepositories = new ChangeTrackingList<string>();
        }

        /// <summary> The source of the image. </summary>
        public ImportSource Source { get; }
        /// <summary> List of strings of the form repo[:tag]. When tag is omitted the source will be used (or &apos;latest&apos; if source tag is also omitted). </summary>
        public IList<string> TargetTags { get; }
        /// <summary> List of strings of repository names to do a manifest only copy. No tag will be created. </summary>
        public IList<string> UntaggedTargetRepositories { get; }
        /// <summary> When Force, any existing target tags will be overwritten. When NoForce, any existing target tags will fail the operation before any copying begins. </summary>
        public ImportMode? Mode { get; set; }
    }
}
