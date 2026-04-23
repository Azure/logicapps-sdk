// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Extension methods for registering <see cref="IWorkflowProvider"/> implementations with dependency injection.
    /// </summary>
    public static class WorkflowProviderExtensions
    {
        /// <summary>
        /// Registers a workflow provider of type <typeparamref name="T"/> with the service collection.
        /// </summary>
        /// <typeparam name="T">The workflow provider type implementing <see cref="IWorkflowProvider"/>.</typeparam>
        /// <param name="services">The service collection.</param>
        /// <returns>The service collection for chaining.</returns>
        public static IServiceCollection AddWorkflowProvider<T>(this IServiceCollection services) where T : class, IWorkflowProvider
        {
            services.AddSingleton<IWorkflowProvider, T>();
            return services;
        }

        /// <summary>
        /// Scans the specified assembly for all types implementing <see cref="IWorkflowProvider"/>
        /// and registers each as a singleton.
        /// </summary>
        /// <param name="services">The service collection.</param>
        /// <param name="assembly">The assembly to scan for workflow providers.</param>
        /// <returns>The service collection for chaining.</returns>
        public static IServiceCollection AddWorkflowProviders(this IServiceCollection services, Assembly assembly)
        {
            if (assembly == null)
            {
                throw new ArgumentNullException(nameof(assembly));
            }

            var providerTypes = assembly.GetTypes()
                .Where(t => typeof(IWorkflowProvider).IsAssignableFrom(t)
                    && t.IsClass
                    && !t.IsAbstract);

            foreach (var providerType in providerTypes)
            {
                services.AddSingleton(typeof(IWorkflowProvider), providerType);
            }

            return services;
        }
    }
}
