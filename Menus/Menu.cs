using OPI_Practice1.Tasks;
using OPI_Practice1.UI;

namespace OPI_Practice1.Menus
{
    public abstract class Menu
    {
        protected TaskManager Tasks { get; }

        protected IInputProvider Input { get; }
        
        protected IOutputProvider Output { get; }

        protected Menu(TaskManager tasks, IInputProvider input, IOutputProvider output)
        {
            Tasks = tasks;
            Input = input;
            Output = output;
        }

        public abstract void StartLoop();
    }
}