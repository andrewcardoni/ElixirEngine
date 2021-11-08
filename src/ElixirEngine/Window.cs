using System;
using ISilkWindow = Silk.NET.Windowing.IWindow;

namespace ElixirEngine
{
    /// <inheritdoc cref="IWindow" />
    // ReSharper disable once ClassNeverInstantiated.Global
    internal sealed class Window : IWindow, IDisposable
    {
        /// <summary>
        ///     The silk window.
        /// </summary>
        private readonly ISilkWindow _silkWindow;

        /// <summary>
        ///     Initializes a new instance of the window class.
        /// </summary>
        /// <param name="silkWindow">The silk window.</param>
        public Window(ISilkWindow silkWindow)
        {
            _silkWindow = silkWindow;
            Handle = _silkWindow.Handle;

            _silkWindow.Closing += OnSilkWindowClosing;
        }

        /// <inheritdoc />
        public void Dispose()
        {
            _silkWindow.Closing -= OnSilkWindowClosing;
        }

        /// <inheritdoc />
        public IntPtr Handle { get; }

        /// <inheritdoc />
        public bool IsClosing { get; private set; }

        /// <inheritdoc />
        public string Title
        {
            get => _silkWindow.Title;
            set => _silkWindow.Title = value;
        }

        /// <summary>
        ///     Handles the silk window's closing event.
        /// </summary>
        private void OnSilkWindowClosing()
        {
            IsClosing = true;
        }
    }
}