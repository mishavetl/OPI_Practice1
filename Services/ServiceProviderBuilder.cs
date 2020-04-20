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
        private TextReader InputStream { get; set; }
        private TextWriter OutputStream { get; set; }

        public static IInitialServiceProviderBuilder construct() {
            return new ServiceProviderBuilder();
        }

        public ServiceProvider Build()
        {
            return new ServiceCollection()
                .AddSingleton<Menu, ConsoleMenu>()
                .AddSingleton<SharedMemoryRepository, SharedMemoryRepository>()
                .AddSingleton<TaskManager, TaskManager>()
                .AddSingleton<IOutputProvider, StreamOutputProvider>(streamOutput =>
                                                                    new StreamOutputProvider(OutputStream))
                .AddSingleton<IInputProvider, StreamInputProvider>(streamInput =>
                                                                    new StreamInputProvider(InputStream))
                .AddSingleton<InputMatrixTaskExecutor, InputMatrixTaskExecutor>()
                .AddSingleton<OutputMatrixTaskExecutor, OutputMatrixTaskExecutor>()
                .BuildServiceProvider();
        }

        public IServiceProviderBuilderWithInputStream SetInputStream(TextReader streamReader)
        {
            InputStream = streamReader;
            return this;
        }
        
        public IPopulatedServiceProviderBuilder SetOutputStream(TextWriter streamWriter)
        {
            OutputStream = streamWriter;
            return this;
        }
    }
}