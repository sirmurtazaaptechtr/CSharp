using System;
namespace Dec072023
{
    interface IStudent
    {
        void Show();
        
    }
    interface I2
    {
        void I2Method();
    }
    public struct Student : IStudent, I2
    {
        private int _id;
        private string _name;        
        public Student (int ID, string Name)
        {
            this._id = ID;
            this._name = Name;
        }

        public int Id { get => this._id; set => this._id = value; }
        public string Name { get => this._name; set => this._name = value; }

        public void Print ()
        {
            Console.WriteLine("ID : {0}\nName : {1}\n", Id, Name);
        }
        public void Show ()
        {

        }

        void I2.I2Method()
        {
            
        }
    }
    internal class Program
    {
        static void Main()
        {
            Student student1 = new Student(1, "Khurram");
            student1.Name = "Saad Khurram";
            Student student2 = new Student(2, "Taha");
            student2.Name = "Taha Tehseen";

            Student student3 = new Student
            {
                Name = "Ali Raza",
                Id = 3
            };

            student1.Print();
            student2.Print();
            student3.Print();
        }
    }
}
