using System;

namespace Nov102023
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine("This is my first line.\nThis is my second line");
            //Console.WriteLine(@"File Path = D:\Projects\project1");

            int num1 = 50;int num2 = 10;bool t = true;bool f = false;            
            int res = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, res);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} % {1} = {2}", num1, num2, num1 % num2);

            Console.WriteLine("{0} == {1} is {2}", num1, num2, num1 == num2);
            Console.WriteLine("{0} != {1} is {2}", num1, num2, num1 != num2);
            Console.WriteLine("{0} > {1} is {2}", num1, num2, num1 > num2);
            Console.WriteLine("{0} >= {1} is {2}", num1, num2, num1 >= num2);
            Console.WriteLine("{0} < {1} is {2}", num1, num2, num1 < num2);
            Console.WriteLine("{0} <= {1} is {2}", num1, num2, num1 <= num2);

            Console.WriteLine("{0} && {1} = {2}", t, t, t && t);
            Console.WriteLine("{0} && {1} = {2}", t, f, t && f);
            Console.WriteLine("{0} && {1} = {2}", f, t, f && t);
            Console.WriteLine("{0} && {1} = {2}", f, f, f && f);
            Console.WriteLine("{0} || {1} = {2}", t, t, t || t);
            Console.WriteLine("{0} || {1} = {2}", t, f, t || f);
            Console.WriteLine("{0} || {1} = {2}", f, t, f || t);
            Console.WriteLine("{0} || {1} = {2}", f, f, f || f);
            // Ternary Operator '?:'
            int number = 101;
            //if(number%2 == 0)
            //{
            //    Console.WriteLine("{0} is Even",number);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is Odd",number);
            //}
            string message = number % 2 == 0 ? number + " is Even": number + " is Odd";
            Console.WriteLine(message);
            // Nullable value type '<DataType>?'
            bool? isTeacher = null;
            if(isTeacher == true)
            {
                Console.WriteLine("User is a Teacher");
            }
            else if(isTeacher == false)
            {
                Console.WriteLine("User is not a Teacher");
            } 
            else
            {
                Console.WriteLine("User did'nt answer the question");
            }
            // Null Coalescing Operator '??'
            int? TicketOnSale = null;
            int TicketAvailabe;
            //if(TicketOnSale == null)
            //{
            //    TicketAvailabe = 0;
            //}
            //else
            //{
            //    TicketAvailabe = (int)TicketOnSale;
            //}
            TicketAvailabe = TicketOnSale ?? 0;
            Console.WriteLine("Available Tickets = {0}", TicketAvailabe);

            int? datafromdb = 75;
            int data = datafromdb ?? 1;
            Console.WriteLine("The Square of {0} is {1}", data, data * data);
        }
    }
}
