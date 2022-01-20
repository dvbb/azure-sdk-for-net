// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> Input for testing route. </summary>
    public partial class TestRouteInput
    {
        /// <summary> Initializes a new instance of TestRouteInput. </summary>
        /// <param name="route"> Route properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="route"/> is null. </exception>
        public TestRouteInput(RouteProperties route)
        {
            if (route == null)
            {
                throw new ArgumentNullException(nameof(route));
            }

            Route = route;
        }

        /// <summary> Routing message. </summary>
        public RoutingMessage Message { get; set; }
        /// <summary> Route properties. </summary>
        public RouteProperties Route { get; }
        /// <summary> Routing Twin Reference. </summary>
        public RoutingTwin Twin { get; set; }
    }
}
