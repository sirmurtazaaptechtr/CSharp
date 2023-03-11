using System;
class Program
{
    static void Main()
    {
        //int i = 15;
        //float f = 3.14f;
        //string s = "Ali";
        //bool b = true;
        //Console.WriteLine("\"Syed Murtaza Hussain\"");
        //Console.WriteLine("Integer Value ={0}\nfloating Point Value {1}\nString Value = {2}\nBoolean Value = {3}", i, f, s, b);
        //Console.WriteLine("C:\\Users\\murtaza\\OneDrive\\Student Share\\Sem02\\Essentials of C# Programming\\Slides");
        //Console.WriteLine(@"C:\Users\murtaza\OneDrive\Student Share\Sem02\Essentials of C# Programming\Slides");
        
        int age;
        Console.WriteLine("How old are you?");
        age = int.Parse(Console.ReadLine());

        //if(age>=18)
        //{
        //    Console.WriteLine("You can drive as you are {0} years old", age);
        //}
        //else
        //{
        //    Console.WriteLine("You will be able to drive after {0} years", 18 - age);
        //}

        string msg = age >= 18 ? "You can Drive as you are "+age+" years old" : "You can't Drive as your age is "+(18-age)+" years less";
        Console.WriteLine(msg);
        

        Console.Read();
    }
}