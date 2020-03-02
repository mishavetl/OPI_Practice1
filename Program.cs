using System;
using Microsoft.Extensions.DependencyInjection;
using OPI_Practice1.Menus;
using OPI_Practice1.SharedMemory;
using OPI_Practice1.Tasks;
using OPI_Practice1.UI;

namespace OPI_Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceProviderBuilder().Build();
            serviceProvider.GetService<Menu>().StartLoop();
        }
    }
}