// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties for generating an upload URI. </summary>
    public partial class DevTestLabGenerateUploadUriContent
    {
        /// <summary> Initializes a new instance of <see cref="DevTestLabGenerateUploadUriContent"/>. </summary>
        public DevTestLabGenerateUploadUriContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabGenerateUploadUriContent"/>. </summary>
        /// <param name="blobName"> The blob name of the upload URI. </param>
        internal DevTestLabGenerateUploadUriContent(string blobName)
        {
            BlobName = blobName;
        }

        /// <summary> The blob name of the upload URI. </summary>
        public string BlobName { get; set; }
    }
}
