// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Custom container user source info. </summary>
    public partial class CustomContainerUserSourceInfo : UserSourceInfo
    {
        /// <summary> Initializes a new instance of CustomContainerUserSourceInfo. </summary>
        public CustomContainerUserSourceInfo()
        {
            Type = "Container";
        }

        /// <summary> Initializes a new instance of CustomContainerUserSourceInfo. </summary>
        /// <param name="type"> Type of the source uploaded. </param>
        /// <param name="version"> Version of the source. </param>
        /// <param name="customContainer"> Custom container payload. </param>
        internal CustomContainerUserSourceInfo(string type, string version, CustomContainer customContainer) : base(type, version)
        {
            CustomContainer = customContainer;
            Type = type ?? "Container";
        }

        /// <summary> Custom container payload. </summary>
        public CustomContainer CustomContainer { get; set; }
    }
}
