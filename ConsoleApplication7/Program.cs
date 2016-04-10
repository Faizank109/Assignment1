using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    delegate void del();
    class Program
    {



        class student
        {
            public void test()
            {
                Console.WriteLine("iam in student class ");
            }
            static void Main(String[] args)
            {
                student obj = new student();
                del delll = new del(obj.test);
                delll();
                
                Console.Read();

            }

        }

    }
}