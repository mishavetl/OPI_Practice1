using System.IO;
using Microsoft.Extensions.DependencyInjection;
using OPI_Practice1.Menus;
using OPI_Practice1.SharedMemory;
using OPI_Practice1.Tasks;
using OPI_Practice1.UI;

namespace OPI_Practice1.Services
{
    public class ServiceProviderBuilder : IInitialServiceProviderBuilder, IServiceProviderBuilderWithInputStream, IPopulatedServiceProviderBuilder
    {
        private StreamReader InputStream { get; set; }
        private StreamWriter OutputStream { get; set; }

        public ServiceProvider Build()
        {
            return new ServiceCollection()
                .AddSingleton<Menu, ConsoleMenu>()
                .AddSingleton<SharedMemoryProvider, SharedMemoryProvider>()
                .AddSingleton<TaskManager, TaskManager>()
                .AddSingleton<IOutputProvider, StreamOutputProvider>(streamOutput =>
                                                                    new StreamOutputProvider(OutputStream))
                .AddSingleton<IInputProvider, StreamInputProvider>(streamInput =>
                                                                    new StreamInputProvider(InputStream))
                .BuildServiceProvider();
        }

        public IServiceProviderBuilderWithInputStream SetInputStream(StreamReader streamReader)
        {
            InputStream = streamReader;
            return this;
        }
        
        public IPopulatedServiceProviderBuilder SetOutputStream(StreamWriter streamWriter)
        {
            OutputStream = streamWriter;
            return this;
        }
    }
}