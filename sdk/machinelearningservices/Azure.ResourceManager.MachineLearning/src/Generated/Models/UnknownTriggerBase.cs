// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownTriggerBase. </summary>
    internal partial class UnknownTriggerBase : MachineLearningTriggerBase
    {
        /// <summary> Initializes a new instance of <see cref="UnknownTriggerBase"/>. </summary>
        /// <param name="endTime">
        /// Specifies end time of schedule in ISO 8601, but without a UTC offset. Refer https://en.wikipedia.org/wiki/ISO_8601.
        /// Recommented format would be "2022-06-01T00:00:01"
        /// If not present, the schedule will run indefinitely
        /// </param>
        /// <param name="startTime"> Specifies start time of schedule in ISO 8601 format, but without a UTC offset. </param>
        /// <param name="timeZone">
        /// Specifies time zone in which the schedule runs.
        /// TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
        /// </param>
        /// <param name="triggerType"> [Required]. </param>
        internal UnknownTriggerBase(string endTime, string startTime, string timeZone, MachineLearningTriggerType triggerType) : base(endTime, startTime, timeZone, triggerType)
        {
            TriggerType = triggerType;
        }
    }
}
