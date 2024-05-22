using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ConsoleApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = [];

            services.AddLogging();

            IServiceProvider provider = services.BuildServiceProvider();

            ILogger<Program> logger = provider.GetRequiredService<ILogger<Program>>();

            LogSomething(logger);

            Console.WriteLine("Hello, World!");
        }

        [LoggerMessage(Level = LogLevel.Information, Message = "Something")]
        private static partial void LogSomething(ILogger logger);
    }
}
