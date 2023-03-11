using System;
class Circle
{
    static float _PI = 3.147F;
    int _Radius;

    public Circle(int Radius)
    {
        this._Radius = Radius;
    }
    public float CalcArea()
    {
        return _PI * this._Radius * this._Radius;
    }
}

internal class Program
{
    static void Main()
    {
        Circle c1 = new Circle(2);        
        Console.WriteLine("The area of Circle is {0}",c1.CalcArea());

        Circle c2 = new Circle(3);
        Console.WriteLine("The area of Circle is {0}",c2.CalcArea());


    }
}