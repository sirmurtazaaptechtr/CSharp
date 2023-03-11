using System;
class Circle
{
    static float _PI = 3.14F;
    int _Radius;

    public Circle(int Radius)
    {
        this._Radius = Radius;
    }
    public float AreaOfCircle()
    {
        return Circle   ._PI*this._Radius*this._Radius;
    }
}
internal class Program
{
    static void Main()
    {
        Circle c1 = new Circle(2);
        float area1= c1.AreaOfCircle();
        Console.WriteLine("Area = {0}",area1);

        Circle c2 = new Circle(5);
        Console.WriteLine("Area = {0}", c2.AreaOfCircle());
        Console.Read();
    }
}