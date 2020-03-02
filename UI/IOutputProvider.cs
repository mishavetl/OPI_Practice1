using System;
using OPI_Practice1.SharedMemory;
using OPI_Practice1.Tasks;

namespace OPI_Practice1.UI
{
    public interface IOutputProvider
    {
        void OutputString(string output);
        void OutputAnswer(Answer answer);
        void OutputError(ApplicationException exception);
        void OutputMatrix(Matrix matrix);
    }
}