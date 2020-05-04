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
            Tasks.InputMatrix.Execute();

            while (true)
            {
                Output.OutputString(">> ");

                string inputString = Input.GetString();
                if (inputString == "input")
                {
                    Tasks.InputMatrix.Execute();
                }
                else if (inputString == "max sum")
                {
                    Tasks.MaxSumOfMainDiagonalElements.Execute();
                }
                else if (inputString == "min sum")
                {
                    Tasks.MinSumOfMainDiagonalElements.Execute();
                }
                else if (inputString == "output")
                {
                    Tasks.OutputMatrix.Execute();
                }
                else if (inputString == "exit")
                {
                    break;
                }
                else
                {
                    Output.OutputString("Invalid cmd");
                }
                Output.OutputString("\n");
            }
        }
    }
}