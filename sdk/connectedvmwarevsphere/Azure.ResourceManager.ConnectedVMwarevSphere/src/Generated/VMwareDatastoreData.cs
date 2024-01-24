// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary>
    /// A class representing the VMwareDatastore data model.
    /// Define the datastore.
    /// </summary>
    public partial class VMwareDatastoreData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="VMwareDatastoreData"/>. </summary>
        /// <param name="location"> The location. </param>
        public VMwareDatastoreData(AzureLocation location) : base(location)
        {
            Statuses = new ChangeTrackingList<VMwareResourceStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="VMwareDatastoreData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> Gets or sets the extended location. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="uuid"> Gets or sets a unique identifier for this resource. </param>
        /// <param name="vCenterId"> Gets or sets the ARM Id of the vCenter resource in which this datastore resides. </param>
        /// <param name="moRefId"> Gets or sets the vCenter MoRef (Managed Object Reference) ID for the datastore. </param>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the datastore. </param>
        /// <param name="moName"> Gets or sets the vCenter Managed Object name for the datastore. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="customResourceName"> Gets the name of the corresponding resource in Kubernetes. </param>
        /// <param name="capacityGB"> Gets or sets Maximum capacity of this datastore in GBs. </param>
        /// <param name="freeSpaceGB"> Gets or sets Available space of this datastore in GBs. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VMwareDatastoreData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, string kind, string uuid, string vCenterId, string moRefId, string inventoryItemId, string moName, IReadOnlyList<VMwareResourceStatus> statuses, string customResourceName, long? capacityGB, long? freeSpaceGB, VMwareResourceProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            Kind = kind;
            Uuid = uuid;
            VCenterId = vCenterId;
            MoRefId = moRefId;
            InventoryItemId = inventoryItemId;
            MoName = moName;
            Statuses = statuses;
            CustomResourceName = customResourceName;
            CapacityGB = capacityGB;
            FreeSpaceGB = freeSpaceGB;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VMwareDatastoreData"/> for deserialization. </summary>
        internal VMwareDatastoreData()
        {
        }

        /// <summary> Gets or sets the extended location. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </summary>
        public string Kind { get; set; }
        /// <summary> Gets or sets a unique identifier for this resource. </summary>
        public string Uuid { get; }
        /// <summary> Gets or sets the ARM Id of the vCenter resource in which this datastore resides. </summary>
        public string VCenterId { get; set; }
        /// <summary> Gets or sets the vCenter MoRef (Managed Object Reference) ID for the datastore. </summary>
        public string MoRefId { get; set; }
        /// <summary> Gets or sets the inventory Item ID for the datastore. </summary>
        public string InventoryItemId { get; set; }
        /// <summary> Gets or sets the vCenter Managed Object name for the datastore. </summary>
        public string MoName { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<VMwareResourceStatus> Statuses { get; }
        /// <summary> Gets the name of the corresponding resource in Kubernetes. </summary>
        public string CustomResourceName { get; }
        /// <summary> Gets or sets Maximum capacity of this datastore in GBs. </summary>
        public long? CapacityGB { get; }
        /// <summary> Gets or sets Available space of this datastore in GBs. </summary>
        public long? FreeSpaceGB { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public VMwareResourceProvisioningState? ProvisioningState { get; }
    }
}
