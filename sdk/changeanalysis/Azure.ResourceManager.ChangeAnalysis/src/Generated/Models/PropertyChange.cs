// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ChangeAnalysis.Models
{
    /// <summary> Data of a property change. </summary>
    public partial class PropertyChange
    {
        /// <summary> Initializes a new instance of PropertyChange. </summary>
        internal PropertyChange()
        {
        }

        /// <summary> Initializes a new instance of PropertyChange. </summary>
        /// <param name="changeType"> The type of the change. </param>
        /// <param name="changeCategory"> The change category. </param>
        /// <param name="jsonPath"> The json path of the changed property. </param>
        /// <param name="displayName"> The enhanced display name of the json path. E.g., the json path value[0].properties will be translated to something meaningful like slots[&quot;Staging&quot;].properties. </param>
        /// <param name="level"></param>
        /// <param name="description"> The description of the changed property. </param>
        /// <param name="oldValue"> The value of the property before the change. </param>
        /// <param name="newValue"> The value of the property after the change. </param>
        /// <param name="isDataMasked"> The boolean indicating whether the oldValue and newValue are masked. The values are masked if it contains sensitive information that the user doesn&apos;t have access to. </param>
        internal PropertyChange(ChangeType? changeType, ChangeCategory? changeCategory, string jsonPath, string displayName, Level? level, string description, string oldValue, string newValue, bool? isDataMasked)
        {
            ChangeType = changeType;
            ChangeCategory = changeCategory;
            JsonPath = jsonPath;
            DisplayName = displayName;
            Level = level;
            Description = description;
            OldValue = oldValue;
            NewValue = newValue;
            IsDataMasked = isDataMasked;
        }

        /// <summary> The type of the change. </summary>
        public ChangeType? ChangeType { get; }
        /// <summary> The change category. </summary>
        public ChangeCategory? ChangeCategory { get; }
        /// <summary> The json path of the changed property. </summary>
        public string JsonPath { get; }
        /// <summary> The enhanced display name of the json path. E.g., the json path value[0].properties will be translated to something meaningful like slots[&quot;Staging&quot;].properties. </summary>
        public string DisplayName { get; }
        /// <summary> Gets the level. </summary>
        public Level? Level { get; }
        /// <summary> The description of the changed property. </summary>
        public string Description { get; }
        /// <summary> The value of the property before the change. </summary>
        public string OldValue { get; }
        /// <summary> The value of the property after the change. </summary>
        public string NewValue { get; }
        /// <summary> The boolean indicating whether the oldValue and newValue are masked. The values are masked if it contains sensitive information that the user doesn&apos;t have access to. </summary>
        public bool? IsDataMasked { get; }
    }
}
