using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PathTracer;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddLogging(config =>
            {
                config.AddConsole();
                config.SetMinimumLevel(LogLevel.Debug);
            })
            .AddTransient<Renderer>()
            .BuildServiceProvider();

        var renderer = serviceProvider.GetRequiredService<Renderer>();
        renderer.Render();
    }
}
