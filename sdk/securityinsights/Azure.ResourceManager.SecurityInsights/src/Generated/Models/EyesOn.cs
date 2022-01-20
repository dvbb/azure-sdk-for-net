// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Settings with single toggle. </summary>
    public partial class EyesOn : SettingsData
    {
        /// <summary> Initializes a new instance of EyesOn. </summary>
        public EyesOn()
        {
            Kind = SettingKind.EyesOn;
        }

        /// <summary> Initializes a new instance of EyesOn. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="kind"> The kind of the setting. </param>
        /// <param name="isEnabled"> Determines whether the setting is enable or disabled. </param>
        internal EyesOn(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string etag, SettingKind kind, bool? isEnabled) : base(id, name, type, systemData, etag, kind)
        {
            IsEnabled = isEnabled;
            Kind = kind;
        }

        /// <summary> Determines whether the setting is enable or disabled. </summary>
        public bool? IsEnabled { get; }
    }
}
