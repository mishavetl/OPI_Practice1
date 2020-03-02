using OPI_Practice1.SharedMemory;
using OPI_Practice1.UI;

namespace OPI_Practice1.Tasks
{
    public class InputMatrixTaskExecutor : ITaskExecutor
    {
        private IInputProvider Input { get; }
        
        private IOutputProvider Output { get; }

        private SharedMemoryProvider SharedMemory;
        
        public InputMatrixTaskExecutor(IInputProvider input, IOutputProvider output, SharedMemoryProvider sharedMemory)
        {
            Input = input;
            Output = output;
            SharedMemory = sharedMemory;
        }
        public void Execute()
        {
            // SharedMemory.Matrix = Input.GetMatrix();
        }
    }
}