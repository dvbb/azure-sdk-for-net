// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Use to provide failover region when requesting manual Failover for a hub. </summary>
    public partial class FailoverInput
    {
        /// <summary> Initializes a new instance of FailoverInput. </summary>
        /// <param name="failoverRegion"> Region the hub will be failed over to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverRegion"/> is null. </exception>
        public FailoverInput(string failoverRegion)
        {
            if (failoverRegion == null)
            {
                throw new ArgumentNullException(nameof(failoverRegion));
            }

            FailoverRegion = failoverRegion;
        }

        /// <summary> Region the hub will be failed over to. </summary>
        public string FailoverRegion { get; }
    }
}
