using System;
using OPI_Practice1.SharedMemory;
using OPI_Practice1.Tasks;

namespace OPI_Practice1.UI
{
    public class StreamOutputProvider : IOutputProvider
    {
        public void OutputString(string output)
        {
            Console.WriteLine(output);
        }

        public void OutputAnswer(Answer answer)
        {
            throw new NotImplementedException();
        }

        public void OutputError(ApplicationException exception)
        {
            throw new NotImplementedException();
        }

        public void OutputMatrix(Matrix matrix)
        {
            throw new NotImplementedException();
        }
    }
}