// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningNotebookResourceInfo. </summary>
    public partial class MachineLearningNotebookResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningNotebookResourceInfo"/>. </summary>
        internal MachineLearningNotebookResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningNotebookResourceInfo"/>. </summary>
        /// <param name="fqdn"></param>
        /// <param name="isPrivateLinkEnabled"></param>
        /// <param name="notebookPreparationError"> The error that occurs when preparing notebook. </param>
        /// <param name="resourceId"> the data plane resourceId that used to initialize notebook component. </param>
        internal MachineLearningNotebookResourceInfo(string fqdn, bool? isPrivateLinkEnabled, MachineLearningNotebookPreparationError notebookPreparationError, string resourceId)
        {
            Fqdn = fqdn;
            IsPrivateLinkEnabled = isPrivateLinkEnabled;
            NotebookPreparationError = notebookPreparationError;
            ResourceId = resourceId;
        }

        /// <summary> Gets the fqdn. </summary>
        public string Fqdn { get; }
        /// <summary> Gets the is private link enabled. </summary>
        public bool? IsPrivateLinkEnabled { get; }
        /// <summary> The error that occurs when preparing notebook. </summary>
        public MachineLearningNotebookPreparationError NotebookPreparationError { get; }
        /// <summary> the data plane resourceId that used to initialize notebook component. </summary>
        public string ResourceId { get; }
    }
}
