using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {


        class Shape
        {
            public void setWidth(int w)
            {
                width = w;
            }
            public void setHeight(int h)
            {
                height = h;
            }
            protected int width;
            protected int height;
        }

        // Derived class
        class Rectangle : Shape
        {
            public int getArea()
            {
                return (width * height);
            }
        }

        class RectangleTester
        {
            static void Main(string[] args)
            {
                Rectangle Rect = new Rectangle();

                Rect.setWidth(10);
                Rect.setHeight(16);

                // Prints the area of the object
                Console.WriteLine("Total area: {0}", Rect.getArea());
                Console.ReadKey();

            }
        }
    }
}
    
