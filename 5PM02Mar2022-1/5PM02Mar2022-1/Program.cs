using System;
internal class Program
{
    static void Main()
    {
        int? TicketsOnSale = null;
        int AvailableTickets;
        int ComTickets = 15;

        AvailableTickets = TicketsOnSale - ComTickets ?? 0;

        //if(TicketsOnSale == null)
        //{
        //    AvailableTickets = 0;
        //}
        //else
        //{
        //    AvailableTickets = (int)TicketsOnSale - ComTickets;
        //}

        Console.WriteLine("Total Tickets = {0}",TicketsOnSale);
        Console.WriteLine("Complementary Tickets = {0}",ComTickets);
        Console.WriteLine("Available Tickets = {0}",AvailableTickets);

        Console.Read();
    }
}