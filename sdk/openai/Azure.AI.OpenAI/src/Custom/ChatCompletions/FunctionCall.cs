// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

namespace Azure.AI.OpenAI;

public partial class FunctionCall
{
    // CUSTOM CODE NOTE:
    //   These changes facilitate the reuse of this class in streaming scenarios.

    /// <summary> Initializes a new instance of FunctionCall. </summary>
    /// <param name="name"> The name of the function to call. </param>
    /// <param name="arguments">
    /// The arguments to call the function with, as generated by the model in JSON format.
    /// Note that the model does not always generate valid JSON, and may hallucinate parameters
    /// not defined by your function schema. Validate the arguments in your code before calling
    /// your function.
    /// </param>
    public FunctionCall(string name, string arguments)
    {
        // Custom code note: we suppress null checks for deserialization reuse in streaming scenarios
        // Argument.AssertNotNull(name, nameof(name));
        // Argument.AssertNotNull(arguments, nameof(arguments));

        Name = name;
        Arguments = arguments;
    }
}
