using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ProductNamespace.Api
{
    /// <summary>
    /// Represents the Web API.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class Program
    {
        /// <summary>
        /// Main entry point for the application.
        /// </summary>
        /// <param name="args">
        /// Optional command-line arguments.
        /// </param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates a new host builder for the API.
        /// </summary>
        /// <param name="args">
        /// Optional command-line arguments.
        /// </param>
        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}