using System;
using System.Collections.Generic;

namespace ConTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string taskName;
            double hoursWorked; 
            double total = 0.0;

            List<string> chargeNumber = new List<string>();
            List<double> percentage = new List<double>();
            Console.WriteLine("**ConTime**");
            /* Brainstorming
             * - Make the Calculator into a class (
             * - Can store the information either in-memory or exported to a file
             * - First main feature, ask for how much time, then charge number with distribution,
             *   when it gets to 100% then calculate hours for each charge number
             *   */
            ConTime conTime = new ConTime();
            Console.WriteLine("Task name:");
            taskName = Console.ReadLine();
            Console.WriteLine("Time worked on task:");
            userInput = Console.ReadLine();
            hoursWorked = Convert.ToDouble(userInput);
            while(total < 1.0)
            {
                Console.WriteLine("Charge number name:");
                chargeNumber.Add(Console.ReadLine());
                Console.WriteLine("Percentage:");
                userInput = Console.ReadLine();

                percentage.Add(Convert.ToDouble(userInput));
                total += Convert.ToDouble(userInput);
            }

            Console.WriteLine($"Task name: {taskName}");
            Console.WriteLine($"Time worked: {hoursWorked}");
            for(int i = 0; i < chargeNumber.Count; i++)
            {
                Console.WriteLine($"Charge Number: {chargeNumber[i]} -- Hours: {percentage[i]*hoursWorked}");
            }

        }
    }
}
