// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AzureStackHCI.Models
{
    /// <summary> Cluster node details. </summary>
    public partial class ClusterNode
    {
        /// <summary> Initializes a new instance of ClusterNode. </summary>
        internal ClusterNode()
        {
        }

        /// <summary> Initializes a new instance of ClusterNode. </summary>
        /// <param name="name"> Name of the cluster node. </param>
        /// <param name="id"> Id of the node in the cluster. </param>
        /// <param name="windowsServerSubscription"> State of Windows Server Subscription. </param>
        /// <param name="manufacturer"> Manufacturer of the cluster node hardware. </param>
        /// <param name="model"> Model name of the cluster node hardware. </param>
        /// <param name="osName"> Operating system running on the cluster node. </param>
        /// <param name="osVersion"> Version of the operating system running on the cluster node. </param>
        /// <param name="serialNumber"> Immutable id of the cluster node. </param>
        /// <param name="coreCount"> Number of physical cores on the cluster node. </param>
        /// <param name="memoryInGiB"> Total available memory on the cluster node (in GiB). </param>
        internal ClusterNode(string name, float? id, WindowsServerSubscription? windowsServerSubscription, string manufacturer, string model, string osName, string osVersion, string serialNumber, float? coreCount, float? memoryInGiB)
        {
            Name = name;
            Id = id;
            WindowsServerSubscription = windowsServerSubscription;
            Manufacturer = manufacturer;
            Model = model;
            OsName = osName;
            OsVersion = osVersion;
            SerialNumber = serialNumber;
            CoreCount = coreCount;
            MemoryInGiB = memoryInGiB;
        }

        /// <summary> Name of the cluster node. </summary>
        public string Name { get; }
        /// <summary> Id of the node in the cluster. </summary>
        public float? Id { get; }
        /// <summary> State of Windows Server Subscription. </summary>
        public WindowsServerSubscription? WindowsServerSubscription { get; }
        /// <summary> Manufacturer of the cluster node hardware. </summary>
        public string Manufacturer { get; }
        /// <summary> Model name of the cluster node hardware. </summary>
        public string Model { get; }
        /// <summary> Operating system running on the cluster node. </summary>
        public string OsName { get; }
        /// <summary> Version of the operating system running on the cluster node. </summary>
        public string OsVersion { get; }
        /// <summary> Immutable id of the cluster node. </summary>
        public string SerialNumber { get; }
        /// <summary> Number of physical cores on the cluster node. </summary>
        public float? CoreCount { get; }
        /// <summary> Total available memory on the cluster node (in GiB). </summary>
        public float? MemoryInGiB { get; }
    }
}
