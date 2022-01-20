// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorSimple8000Series.Models
{
    /// <summary> The OData filter to be used for jobs. </summary>
    internal partial class JobFilter
    {
        /// <summary> Initializes a new instance of JobFilter. </summary>
        internal JobFilter()
        {
        }

        /// <summary> Specifies the status of the jobs to be filtered. For e.g., &quot;Running&quot;, &quot;Succeeded&quot;, &quot;Failed&quot; or &quot;Canceled&quot;. Only &apos;Equality&apos; operator is supported for this property. </summary>
        public string Status { get; }
        /// <summary> Specifies the type of the jobs to be filtered. For e.g., &quot;ScheduledBackup&quot;, &quot;ManualBackup&quot;, &quot;RestoreBackup&quot;, &quot;CloneVolume&quot;, &quot;FailoverVolumeContainers&quot;, &quot;CreateLocallyPinnedVolume&quot;, &quot;ModifyVolume&quot;, &quot;InstallUpdates&quot;, &quot;SupportPackageLogs&quot;, or &quot;CreateCloudAppliance&quot;. Only &apos;Equality&apos; operator can be used for this property. </summary>
        public string JobType { get; }
        /// <summary> Specifies the start time of the jobs to be filtered.  Only &apos;Greater Than or Equal To&apos; and &apos;Lesser Than or Equal To&apos; operators are supported for this property. </summary>
        public DateTimeOffset? StartTime { get; }
    }
}
