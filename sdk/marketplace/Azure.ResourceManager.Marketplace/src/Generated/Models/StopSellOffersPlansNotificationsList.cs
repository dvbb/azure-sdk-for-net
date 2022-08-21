// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> List of stop sell offers and plans notifications. </summary>
    public partial class StopSellOffersPlansNotificationsList
    {
        /// <summary> Initializes a new instance of StopSellOffersPlansNotificationsList. </summary>
        internal StopSellOffersPlansNotificationsList()
        {
            StopSellNotifications = new ChangeTrackingList<StopSellOffersPlansNotificationsListProperties>();
        }

        /// <summary> Initializes a new instance of StopSellOffersPlansNotificationsList. </summary>
        /// <param name="stopSellNotifications"></param>
        internal StopSellOffersPlansNotificationsList(IReadOnlyList<StopSellOffersPlansNotificationsListProperties> stopSellNotifications)
        {
            StopSellNotifications = stopSellNotifications;
        }

        /// <summary> Gets the stop sell notifications. </summary>
        public IReadOnlyList<StopSellOffersPlansNotificationsListProperties> StopSellNotifications { get; }
    }
}
