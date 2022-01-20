// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> User subscription quota response. </summary>
    public partial class UserSubscriptionQuota
    {
        /// <summary> Initializes a new instance of UserSubscriptionQuota. </summary>
        internal UserSubscriptionQuota()
        {
        }

        /// <summary> Initializes a new instance of UserSubscriptionQuota. </summary>
        /// <param name="id"> IotHub type id. </param>
        /// <param name="type"> Response type. </param>
        /// <param name="unit"> Unit of IotHub type. </param>
        /// <param name="currentValue"> Current number of IotHub type. </param>
        /// <param name="limit"> Numerical limit on IotHub type. </param>
        /// <param name="name"> IotHub type. </param>
        internal UserSubscriptionQuota(string id, string type, string unit, int? currentValue, int? limit, Name name)
        {
            Id = id;
            Type = type;
            Unit = unit;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
        }

        /// <summary> IotHub type id. </summary>
        public string Id { get; }
        /// <summary> Response type. </summary>
        public string Type { get; }
        /// <summary> Unit of IotHub type. </summary>
        public string Unit { get; }
        /// <summary> Current number of IotHub type. </summary>
        public int? CurrentValue { get; }
        /// <summary> Numerical limit on IotHub type. </summary>
        public int? Limit { get; }
        /// <summary> IotHub type. </summary>
        public Name Name { get; }
    }
}
