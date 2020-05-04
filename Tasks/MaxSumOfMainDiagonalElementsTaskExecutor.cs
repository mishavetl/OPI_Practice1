using OPI_Practice1.SharedMemory;
using OPI_Practice1.UI;
using System;

namespace OPI_Practice1.Tasks
{
    public class MaxSumOfMainDiagonalElementsTaskExecutor : ITaskExecutor
    {
        private IInputProvider Input { get; }
        
        private IOutputProvider Output { get; }

        private SharedMemoryRepository SharedMemory;
        
        public MaxSumOfMainDiagonalElementsTaskExecutor(IInputProvider input, IOutputProvider output, SharedMemoryRepository sharedMemory)
        {
            Input = input;
            Output = output;
            SharedMemory = sharedMemory;
        }
        public void Execute()
        {
            int maxSum = int.MinValue;
            for (int i = 1; i < SharedMemory.Matrix.M - 1; ++i)
            {
                int sum1 = 0;
                int sum2 = 0;
                for (int j = 0, k = i; Math.Max(k, j) < Math.Min(SharedMemory.Matrix.M, SharedMemory.Matrix.N); ++j, ++k)
                {
                    sum1 += SharedMemory.Matrix.Get(k, j);
                    sum2 += SharedMemory.Matrix.Get(j, k);
                }
                maxSum = Math.Max(Math.Max(maxSum, sum1), sum2);
            }
            Output.OutputString(maxSum.ToString());
        }
    }
}