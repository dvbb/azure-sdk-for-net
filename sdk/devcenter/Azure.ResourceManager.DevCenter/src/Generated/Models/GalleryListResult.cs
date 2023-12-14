// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevCenter;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Results of the gallery list operation. </summary>
    internal partial class GalleryListResult
    {
        /// <summary> Initializes a new instance of <see cref="GalleryListResult"/>. </summary>
        internal GalleryListResult()
        {
            Value = new ChangeTrackingList<DevCenterGalleryData>();
        }

        /// <summary> Initializes a new instance of <see cref="GalleryListResult"/>. </summary>
        /// <param name="value"> Current page of results. </param>
        /// <param name="nextLink"> URL to get the next set of results if there are any. </param>
        internal GalleryListResult(IReadOnlyList<DevCenterGalleryData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Current page of results. </summary>
        public IReadOnlyList<DevCenterGalleryData> Value { get; }
        /// <summary> URL to get the next set of results if there are any. </summary>
        public string NextLink { get; }
    }
}
