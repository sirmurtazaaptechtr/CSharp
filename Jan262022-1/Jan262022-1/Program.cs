using System;
class Program
{
    static void Main()
    {
        //string name = "Murtaza";
        //int? age = 40;

        //Console.WriteLine("Hi {0}, you are {1} years old", name,age);

        //bool? AreYouStudent = null;

        //if(AreYouStudent == true)
        //{
        //    Console.WriteLine("User is Student.");
        //}
        //else if(AreYouStudent == false)
        //{
        //    Console.WriteLine("User is not Student");
        //}
        //else
        //{
        //    Console.WriteLine("User has not answered the Question.");
        //}

        int? PSLPassOnSale = 8500;
        int PSLPassAvailable = PSLPassOnSale ?? 0;

        //if(PSLPassOnSale == null)
        //{
        //    PSLPassAvailable = 0;            
        //}
        //else
        //{
        //    PSLPassAvailable = (int)PSLPassOnSale;
        //}
        
        Console.WriteLine("Pass Avilable = {0}", PSLPassAvailable);

        Console.Read();
    }
}

