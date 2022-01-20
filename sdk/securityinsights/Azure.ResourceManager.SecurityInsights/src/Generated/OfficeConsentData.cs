// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary> A class representing the OfficeConsent data model. </summary>
    public partial class OfficeConsentData : Models.Resource
    {
        /// <summary> Initializes a new instance of OfficeConsentData. </summary>
        public OfficeConsentData()
        {
        }

        /// <summary> Initializes a new instance of OfficeConsentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        /// <param name="tenantId"> The tenantId of the Office365 with the consent. </param>
        /// <param name="consentId"> Help to easily cascade among the data layers. </param>
        internal OfficeConsentData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string tenantId, string consentId) : base(id, name, type, systemData)
        {
            TenantId = tenantId;
            ConsentId = consentId;
        }

        /// <summary> The tenantId of the Office365 with the consent. </summary>
        public string TenantId { get; set; }
        /// <summary> Help to easily cascade among the data layers. </summary>
        public string ConsentId { get; set; }
    }
}
