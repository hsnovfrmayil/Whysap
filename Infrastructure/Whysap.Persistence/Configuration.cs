using System;
using Microsoft.Extensions.Configuration;

namespace Whysap.Persistence;

public class Configuration
{
    static public string ConnectionString()
    {
        //get
        //{
        ConfigurationManager configurationManager = new();
        configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/Whysap.API"));
        configurationManager.AddJsonFile("appsettings.json");

        return configurationManager.GetConnectionString("PostgreSQL");
        //}
    }
}

