using OPI_Practice1.SharedMemory;

namespace OPI_Practice1.UI
{
    public interface IInputProvider
    {
        string GetString();
        int GetN();
        int GetM();
        Matrix GetMatrix(int n, int m);
    }
}