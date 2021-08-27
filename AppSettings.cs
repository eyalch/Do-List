using System.IO;
using Microsoft.Extensions.Configuration;

namespace DoList
{
    public class AppSettings
    {
        public string ConnectionString { get; set; }

        public AppSettings()
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            // .AddEnvironmentVariables();

            var configuration = builder.Build();

            ConnectionString = configuration.GetConnectionString("default");
        }
    }
}
