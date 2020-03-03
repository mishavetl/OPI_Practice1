using System.IO;

namespace OPI_Practice1.Services
{
    public interface IServiceProviderBuilderWithInputStream
    {
        IPopulatedServiceProviderBuilder SetOutputStream(StreamWriter streamWriter);
    }
}