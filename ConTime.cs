using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTime
{
    public class ConTime
    {
        private List<Task> tasks;
        public ConTime()
        {
            this.tasks = new List<Task>();
        }

        public void menuOptions()
        {
            Console.WriteLine("\n1) Add Task");
            Console.WriteLine("2) List all Tasks");
            Console.WriteLine("3) Calculate time worked");
            Console.WriteLine("4) Quit");
            // TODO: Add user error checking
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    addTask();
                    break;
                case 2:
                    //Console.WriteLine("Feature not implemented yet.");
                    //menuOptions();
                    for(int i = 0; i < tasks.Count; i++)
                    {
                        tasks[i].printTask();
                    }
                    break;
                case 3:
                    Console.WriteLine("Feature not implemented yet.");
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid input, try again.");
                    break;

            }
            menuOptions();
        }

        public void addTask()
        {
            Console.WriteLine("Task Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Time worked on task:");
            double timeWorked = Convert.ToDouble(Console.ReadLine());
            Task task = new Task(name, timeWorked);
            task.addContracts();
            tasks.Add(task);
        }
    }
}
