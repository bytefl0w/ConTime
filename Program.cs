using System;
using System.Collections.Generic;

namespace ConTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* Welcome to ConTime *");
            /* Brainstorming
             * - Make the Calculator into a class (
             * - Can store the information either in-memory or exported to a file
             * - First main feature, ask for how much time, then charge number with distribution,
             *   when it gets to 100% then calculate hours for each charge number
             * - Ablity to save off information and import from file
             *   */
            ConTime conTime = new ConTime();
            conTime.menuOptions();

        }
    }
}
