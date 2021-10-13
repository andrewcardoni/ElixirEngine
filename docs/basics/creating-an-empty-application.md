## Creating an Empty Application

Creating an empty application is rather easy. Simply derive a class from **Application** and call **Run()**.

*NOTE: **Application** implements **IDisposable** and derived classes should be disposed of appropriately.*

```csharp
using ElixirEngine;

/// <summary>
///     Represents the program.
/// </summary>
public class Program : Application
{
    /// <summary>
    ///     The main entry point into the application.
    /// </summary>
    private static void Main()
    {
        using (Program program = new Program())
        {
            program.Run();
        }
    }
}
```
