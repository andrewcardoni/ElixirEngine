using ElixirEngine;

namespace HelloWorld
{
    /// <summary>
    ///     Represents the shell application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///     The main entry-point of the application.
        /// </summary>
        private static void Main()
        {
            new ApplicationBuilder().Build().Run();
        }
    }
}