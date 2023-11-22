using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov212023
{
    internal class Program
    {
        static void Main()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            //for(int i = 0;i<cars.Length;i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            foreach (string car in cars) 
            {
                Console.WriteLine(car);
            }

            Program p = new Program();
            p.fun1();
            p.fun2("Ali Baba");
            //string message = p.fun3();
            //Console.WriteLine(message);
            Console.WriteLine(p.fun3());

            int num = 12;

            Console.WriteLine(p.fun4(num));
            Program.fun5();
            
        }

        public void fun1 ()
        {
            Console.WriteLine ("This is Funtion # 1");
        }
        public void fun2 (string name)
        {
            Console.WriteLine ("Dear {0}, How are you ?",name);
        }

        public string fun3 ()
        {
            return "This is fun3";
        }

        public int fun4 (int number)
        {
            return number*number;
        }

        public static void fun5 ()
        {
            Console.WriteLine("This is function number 5");
        }
    }
}
