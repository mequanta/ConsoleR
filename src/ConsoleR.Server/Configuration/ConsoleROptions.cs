namespace ConsoleR.Server.Configuration
{
    /// <summary>
    /// Provides access to server configuration.
    /// </summary>
    public class ConsoleROptions
    {
        public ConsoleROptions()
        {
        }

        public BackendOptions Backends { get; set; }
    }
}
