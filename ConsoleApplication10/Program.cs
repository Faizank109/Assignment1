using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "faizan khalid";
            foreach (char c in name)
            {
                Console.WriteLine(c);
            }
            Console.Read();
        }
    }
}