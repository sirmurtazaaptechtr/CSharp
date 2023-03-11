using System;
class Circle

{
    static float _pi = 3.14F;
    float _radius;

    public Circle(float Radius)
    {
        this._radius = Radius;
    }
    public float AreaOfCircle()
    {
        return _pi*this._radius*this._radius;
    }
}
internal class Program
{
    static void Main()
    {
        float r1 = 1.6F;
        Circle c1 = new Circle(r1);
        float a1 = c1.AreaOfCircle();
        Console.WriteLine("Circle with radius {0} has Area {1}", r1, a1);

        float r2 = 0.75F;
        Circle c2 = new Circle(r2);
        float a2 = c2.AreaOfCircle();
        Console.WriteLine("Circle with radius {0} has Area {1}", r2, a2);
    }
}