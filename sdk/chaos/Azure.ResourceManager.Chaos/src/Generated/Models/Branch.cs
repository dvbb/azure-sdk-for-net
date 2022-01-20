// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents a branch in the step. </summary>
    public partial class Branch
    {
        /// <summary> Initializes a new instance of Branch. </summary>
        /// <param name="name"> String of the branch name. </param>
        /// <param name="actions"> List of actions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="actions"/> is null. </exception>
        public Branch(string name, IEnumerable<Action> actions)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (actions == null)
            {
                throw new ArgumentNullException(nameof(actions));
            }

            Name = name;
            Actions = actions.ToList();
        }

        /// <summary> Initializes a new instance of Branch. </summary>
        /// <param name="name"> String of the branch name. </param>
        /// <param name="actions"> List of actions. </param>
        internal Branch(string name, IList<Action> actions)
        {
            Name = name;
            Actions = actions;
        }

        /// <summary> String of the branch name. </summary>
        public string Name { get; set; }
        /// <summary> List of actions. </summary>
        public IList<Action> Actions { get; }
    }
}
