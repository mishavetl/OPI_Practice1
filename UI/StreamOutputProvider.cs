using System;
using System.IO;
using OPI_Practice1.SharedMemory;
using OPI_Practice1.Tasks;

namespace OPI_Practice1.UI
{
    public class StreamOutputProvider : IOutputProvider
    {
        private StreamWriter Writer { get; }
        
        public StreamOutputProvider(StreamWriter writer)
        {
            Writer = writer;
        }
        
        public void OutputString(string output)
        {
        	Writer.WriteLine(output);
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