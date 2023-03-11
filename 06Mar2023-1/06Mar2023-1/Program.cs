using System;

namespace _06Mar2023_1
{
    public class Circle
    {
        static float _pi = 3.14f;
        public float _radius;

        public Circle(float Radius)
        {
            this._radius = Radius;
        }
        public float AreaofCircle()
        {
            float AOC = _pi * this._radius * this._radius;
            return AOC;
        }
    }
    internal class Program
    {
        static void Main()
        {
            Circle c1 = new Circle(1.2f);
            Console.WriteLine("The Area of Circle with Radius {0} = {1}",c1._radius,c1.AreaofCircle());
            
            Circle c2 = new Circle(0.5f);
            Console.WriteLine("The Area of Circle with Radius {0} = {1}",c2._radius,c2.AreaofCircle());
        }
    }
}