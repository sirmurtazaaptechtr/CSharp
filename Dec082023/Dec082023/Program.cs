using System;

namespace Dec082023
{
    interface I1
    {
        void Show();
        void Input (string name);
       
    }
    interface I2
    {
        void I2Method();
    }
    public struct Student : I1, I2
    {
        public int Id {  get; set; }
        public string Name { get; set; }

        public Student (int id, string name) 
        {
            Id = id;
            Name = name;
        }
        public void Show()
        {

        }
        public void Input (string name)
        {
            Name = name;
        }
        public void I2Method() 
        {

        }

        public void Print () 
        {
            Console.WriteLine("ID : {0}\nName : {1}\n", Id, Name);
        }
    }
    internal class Program
    {
        static void Main()
        {
            Student std1 = new Student();
            Student std2 = new Student();
            Student std3 = new Student(3, "Ahsan Khan");
            Student std4 = new Student 
            { 
                Id = 4, 
                Name = "Saqlain Dejwani"
            };
            Student std5 = new Student();

            std1.Id = 1;
            std1.Name = "Aptech Learning";
            std2.Id = 2;
            std2.Name = "Kinza Danish";

            std5.Id = 5;
            std5.Input("Ali Raza");


            std1.Print();
            std2.Print();
            std3.Print();
            std4.Print();
            std5.Print();
        }
    }
}
