// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.ResourceNotifications.Resources.Deleted event. </summary>
    public partial class ResourceNotificationsResourceManagementDeletedEventData : ResourceNotificationsResourceDeletedEventData
    {
        /// <summary> Initializes a new instance of <see cref="ResourceNotificationsResourceManagementDeletedEventData"/>. </summary>
        internal ResourceNotificationsResourceManagementDeletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceNotificationsResourceManagementDeletedEventData"/>. </summary>
        /// <param name="resourceDetails"> resourceInfo details for delete event. </param>
        /// <param name="operationalDetails"> details about operational info. </param>
        internal ResourceNotificationsResourceManagementDeletedEventData(ResourceNotificationsResourceDeletedDetails resourceDetails, ResourceNotificationsOperationalDetails operationalDetails) : base(resourceDetails, operationalDetails)
        {
        }
    }
}
