// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines the Timeseries. </summary>
    public partial class Timeseries : TrackedResource
    {
        /// <summary> Initializes a new instance of Timeseries. </summary>
        /// <param name="location"> The location. </param>
        public Timeseries(AzureLocation location) : base(location)
        {
            TimeseriesData = new ChangeTrackingList<TimeseriesDataPoint>();
        }

        /// <summary> Initializes a new instance of Timeseries. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="endpoint"> The endpoint associated with the Timeseries data point. </param>
        /// <param name="startDateTimeUTC"> The start DateTime of the Timeseries in UTC. </param>
        /// <param name="endDateTimeUTC"> The end DateTime of the Timeseries in UTC. </param>
        /// <param name="aggregationInterval"> The aggregation interval of the Timeseries. </param>
        /// <param name="timeseriesType"> The type of Timeseries. </param>
        /// <param name="country"> The country associated with the Timeseries. Values are country ISO codes as specified here- https://www.iso.org/iso-3166-country-codes.html. </param>
        /// <param name="timeseriesData"> The set of data points for the timeseries. </param>
        internal Timeseries(ResourceIdentifier id, string name, Azure.Core.ResourceType type, IDictionary<string, string> tags, AzureLocation location, string endpoint, string startDateTimeUTC, string endDateTimeUTC, AggregationInterval? aggregationInterval, TimeseriesType? timeseriesType, string country, IList<TimeseriesDataPoint> timeseriesData) : base(id, name, type, tags, location)
        {
            Endpoint = endpoint;
            StartDateTimeUTC = startDateTimeUTC;
            EndDateTimeUTC = endDateTimeUTC;
            AggregationInterval = aggregationInterval;
            TimeseriesType = timeseriesType;
            Country = country;
            TimeseriesData = timeseriesData;
        }

        /// <summary> The endpoint associated with the Timeseries data point. </summary>
        public string Endpoint { get; set; }
        /// <summary> The start DateTime of the Timeseries in UTC. </summary>
        public string StartDateTimeUTC { get; set; }
        /// <summary> The end DateTime of the Timeseries in UTC. </summary>
        public string EndDateTimeUTC { get; set; }
        /// <summary> The aggregation interval of the Timeseries. </summary>
        public AggregationInterval? AggregationInterval { get; set; }
        /// <summary> The type of Timeseries. </summary>
        public TimeseriesType? TimeseriesType { get; set; }
        /// <summary> The country associated with the Timeseries. Values are country ISO codes as specified here- https://www.iso.org/iso-3166-country-codes.html. </summary>
        public string Country { get; set; }
        /// <summary> The set of data points for the timeseries. </summary>
        public IList<TimeseriesDataPoint> TimeseriesData { get; }
    }
}
