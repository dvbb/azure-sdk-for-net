// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the GalleryImageVersion data model.
    /// Specifies information about the gallery image version that you want to create or update.
    /// </summary>
    public partial class GalleryImageVersionData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GalleryImageVersionData"/>. </summary>
        /// <param name="location"> The location. </param>
        public GalleryImageVersionData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="GalleryImageVersionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="publishingProfile"> The publishing profile of a gallery image Version. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="storageProfile"> This is the storage profile of a Gallery Image Version. </param>
        /// <param name="safetyProfile"> This is the safety profile of the Gallery Image Version. </param>
        /// <param name="replicationStatus"> This is the replication status of the gallery image version. </param>
        /// <param name="securityProfile"> The security profile of a gallery image version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryImageVersionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, GalleryImageVersionPublishingProfile publishingProfile, GalleryProvisioningState? provisioningState, GalleryImageVersionStorageProfile storageProfile, GalleryImageVersionSafetyProfile safetyProfile, ReplicationStatus replicationStatus, ImageVersionSecurityProfile securityProfile, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            PublishingProfile = publishingProfile;
            ProvisioningState = provisioningState;
            StorageProfile = storageProfile;
            SafetyProfile = safetyProfile;
            ReplicationStatus = replicationStatus;
            SecurityProfile = securityProfile;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GalleryImageVersionData"/> for deserialization. </summary>
        internal GalleryImageVersionData()
        {
        }

        /// <summary> The publishing profile of a gallery image Version. </summary>
        public GalleryImageVersionPublishingProfile PublishingProfile { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public GalleryProvisioningState? ProvisioningState { get; }
        /// <summary> This is the storage profile of a Gallery Image Version. </summary>
        public GalleryImageVersionStorageProfile StorageProfile { get; set; }
        /// <summary> This is the safety profile of the Gallery Image Version. </summary>
        public GalleryImageVersionSafetyProfile SafetyProfile { get; set; }
        /// <summary> This is the replication status of the gallery image version. </summary>
        public ReplicationStatus ReplicationStatus { get; }
        /// <summary> The security profile of a gallery image version. </summary>
        internal ImageVersionSecurityProfile SecurityProfile { get; set; }
        /// <summary> Contains UEFI settings for the image version. </summary>
        public GalleryImageVersionUefiSettings SecurityUefiSettings
        {
            get => SecurityProfile is null ? default : SecurityProfile.UefiSettings;
            set
            {
                if (SecurityProfile is null)
                    SecurityProfile = new ImageVersionSecurityProfile();
                SecurityProfile.UefiSettings = value;
            }
        }
    }
}
