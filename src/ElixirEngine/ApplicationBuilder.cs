using System;
using Microsoft.Extensions.DependencyInjection;
using Silk.NET.Windowing;
using ISilkWindow = Silk.NET.Windowing.IWindow;
using SilkWindow = Silk.NET.Windowing.Window;

namespace ElixirEngine
{
    /// <summary>
    ///     Represents an object to allow for the proper construction and initialization of an application.
    /// </summary>
    public sealed class ApplicationBuilder
    {
        /// <summary>
        ///     The service collection.
        /// </summary>
        private readonly ServiceCollection _serviceCollection;

        /// <summary>
        ///     The is application built.
        /// </summary>
        private bool _isApplicationBuilt;

        /// <summary>
        ///     The service provider.
        /// </summary>
        private IServiceProvider? _serviceProvider;

        /// <summary>
        ///     Initializes a new instance of the application builder class.
        /// </summary>
        public ApplicationBuilder()
        {
            _serviceCollection = new ServiceCollection();
        }

        /// <summary>
        ///     Run the given actions to initialize and return an application.
        /// </summary>
        /// <remarks>This can only be called once.</remarks>
        /// <returns>The initialized application.</returns>
        public IApplication Build()
        {
            _isApplicationBuilt = !_isApplicationBuilt
                ? true
                : throw new InvalidOperationException("Build can only be called once.");

            _serviceProvider = CreateServiceProvider();

            return InitializeAndGetApplication();

            IServiceProvider CreateServiceProvider()
            {
                _serviceCollection.RegisterSingleton<IApplication, Application>();
                _serviceCollection.RegisterSingleton(SilkWindow.Create(WindowOptions.Default));
                _serviceCollection.RegisterSingleton<IView>(f => f.GetRequiredService<ISilkWindow>());
                _serviceCollection.RegisterSingleton<IWindow, Window>();

                return _serviceCollection.BuildServiceProvider();
            }

            IApplication InitializeAndGetApplication()
            {
                return _serviceProvider.GetRequiredService<IApplication>();
            }
        }

        /// <summary>
        ///     Registers an action to provide services to a service collection.
        /// </summary>
        /// <param name="registerServicesAction">The action to be executed for service registration.</param>
        /// <returns>This instance.</returns>
        public ApplicationBuilder RegisterServices(Action<IServiceCollection> registerServicesAction)
        {
            registerServicesAction(_serviceCollection);
            return this;
        }
    }
}