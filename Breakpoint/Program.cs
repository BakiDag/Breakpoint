using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string breakpoint = string.Empty;

            string conditionWithExit = string.Empty;
            
            string condition = string.Empty;

            int changed = 0;

            
            Console.WriteLine("Simple Breakpoint");
            for (int i = 0; i <=5; i++)
            {
                breakpoint = i.ToString();
                Console.WriteLine(breakpoint);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            


            
            Console.Clear();
            Console.WriteLine("Breakpoint with Condition");
            for (int x = 0; x < 25; x++)
            {
                condition = x.ToString();
                Console.WriteLine(condition);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            


            Console.Clear();
            Console.WriteLine("Breakpoint with changed value");
            for (changed = 0; changed <= 5; changed++)
            {
                Console.WriteLine(changed+" Changed");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Breakpoint with condition with exit Code");
            for (int x = 0; x <= 25; x++)
            {
                conditionWithExit = x.ToString();
                Console.WriteLine(conditionWithExit);
            }


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
