// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Details of step input. </summary>
    public partial class StepInput
    {
        /// <summary> Initializes a new instance of <see cref="StepInput"/>. </summary>
        internal StepInput()
        {
            ResponseOptions = new ChangeTrackingList<ResponseConfig>();
        }

        /// <summary> Initializes a new instance of <see cref="StepInput"/>. </summary>
        /// <param name="questionId"> Use Index as QuestionId. </param>
        /// <param name="questionType"> Text Input. Will be a single line input. </param>
        /// <param name="questionContent"> User question content. </param>
        /// <param name="questionContentType"> Default is Text. </param>
        /// <param name="responseHint"> Place holder text for response hints. </param>
        /// <param name="recommendedOption"> Result of Automate step. </param>
        /// <param name="selectedOptionValue"> Text of response that was selected. </param>
        /// <param name="responseValidationProperties"> Troubleshooter step input response validation properties. </param>
        /// <param name="responseOptions"></param>
        internal StepInput(string questionId, string questionType, string questionContent, QuestionContentType? questionContentType, string responseHint, string recommendedOption, string selectedOptionValue, ResponseValidationProperties responseValidationProperties, IReadOnlyList<ResponseConfig> responseOptions)
        {
            QuestionId = questionId;
            QuestionType = questionType;
            QuestionContent = questionContent;
            QuestionContentType = questionContentType;
            ResponseHint = responseHint;
            RecommendedOption = recommendedOption;
            SelectedOptionValue = selectedOptionValue;
            ResponseValidationProperties = responseValidationProperties;
            ResponseOptions = responseOptions;
        }

        /// <summary> Use Index as QuestionId. </summary>
        public string QuestionId { get; }
        /// <summary> Text Input. Will be a single line input. </summary>
        public string QuestionType { get; }
        /// <summary> User question content. </summary>
        public string QuestionContent { get; }
        /// <summary> Default is Text. </summary>
        public QuestionContentType? QuestionContentType { get; }
        /// <summary> Place holder text for response hints. </summary>
        public string ResponseHint { get; }
        /// <summary> Result of Automate step. </summary>
        public string RecommendedOption { get; }
        /// <summary> Text of response that was selected. </summary>
        public string SelectedOptionValue { get; }
        /// <summary> Troubleshooter step input response validation properties. </summary>
        public ResponseValidationProperties ResponseValidationProperties { get; }
        /// <summary> Gets the response options. </summary>
        public IReadOnlyList<ResponseConfig> ResponseOptions { get; }
    }
}
