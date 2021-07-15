using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTime
{
    public class Task
    {
        public string name { get; set; }
        public double timeWorked { get; set; }
        public List<Contract> contracts;
        public Task() { }
        public Task(string name, double timeWorked)
        {
            this.name = name;
            this.timeWorked = timeWorked;
            this.contracts = new List<Contract>();
        }

        public void printTask()
        {
            Console.WriteLine($"\nName of Task: {name}");
            Console.WriteLine($"Time worked: {timeWorked}");
            Console.WriteLine("-------------------------\n");
            for(int i = 0; i < contracts.Count; i++)
            {
                contracts[i].printContract();
            } 
        }

        public void editTask()
        {
            Console.WriteLine("Task Name:");
            name = Console.ReadLine();
            Console.WriteLine("Time worked on task:");
            timeWorked = Convert.ToDouble(Console.ReadLine());
        }

        public void addContracts()
        {
            double total = 0.0;
            while(total < 100)
            {
                Console.WriteLine("Contract name: ");
                string contractName = Console.ReadLine();
                Console.WriteLine("Percentage: ");
                double percentage = Convert.ToDouble(Console.ReadLine());

                if(total + percentage > 100)
                {
                    Console.WriteLine($"Error: above 100 percent. {100 - total}% left. Try again.");
                }
                else
                {
                    total += percentage;
                    contracts.Add(new Contract(contractName, percentage));
                }
            }
        }
    }
}
