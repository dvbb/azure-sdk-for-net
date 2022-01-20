// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The properties of a stateful service resource for patch operations. </summary>
    internal partial class StatefulServiceUpdateProperties : ServiceResourceUpdateProperties
    {
        /// <summary> Initializes a new instance of StatefulServiceUpdateProperties. </summary>
        internal StatefulServiceUpdateProperties()
        {
            ServiceKind = ServiceKind.Stateful;
        }

        /// <summary> The target replica set size as a number. </summary>
        public int? TargetReplicaSetSize { get; }
        /// <summary> The minimum replica set size as a number. </summary>
        public int? MinReplicaSetSize { get; }
        /// <summary> The duration between when a replica goes down and when a new replica is created, represented in ISO 8601 format (hh:mm:ss.s). </summary>
        public DateTimeOffset? ReplicaRestartWaitDuration { get; }
        /// <summary> The maximum duration for which a partition is allowed to be in a state of quorum loss, represented in ISO 8601 format (hh:mm:ss.s). </summary>
        public DateTimeOffset? QuorumLossWaitDuration { get; }
        /// <summary> The definition on how long StandBy replicas should be maintained before being removed, represented in ISO 8601 format (hh:mm:ss.s). </summary>
        public DateTimeOffset? StandByReplicaKeepDuration { get; }
    }
}
