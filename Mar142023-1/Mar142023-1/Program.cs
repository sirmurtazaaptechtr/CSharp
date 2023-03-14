using System;
namespace Mar142023_1
{
    public class Student
    {
        public int Id;
        public string Name;
        public float ObtMarks = 0f;
        public float MaxMarks = 75f;        
    }    
    internal class Program
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.Id = 1;
            s1.Name = "Ali Raza";
            s1.ObtMarks = 60f;
            float Per = s1.ObtMarks / s1.MaxMarks * 100;
            Console.WriteLine("Dear {0}, ID : {1}\nYou have obtained {2} out of {3} marks and your percentage is {4}% ",s1.Name,s1.Id,s1.ObtMarks,s1.MaxMarks,Per); 

            Student s2 = new Student();
            s2.Id = -1;
            s2.Name = null;
            s2.ObtMarks = 100f;
            s2.MaxMarks = 10f;

            Per = s2.ObtMarks / s2.MaxMarks * 100;

            Console.WriteLine("Dear {0}, ID : {1}\nYou have obtained {2} out of {3} marks and your percentage is {4}% ",s2.Name,s2.Id,s2.ObtMarks,s2.MaxMarks,Per);
            
        }
    }
}
