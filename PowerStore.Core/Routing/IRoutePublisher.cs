﻿using Microsoft.AspNetCore.Routing;

namespace PowerStore.Core.Routing
{
    /// <summary>
    /// Represents route publisher
    /// </summary>
    public interface IRoutePublisher
    {
        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="routeBuilder">End point Route builder</param>
        void RegisterRoutes(IEndpointRouteBuilder routeBuilder);
    }
}
