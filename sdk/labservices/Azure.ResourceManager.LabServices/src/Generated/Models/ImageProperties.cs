// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Properties of an image resource. </summary>
    internal partial class ImageProperties : ImageUpdateProperties
    {
        /// <summary> Initializes a new instance of ImageProperties. </summary>
        internal ImageProperties()
        {
            AvailableRegions = new ChangeTrackingList<string>();
        }

        /// <summary> Current provisioning state of the image. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The image display name. </summary>
        public string DisplayName { get; }
        /// <summary> A description of the image. </summary>
        public string Description { get; }
        /// <summary> URL of the image icon. </summary>
        public string IconUrl { get; }
        /// <summary> The image author. </summary>
        public string Author { get; }
        /// <summary> The OS Type of the image. </summary>
        public OsType? OsType { get; }
        /// <summary> The ID of marketplace plan associated with the image (optional). </summary>
        public string Plan { get; }
        /// <summary> The status of image terms of use (enabled = accepted, disabled = not accepted). </summary>
        public EnableState? TermsStatus { get; }
        /// <summary> The ID of an offer associated with the image. </summary>
        public string Offer { get; }
        /// <summary> The ID of the publisher of the image. </summary>
        public string Publisher { get; }
        /// <summary> The image SKU. </summary>
        public string Sku { get; }
        /// <summary> The image version. </summary>
        public string Version { get; }
        /// <summary> The ID for the image in the shared gallery. </summary>
        public string SharedGalleryId { get; }
        /// <summary> The available regions of the image in the shared gallery. </summary>
        public IReadOnlyList<string> AvailableRegions { get; }
        /// <summary> The OS State of the image. </summary>
        public OsState? OsState { get; }
    }
}
