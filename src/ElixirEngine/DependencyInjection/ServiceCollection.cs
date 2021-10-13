using System;
using Microsoft.Extensions.DependencyInjection;

namespace ElixirEngine
{
    using MicrosoftServiceCollection = Microsoft.Extensions.DependencyInjection.ServiceCollection;

    /// <inheritdoc cref="IServiceCollection" />
    internal sealed class ServiceCollection : MicrosoftServiceCollection, IServiceCollection
    {
        /// <inheritdoc />
        public void RegisterSingleton(Type serviceType, Type implementationType)
        {
            this.AddSingleton(serviceType, implementationType);
        }

        /// <inheritdoc />
        public void RegisterSingleton(Type serviceType, Func<IServiceProvider, object> implementationFactory)
        {
            this.AddSingleton(serviceType, implementationFactory);
        }

        /// <inheritdoc />
        public void RegisterSingleton<TService, TImplementation>()
            where TService : class where TImplementation : class, TService
        {
            this.AddSingleton<TService, TImplementation>();
        }

        /// <inheritdoc />
        public void RegisterSingleton(Type serviceType)
        {
            this.AddSingleton(serviceType);
        }

        /// <inheritdoc />
        public void RegisterSingleton<TService>()
            where TService : class
        {
            this.AddSingleton<TService>();
        }

        /// <inheritdoc />
        public void RegisterSingleton<TService>(Func<IServiceProvider, TService> implementationFactory)
            where TService : class
        {
            this.AddSingleton(implementationFactory);
        }

        /// <inheritdoc />
        public void RegisterSingleton<TService, TImplementation>(
            Func<IServiceProvider, TImplementation> implementationFactory)
            where TService : class where TImplementation : class, TService
        {
            this.AddSingleton<TService, TImplementation>(implementationFactory);
        }

        /// <inheritdoc />
        public void RegisterSingleton(Type serviceType, object implementationInstance)
        {
            this.AddSingleton(serviceType, implementationInstance);
        }

        /// <inheritdoc />
        public void RegisterSingleton<TService>(TService implementationInstance)
            where TService : class
        {
            this.AddSingleton(implementationInstance);
        }
    }
}