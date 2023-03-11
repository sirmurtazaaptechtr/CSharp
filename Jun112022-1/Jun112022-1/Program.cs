using System;
internal class Program
{
    static void Main(string[] args)
    {
        //Console.Write("Enter age : ");
        //int age = int.Parse(Console.ReadLine());

        //Console.Write("Do you have a Driving License?(Yes/No) : ");
        //string dl = Console.ReadLine();


        //if (age >= 18 && dl == "Yes")
        //{
        //    Console.WriteLine("You can Drive");
        //}
        //else
        //{
        //    int AgeDiff = 18 - age;
        //    Console.WriteLine("Get DL after {0} years", AgeDiff);
        //}

        //string msg = age >= 18 && dl == "Yes" ? "You can Drive" : "You can't Drive";
        //Console.WriteLine(msg);


        //int? age = null;
        //Console.WriteLine(age);

        //Console.Write("Enter Full Name : ");
        //string fullName = Console.ReadLine();

        //Console.Write("Are you a Student?(true/false) : ");
        //bool? isStudent = bool.Parse(Console.ReadLine());
        //bool? isStudent = null;

        //if (isStudent == true)
        //{
        //    Console.WriteLine("{0} go to school.", fullName);
        //}
        //else if(isStudent == false)
        //{
        //    Console.WriteLine("{0} go to Office",fullName);
        //}
        //else
        //{
        //    Console.WriteLine("You did'nt answer my question!");
        //}

        int? TicketsOnSale;
        int AvailableTickets;

        //TicketsOnSale = 12000;
        TicketsOnSale = null;
//Hard Way
        //if(TicketsOnSale == null)
        //{
        //    AvailableTickets = 0;
        //    Console.WriteLine("Tickets = {0}", AvailableTickets);
        //}
        //else
        //{
        //    AvailableTickets = (int)TicketsOnSale;
        //    Console.WriteLine("Tickets = {0}", AvailableTickets);
        //}
//null Coalescing 
        AvailableTickets = TicketsOnSale ?? 0;
        Console.WriteLine("Tickets = {0}", AvailableTickets);
    }
}