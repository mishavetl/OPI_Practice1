using OPI_Practice1.SharedMemory;
using OPI_Practice1.UI;

namespace OPI_Practice1.Tasks
{
    public class OutputMatrixTaskExecutor : ITaskExecutor
    {
        private IOutputProvider Output { get; }
        private SharedMemoryRepository SharedMemory { get; }

        public OutputMatrixTaskExecutor(IOutputProvider output, SharedMemoryRepository sharedMemory)
        {
            Output = output;
            SharedMemory = sharedMemory;
        }

        public void Execute()
        {
            Output.OutputMatrix(SharedMemory.Matrix);
        }
    }
}