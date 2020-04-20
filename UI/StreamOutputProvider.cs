using System;
using System.IO;
using OPI_Practice1.SharedMemory;
using OPI_Practice1.Tasks;

namespace OPI_Practice1.UI
{
    public class StreamOutputProvider : IOutputProvider
    {
        private TextWriter Writer { get; }
        
        public StreamOutputProvider(TextWriter writer)
        {
            Writer = writer;
        }
        
        public void OutputString(string output)
        {
        	Writer.Write(output);
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
            for (int i = 0; i < matrix.N; ++i)
            {
                for (int j = 0; j < matrix.M; ++j)
                {
                    Writer.Write(matrix.Get(i, j) + " ");
                }
                Writer.Write("\n");
            }
        }
    }
}