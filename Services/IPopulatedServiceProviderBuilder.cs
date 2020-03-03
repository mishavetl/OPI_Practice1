using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace OPI_Practice1.Services
{
    public interface IPopulatedServiceProviderBuilder
    {
    	ServiceProvider Build();
    }
}