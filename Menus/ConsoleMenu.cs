using System;
using OPI_Practice1.Tasks;
using OPI_Practice1.UI;

namespace OPI_Practice1.Menus
{
    public class ConsoleMenu : Menu
    {
        public ConsoleMenu(TaskManager tasks, IInputProvider input, IOutputProvider output) : base(tasks, input, output)
        {
        }

        public override void StartLoop()
        {
            Output.OutputString("Hello world");
        }
    }
}