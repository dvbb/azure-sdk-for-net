// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Diagnostics for an App Service Environment. </summary>
    public partial class HostingEnvironmentDiagnostics
    {
        /// <summary> Initializes a new instance of <see cref="HostingEnvironmentDiagnostics"/>. </summary>
        internal HostingEnvironmentDiagnostics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HostingEnvironmentDiagnostics"/>. </summary>
        /// <param name="name"> Name/identifier of the diagnostics. </param>
        /// <param name="diagnosticsOutput"> Diagnostics output. </param>
        internal HostingEnvironmentDiagnostics(string name, string diagnosticsOutput)
        {
            Name = name;
            DiagnosticsOutput = diagnosticsOutput;
        }

        /// <summary> Name/identifier of the diagnostics. </summary>
        public string Name { get; }
        /// <summary> Diagnostics output. </summary>
        public string DiagnosticsOutput { get; }
    }
}
