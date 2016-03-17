using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faizan
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int siblings;
            Console.WriteLine("Enter number of siblings :");
            DateTime[] dat = new DateTime[100];
            DateTime now = DateTime.Now;
            siblings = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=siblings; i++)
            {
                Console.WriteLine("Enter DOB of sibling"+i+" :");
                dat[i] = Convert.ToDateTime(Console.ReadLine());
            }
            for (int i = 1; i <=siblings; i++)
            {
                TimeSpan total = now.Subtract(dat[i]);
                int TotalDays = total.Days;
                int TotalYears = TotalDays / 365;
                int TotalMonths = (TotalDays % 365) / 30;
                int TotalDayss = (TotalDays % 365) % 30;
                Console.WriteLine("Age Of Sibling :"+i+" :"  +TotalYears+" Years"+ TotalMonths+ " Months"+TotalDayss+ "Days");

                Console.Beep();
                Console.Beep();
                
            }

            
            Console.ReadLine();
        }
    }
}
