using Microsoft.Extensions.Configuration;
using System;
using System.IO;


namespace ConsoleUI
{
    internal class Program
    {
        public static IConfiguration Configuration;
        static void Main(string[] args)


        {
            /*IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build(); 
            var configuration = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false).Build();
            */

            //    var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            //    Configuration = builder.Build();
            //    Console.WriteLine("Hello World!");
            //    Console.WriteLine("Hello Getting Started Group!");

            //    string connectionstring = Configuration.GetConnectionString("Default");
            //    Console.WriteLine($"Connection String : {connectionstring}");

            //    string otherInfo = Configuration.GetSection("OtherInfo").Value;
            //    Console.WriteLine($"Other Info: {otherInfo}");

            //    string demo1 = Configuration.GetSection("Demos").GetSection("Demo1").Value;
            //    Console.WriteLine($"Demo 1: { demo1 }");
            //
        }
    }
}
