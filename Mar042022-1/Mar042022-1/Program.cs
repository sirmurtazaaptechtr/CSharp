using System;
//Method Hiding
//public class parentClass
//{
//    public void printMSG()
//    {
//        Console.WriteLine("This is Parent Class Method");
//    }
//}
//public class childClass : parentClass
//{
//    public new void printMSG()
//    {
//        Console.WriteLine("This is child Class Method");
//    }
//}
public class parentClass
{
    public virtual void printMSG()
    {
        Console.WriteLine("This is Parent Class Method");
    }
}
public class childClass : parentClass
{
    public override void printMSG()
    {
        Console.WriteLine("This is child Class Method");
    }
}


internal class Program
{
    static void Main()
    {
        parentClass c = new childClass();
        c.printMSG();
    }
}

