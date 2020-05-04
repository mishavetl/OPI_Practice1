using OPI_Practice1.SharedMemory;
using OPI_Practice1.UI;
using System;

namespace OPI_Practice1.Tasks
{
    public class MinSumOfMainDiagonalElementsTaskExecutor : ITaskExecutor
    {
        private IInputProvider Input { get; }
        
        private IOutputProvider Output { get; }

        private SharedMemoryRepository SharedMemory;
        
        public MinSumOfMainDiagonalElementsTaskExecutor(IInputProvider input, IOutputProvider output, SharedMemoryRepository sharedMemory)
        {
            Input = input;
            Output = output;
            SharedMemory = sharedMemory;
        }
        public void Execute()
        {
            int minSum = int.MaxValue;
            for (int i = SharedMemory.Matrix.M - 2; i > 0; --i)
            {
                int sum1 = 0;
                int sum2 = 0;
                for (int j = 0, k = i; j < SharedMemory.Matrix.N && k >= 0; ++j, --k)
                {
                    sum1 += SharedMemory.Matrix.Get(k, j);
                    sum2 += SharedMemory.Matrix.Get(j, k);
                }
                minSum = Math.Min(Math.Min(minSum, sum1), sum2);
            }
            Output.OutputString(minSum.ToString());
        }
    }
}