using OPI_Practice1.SharedMemory;
using OPI_Practice1.UI;

namespace OPI_Practice1.Tasks
{
    public class InputMatrixTaskExecutor : ITaskExecutor
    {
        private IInputProvider Input { get; }
        
        private IOutputProvider Output { get; }

        private SharedMemoryRepository SharedMemory;
        
        public InputMatrixTaskExecutor(IInputProvider input, IOutputProvider output, SharedMemoryRepository sharedMemory)
        {
            Input = input;
            Output = output;
            SharedMemory = sharedMemory;
        }
        public void Execute()
        {
            Output.OutputString("n = ");
            int n = Input.GetN();
            Output.OutputString("m = ");
            int m = Input.GetM();
            Output.OutputString(
                "Input matrix in form of ("
                + "a11 a12 a13\n"
                + "a21 a22 a23\n"
                + "a31 a32 a33\n"
                + ")\n ");
            SharedMemory.Matrix = Input.GetMatrix(n, m);
        }
    }
}