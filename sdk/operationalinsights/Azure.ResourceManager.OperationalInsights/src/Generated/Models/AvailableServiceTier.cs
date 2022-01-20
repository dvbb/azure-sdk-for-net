// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Service Tier details. </summary>
    public partial class AvailableServiceTier
    {
        /// <summary> Initializes a new instance of AvailableServiceTier. </summary>
        internal AvailableServiceTier()
        {
        }

        /// <summary> Initializes a new instance of AvailableServiceTier. </summary>
        /// <param name="serviceTier"> The name of the Service Tier. </param>
        /// <param name="enabled"> True if the Service Tier is enabled for the workspace. </param>
        /// <param name="minimumRetention"> The minimum retention for the Service Tier, in days. </param>
        /// <param name="maximumRetention"> The maximum retention for the Service Tier, in days. </param>
        /// <param name="defaultRetention"> The default retention for the Service Tier, in days. </param>
        /// <param name="capacityReservationLevel"> The capacity reservation level in GB per day. Returned for the Capacity Reservation Service Tier. </param>
        /// <param name="lastSkuUpdate"> Time when the sku was last updated for the workspace. Returned for the Capacity Reservation Service Tier. </param>
        internal AvailableServiceTier(SkuNameEnum? serviceTier, bool? enabled, long? minimumRetention, long? maximumRetention, long? defaultRetention, long? capacityReservationLevel, string lastSkuUpdate)
        {
            ServiceTier = serviceTier;
            Enabled = enabled;
            MinimumRetention = minimumRetention;
            MaximumRetention = maximumRetention;
            DefaultRetention = defaultRetention;
            CapacityReservationLevel = capacityReservationLevel;
            LastSkuUpdate = lastSkuUpdate;
        }

        /// <summary> The name of the Service Tier. </summary>
        public SkuNameEnum? ServiceTier { get; }
        /// <summary> True if the Service Tier is enabled for the workspace. </summary>
        public bool? Enabled { get; }
        /// <summary> The minimum retention for the Service Tier, in days. </summary>
        public long? MinimumRetention { get; }
        /// <summary> The maximum retention for the Service Tier, in days. </summary>
        public long? MaximumRetention { get; }
        /// <summary> The default retention for the Service Tier, in days. </summary>
        public long? DefaultRetention { get; }
        /// <summary> The capacity reservation level in GB per day. Returned for the Capacity Reservation Service Tier. </summary>
        public long? CapacityReservationLevel { get; }
        /// <summary> Time when the sku was last updated for the workspace. Returned for the Capacity Reservation Service Tier. </summary>
        public string LastSkuUpdate { get; }
    }
}
