// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> For schedules like: 'recur every Monday' or 'recur every 3 weeks on Wednesday'. </summary>
    public partial class ContainerServiceMaintenanceWeeklySchedule
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceMaintenanceWeeklySchedule"/>. </summary>
        /// <param name="intervalWeeks"> Specifies the number of weeks between each set of occurrences. </param>
        /// <param name="dayOfWeek"> Specifies on which day of the week the maintenance occurs. </param>
        public ContainerServiceMaintenanceWeeklySchedule(int intervalWeeks, ContainerServiceWeekDay dayOfWeek)
        {
            IntervalWeeks = intervalWeeks;
            DayOfWeek = dayOfWeek;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceMaintenanceWeeklySchedule"/>. </summary>
        /// <param name="intervalWeeks"> Specifies the number of weeks between each set of occurrences. </param>
        /// <param name="dayOfWeek"> Specifies on which day of the week the maintenance occurs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceMaintenanceWeeklySchedule(int intervalWeeks, ContainerServiceWeekDay dayOfWeek, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IntervalWeeks = intervalWeeks;
            DayOfWeek = dayOfWeek;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceMaintenanceWeeklySchedule"/> for deserialization. </summary>
        internal ContainerServiceMaintenanceWeeklySchedule()
        {
        }

        /// <summary> Specifies the number of weeks between each set of occurrences. </summary>
        public int IntervalWeeks { get; set; }
        /// <summary> Specifies on which day of the week the maintenance occurs. </summary>
        public ContainerServiceWeekDay DayOfWeek { get; set; }
    }
}
