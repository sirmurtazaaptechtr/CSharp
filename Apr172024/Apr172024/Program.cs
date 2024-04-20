using System;

namespace Apr172024
{
    
    internal class Program
    {
        static void Main()
        {
            Student.set_schoolname("Aptech Learning");

            Student s0 = new Student();
            Student s1 = new Student(1);
            Student s2 = new Student(2);
            Student s3 = new Student(3);
            Student s4 = new Student(4, "Moiz ur Rehman");
            
            s1._name = "Hiba Farhan";
            s1._gender = "Female";
            s1._age = 17;
            
            s2._name = "Shoaib Wazir";
            s2._gender = "Male";
            s2._age = 19;
            
            s3._name = "Mujtaba Khanani";
            s3._gender = "Male";
            s3._age = 22;

            s1.Print();
            s2.Print();
            s3.Print();
            s4.Print();
            
        }
    }
}
