// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IServiceCollection.cs" company="https://github.com/RichardPreziosi/ElixirEngine">
//     Licensed under the MIT License. See the LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace ElixirEngine
{
    /// <summary>
    ///     Represents a collection of services.
    /// </summary>
    public interface IServiceCollection
    {
        /// <summary>
        ///     Registers a singleton service of the provided type with an implementation of the provided type.
        /// </summary>
        /// <param name="serviceType">The type of the service to register.</param>
        /// <param name="implementationType">The implementation type of the service.</param>
        void RegisterSingleton(Type serviceType, Type implementationType);

        /// <summary>
        ///     Registers a singleton service of the provided type using the provided factory.
        /// </summary>
        /// <param name="serviceType">The type of the service to register.</param>
        /// <param name="implementationFactory">The factory that creates the service.</param>
        void RegisterSingleton(Type serviceType, Func<IServiceProvider, object> implementationFactory);

        /// <summary>
        ///     Registers a singleton service of the specified type with an implementation of the specified type.
        /// </summary>
        /// <typeparam name="TService">The type of the service to register.</typeparam>
        /// <typeparam name="TImplementation">The type of the implementation to use.</typeparam>
        void RegisterSingleton<TService, TImplementation>()
            where TService : class where TImplementation : class, TService;

        /// <summary>
        ///     Registers a singleton service of the provided type.
        /// </summary>
        /// <param name="serviceType">The type of the service to register.</param>
        void RegisterSingleton(Type serviceType);

        /// <summary>
        ///     Registers a singleton service of the specified type.
        /// </summary>
        /// <typeparam name="TService">The type of the service to register.</typeparam>
        void RegisterSingleton<TService>()
            where TService : class;

        /// <summary>
        ///     Registers a singleton service of the specified type using the provided factory.
        /// </summary>
        /// <param name="implementationFactory">The factory that creates the service.</param>
        /// <typeparam name="TService">The type of the service to register.</typeparam>
        void RegisterSingleton<TService>(Func<IServiceProvider, TService> implementationFactory)
            where TService : class;

        /// <summary>
        ///     Registers a singleton service of the specified type with an implementation of the specified type using the provided
        ///     factory.
        /// </summary>
        /// <param name="implementationFactory">The factory that creates the service.</param>
        /// <typeparam name="TService">The type of the service to register.</typeparam>
        /// <typeparam name="TImplementation">The type of the implementation to use.</typeparam>
        void RegisterSingleton<TService, TImplementation>(Func<IServiceProvider, TImplementation> implementationFactory)
            where TService : class where TImplementation : class, TService;

        /// <summary>
        ///     Registers a singleton service of the provided type with the provided instance.
        /// </summary>
        /// <param name="serviceType">The type of the service to register.</param>
        /// <param name="implementationInstance">The instance of the service.</param>
        void RegisterSingleton(Type serviceType, object implementationInstance);

        /// <summary>
        ///     Registers a singleton service of the specified type with the provided instance.
        /// </summary>
        /// <typeparam name="TService">The type of the service to register.</typeparam>
        /// <param name="implementationInstance">The instance of the service.</param>
        void RegisterSingleton<TService>(TService implementationInstance)
            where TService : class;
    }
}