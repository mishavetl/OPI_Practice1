namespace OPI_Practice1.Tasks
{
    public class TaskManager
    {
        public InputMatrixTaskExecutor InputMatrix;
        public OutputMatrixTaskExecutor OutputMatrix;

        public TaskManager(
            InputMatrixTaskExecutor inputMatrixTaskExecutor,
            OutputMatrixTaskExecutor outputMatrixTaskExecutor)
        {
            InputMatrix = inputMatrixTaskExecutor;
            OutputMatrix = outputMatrixTaskExecutor;
        }
    }
}