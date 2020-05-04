namespace OPI_Practice1.Tasks
{
    public class TaskManager
    {
        public InputMatrixTaskExecutor InputMatrix { get; }
        public OutputMatrixTaskExecutor OutputMatrix { get; }

        public MinSumOfMainDiagonalElementsTaskExecutor MinSumOfMainDiagonalElements { get; }
        public MaxSumOfMainDiagonalElementsTaskExecutor MaxSumOfMainDiagonalElements { get; }

        public TaskManager(
            InputMatrixTaskExecutor inputMatrixTaskExecutor,
            OutputMatrixTaskExecutor outputMatrixTaskExecutor,
            MinSumOfMainDiagonalElementsTaskExecutor minSumOfMainDiagonalElementsTaskExecutor,
            MaxSumOfMainDiagonalElementsTaskExecutor maxSumOfMainDiagonalElementsTaskExecutor)
        {
            InputMatrix = inputMatrixTaskExecutor;
            OutputMatrix = outputMatrixTaskExecutor;
            MinSumOfMainDiagonalElements = minSumOfMainDiagonalElementsTaskExecutor;
            MaxSumOfMainDiagonalElements = maxSumOfMainDiagonalElementsTaskExecutor;
        }
    }
}