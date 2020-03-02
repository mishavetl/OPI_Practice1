using System.IO;
using Microsoft.Extensions.DependencyInjection;
using OPI_Practice1.Menus;
using OPI_Practice1.SharedMemory;
using OPI_Practice1.Tasks;
using OPI_Practice1.UI;

namespace OPI_Practice1
{
    public class ServiceProviderBuilder
    {
        public StreamReader InputStream { get; set; }

        public ServiceProvider Build()
        {
            return new ServiceCollection()
                .AddSingleton<Menu, ConsoleMenu>()
                .AddSingleton<SharedMemoryProvider, SharedMemoryProvider>()
                .AddSingleton<TaskManager, TaskManager>()
                .AddSingleton<IOutputProvider, StreamOutputProvider>()
                .AddSingleton<IInputProvider, StreamInputProvider>()
                .BuildServiceProvider();
        }

        public ServiceProviderBuilder SetInputStream(StreamReader streamReader)
        {
            InputStream = streamReader;
            return this;
        }
    }
}