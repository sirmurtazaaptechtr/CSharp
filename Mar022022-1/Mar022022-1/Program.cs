using System;

public class parentClass
{
    public parentClass()
    {
        Console.WriteLine("Parent Class constructor Called");
    }
}
public class childClass : parentClass
{
    public childClass()
    {
        Console.WriteLine("Child Class constructor Called");
    }
}

internal class Program
{
    static void Main()
    {
        childClass cc = new childClass();

    }
}

