// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Criterion to filter metrics. </summary>
    public partial class MetricCriteria : MultiMetricCriteria
    {
        /// <summary> Initializes a new instance of <see cref="MetricCriteria"/>. </summary>
        /// <param name="name"> Name of the criteria. </param>
        /// <param name="metricName"> Name of the metric. </param>
        /// <param name="timeAggregation"> the criteria time aggregation types. </param>
        /// <param name="operator"> the criteria operator. </param>
        /// <param name="threshold"> the criteria threshold value that activates the alert. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="metricName"/> is null. </exception>
        public MetricCriteria(string name, string metricName, MetricCriteriaTimeAggregationType timeAggregation, MetricCriteriaOperator @operator, double threshold) : base(name, metricName, timeAggregation)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(metricName, nameof(metricName));

            Operator = @operator;
            Threshold = threshold;
            CriterionType = CriterionType.StaticThresholdCriterion;
        }

        /// <summary> Initializes a new instance of <see cref="MetricCriteria"/>. </summary>
        /// <param name="criterionType"> Specifies the type of threshold criteria. </param>
        /// <param name="name"> Name of the criteria. </param>
        /// <param name="metricName"> Name of the metric. </param>
        /// <param name="metricNamespace"> Namespace of the metric. </param>
        /// <param name="timeAggregation"> the criteria time aggregation types. </param>
        /// <param name="dimensions"> List of dimension conditions. </param>
        /// <param name="skipMetricValidation"> Allows creating an alert rule on a custom metric that isn't yet emitted, by causing the metric validation to be skipped. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="operator"> the criteria operator. </param>
        /// <param name="threshold"> the criteria threshold value that activates the alert. </param>
        internal MetricCriteria(CriterionType criterionType, string name, string metricName, string metricNamespace, MetricCriteriaTimeAggregationType timeAggregation, IList<MetricDimension> dimensions, bool? skipMetricValidation, IDictionary<string, BinaryData> additionalProperties, MetricCriteriaOperator @operator, double threshold) : base(criterionType, name, metricName, metricNamespace, timeAggregation, dimensions, skipMetricValidation, additionalProperties)
        {
            Operator = @operator;
            Threshold = threshold;
            CriterionType = criterionType;
        }

        /// <summary> the criteria operator. </summary>
        public MetricCriteriaOperator Operator { get; set; }
        /// <summary> the criteria threshold value that activates the alert. </summary>
        public double Threshold { get; set; }
    }
}
