using System;
using System.Collections;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace ElixirEngine
{
    /// <summary>
    ///     Provides helper and extension methods for working with service provider implementations.
    /// </summary>
    public static class ServiceProviderExtensions
    {
        /// <summary>
        ///     Resolves a service of the specified type from the provided service provider.
        /// </summary>
        /// <param name="serviceProvider">The service provider to resolve the service object from.</param>
        /// <typeparam name="TService">The type of service object to get.</typeparam>
        /// <returns>A service object of the specified type, or null if there is no such registered service.</returns>
        public static TService Resolve<TService>(this IServiceProvider serviceProvider)
        where TService: notnull
        {
            var serviceType = typeof(TService);

            if (typeof(IEnumerable).GetTypeInfo().IsAssignableFrom(serviceType))
                return (TService) serviceProvider.GetServices(serviceType.GetGenericArguments()[0]);

            return serviceProvider.GetRequiredService<TService>();
        }

        /// <summary>
        ///     Resolves a service of the specified type from the provided service provider.
        /// </summary>
        /// <param name="serviceProvider">The service provider to resolve the service object from.</param>
        /// <param name="serviceType">An object that specifies the type of service object to get.</param>
        /// <returns>A service object of the specified type, or null if there is no such registered service.</returns>
        public static object Resolve(this IServiceProvider serviceProvider, Type serviceType)
        {
            return typeof(IEnumerable).GetTypeInfo().IsAssignableFrom(serviceType)
                ? serviceProvider.GetServices(serviceType.GetGenericArguments()[0])
                : serviceProvider.GetRequiredService(serviceType);
        }
    }
}