using System;
using Silk.NET.Windowing;
using ISilkWindow = Silk.NET.Windowing.IWindow;

namespace ElixirEngine
{
    /// <inheritdoc cref="IApplication" />
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Application : IApplication, IDisposable
    {
        /// <summary>
        ///     The silk window.
        /// </summary>
        private readonly ISilkWindow _silkWindow;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Application" /> class.
        /// </summary>
        /// <param name="silkWindow">The silk window.</param>
        public Application(ISilkWindow silkWindow)
        {
            _silkWindow = silkWindow;
        }

        /// <summary>
        ///     Runs the application and begins the game loop.
        /// </summary>
        public virtual void Run()
        {
            _silkWindow.Run();
        }

        /// <inheritdoc />
        public void Dispose()
        {
        }
    }
}