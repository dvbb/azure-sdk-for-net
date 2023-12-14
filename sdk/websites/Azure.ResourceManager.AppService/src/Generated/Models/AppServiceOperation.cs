// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> An operation on a resource. </summary>
    public partial class AppServiceOperation
    {
        /// <summary> Initializes a new instance of <see cref="AppServiceOperation"/>. </summary>
        internal AppServiceOperation()
        {
            Errors = new ChangeTrackingList<ResponseError>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceOperation"/>. </summary>
        /// <param name="id"> Operation ID. </param>
        /// <param name="name"> Operation name. </param>
        /// <param name="status"> The current status of the operation. </param>
        /// <param name="errors"> Any errors associate with the operation. </param>
        /// <param name="createdOn"> Time when operation has started. </param>
        /// <param name="modifiedOn"> Time when operation has been updated. </param>
        /// <param name="expireOn"> Time when operation will expire. </param>
        /// <param name="geoMasterOperationId"> Applicable only for stamp operation ids. </param>
        internal AppServiceOperation(string id, string name, AppServiceOperationStatus? status, IReadOnlyList<ResponseError> errors, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, DateTimeOffset? expireOn, Guid? geoMasterOperationId)
        {
            Id = id;
            Name = name;
            Status = status;
            Errors = errors;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            ExpireOn = expireOn;
            GeoMasterOperationId = geoMasterOperationId;
        }

        /// <summary> Operation ID. </summary>
        public string Id { get; }
        /// <summary> Operation name. </summary>
        public string Name { get; }
        /// <summary> The current status of the operation. </summary>
        public AppServiceOperationStatus? Status { get; }
        /// <summary> Any errors associate with the operation. </summary>
        public IReadOnlyList<ResponseError> Errors { get; }
        /// <summary> Time when operation has started. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Time when operation has been updated. </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> Time when operation will expire. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> Applicable only for stamp operation ids. </summary>
        public Guid? GeoMasterOperationId { get; }
    }
}
