// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The InstructionStepsInstructionsItem. </summary>
    public partial class InstructionStepsInstructionsItem : ConnectorInstructionModelBase
    {
        /// <summary> Initializes a new instance of InstructionStepsInstructionsItem. </summary>
        /// <param name="type"> The kind of the setting. </param>
        public InstructionStepsInstructionsItem(SettingType type) : base(type)
        {
        }

        /// <summary> Initializes a new instance of InstructionStepsInstructionsItem. </summary>
        /// <param name="parameters"> The parameters for the setting. </param>
        /// <param name="type"> The kind of the setting. </param>
        internal InstructionStepsInstructionsItem(object parameters, SettingType type) : base(parameters, type)
        {
        }
    }
}
