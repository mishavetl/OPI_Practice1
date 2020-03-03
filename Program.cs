using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using OPI_Practice1.Menus;
using OPI_Practice1.SharedMemory;
using OPI_Practice1.Tasks;
using OPI_Practice1.UI;
using OPI_Practice1.Services;

namespace OPI_Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceProviderBuilder()
                .SetInputStream(new StreamReader(Console.OpenStandardInput()))
                .SetOutputStream(new StreamWriter(Console.OpenStandardOutput()))
                .Build();
            serviceProvider.GetService<Menu>().StartLoop();
        }
    }
}