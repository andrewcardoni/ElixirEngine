using System;

namespace ElixirEngine
{
    /// <summary>
    ///     Represents a view that makes up an application's user interface.
    /// </summary>
    public interface IWindow
    {
        /// <summary>
        ///     Gets the window's identifier within its windowing system.
        /// </summary>
        IntPtr Handle { get; }

        /// <summary>
        ///     Gets a value indicating whether the window is closing.
        /// </summary>
        bool IsClosing { get; }

        /// <summary>
        ///     Gets or sets the window's title.
        /// </summary>
        string Title { get; set; }
    }
}