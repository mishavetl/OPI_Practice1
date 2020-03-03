using System.IO;

namespace OPI_Practice1.Services
{
	public interface IInitialServiceProviderBuilder
    {
    	IServiceProviderBuilderWithInputStream SetInputStream(StreamReader streamReader);
    }
}