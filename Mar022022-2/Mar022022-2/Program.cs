using System;
public class BaseClass
{
    public string FirstName = "FN";
    public string LastName = "LN";

    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}
public class FirstChildClass : BaseClass
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "- FirstChildClass");
    }
}
public class SecondChildClass : BaseClass
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "- SecondChildClass");
    }

}
public class ThirdChildClass : BaseClass
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "- ThirdChildClass");
    }

}

internal class Program
{
    static void Main()
    {
        BaseClass[] baseClass = new BaseClass[4];
                
        baseClass[0] = new FirstChildClass();
        baseClass[1] = new SecondChildClass();
        baseClass[2] = new ThirdChildClass();
        baseClass[3] = new BaseClass();

        foreach(BaseClass c in baseClass)
        {
            c.PrintFullName();
        }
       
    }
}