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
            var serviceProvider = ServiceProviderBuilder.construct()
                .SetInputStream(Console.In)
                .SetOutputStream(Console.Out)
                .Build();
            
            serviceProvider.GetService<Menu>().StartLoop();
        }
    }
}