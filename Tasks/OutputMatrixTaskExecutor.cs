using OPI_Practice1.UI;

namespace OPI_Practice1.Tasks
{
    public class OutputMatrixTaskExecutor : ITaskExecutor
    {
        private IInputProvider Input { get; }
        
        private IOutputProvider Output { get; }
        
        public OutputMatrixTaskExecutor(IInputProvider input, IOutputProvider output)
        {
            Input = input;
            Output = output;
        }
        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }
}