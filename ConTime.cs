using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTime
{
    public class ConTime
    {
        public List<Task> Tasks = new List<Task>();

        public double readDouble()
        {
            string userInput;
            userInput = Console.ReadLine();
            return Convert.ToDouble(userInput);
        }  
    }
}
