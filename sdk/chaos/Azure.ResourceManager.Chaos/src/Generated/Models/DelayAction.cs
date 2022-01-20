// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents a delay action. </summary>
    public partial class DelayAction : Action
    {
        /// <summary> Initializes a new instance of DelayAction. </summary>
        /// <param name="name"> String that represents a Capability URN. </param>
        /// <param name="duration"> ISO8601 formatted string that represents a duration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="duration"/> is null. </exception>
        public DelayAction(string name, string duration) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (duration == null)
            {
                throw new ArgumentNullException(nameof(duration));
            }

            Duration = duration;
            Type = "delay";
        }

        /// <summary> Initializes a new instance of DelayAction. </summary>
        /// <param name="type"> Enum that discriminates between action models. </param>
        /// <param name="name"> String that represents a Capability URN. </param>
        /// <param name="duration"> ISO8601 formatted string that represents a duration. </param>
        internal DelayAction(string type, string name, string duration) : base(type, name)
        {
            Duration = duration;
            Type = type ?? "delay";
        }

        /// <summary> ISO8601 formatted string that represents a duration. </summary>
        public string Duration { get; set; }
    }
}
