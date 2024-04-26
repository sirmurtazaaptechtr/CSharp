using System;

namespace Apr262024
{
    internal class Program
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.Id = "s1";
            s1.Name = "Test";
            s1.Gender = "male";
            s1.Email = "example@email.com";
            s1.Class = 5;
            s1.RollNumber = 7;

            Teacher t1 = new Teacher();
            t1.Id = "t1";
            t1.Name = "Miss. Test";
            t1.Gender = "female";
            
        }
    }
}
