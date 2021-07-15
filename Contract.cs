using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTime
{
    public class Contract
    {
        private string name { get; set; }
        private double percentage { get; set; }
        public Contract(string name, double percentage)
        {
            this.name = name;
            this.percentage = percentage;
        }
        public void printContract()
        {
            Console.WriteLine($"{name} = {percentage}%");
        }

        public void editContract()
        {
            Console.WriteLine("Name of Contract: ");
            name = Console.ReadLine();
            Console.WriteLine("Percentage: ");
            percentage = Convert.ToDouble(Console.ReadLine());
        }
    }
}
