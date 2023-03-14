using System;
namespace Mar142023_1
{
    public class Student
    {
        private int _id;
        private string _name;
        private float _obtMarks;
        private float _maxMarks = 75f;        
        public string Email { set; get; }
        public string City { set; get; }    
        public int ID
        {
            set 
            {
                if (value <= 0)
                {                    
                    throw new Exception("ID must be greater than 0");
                }
                else
                {
                    this._id = value;
                }
            }
            get{return this._id;}
        }
        public string Name
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("name can't be null");
                }
                else
                {
                    this._name = value;
                }
            }
            get{return String.IsNullOrEmpty(this._name) ? "No Name" : this._name;}
        }
        public float ObtMarks
        {
            set
            {
                if(value < 0 || value > this._maxMarks)
                {
                    throw new Exception("ObtMarks can't be less than zero or greater than Max Marks.");
                }
                else
                {
                    this._obtMarks = value;
                }
            }
            get{return this._obtMarks;}
        }
        public float MaxMarks
        {
            get{return this._maxMarks;}
        }        
    }
    internal class Program
    {
        static void Main()
        {
            Student s1 = new Student();            
            s1.ID = 1;
            s1.Name = "Nimra Naeem";
            s1.ObtMarks = 60f;
            s1.Email = "nimranaeem@gmail.com";
            s1.City = "Karachi";

            float Per = s1.ObtMarks / s1.MaxMarks * 100;
            Console.WriteLine("Student ID : {0}\nStudent Name : {1}\nMarks Obtained out of {2} : {3}\nPercentage : {4}%\nEmail Address : {5}\nCity : {6}",s1.ID,s1.Name,s1.MaxMarks,s1.ObtMarks,Per,s1.Email,s1.City);

            Student s2 = new Student();
            //s2.ID = -1;
            s2.ID = 2;
            //s2.Name = null;
            //s2.ObtMarks = 76f;
            //s2.ObtMarks = -1f;
            s2.ObtMarks = 75f;
            s2.Email = "example@eamil.com";
            s2.City = "KohKaaf";

            Per = s2.ObtMarks / s2.MaxMarks * 100;
            Console.WriteLine("Student ID : {0}\nStudent Name : {1}\nMarks Obtained out of {2} : {3}\nPercentage : {4}%\nEmail Address : {5}\nCity : {6}", s2.ID, s2.Name, s2.MaxMarks, s2.ObtMarks, Per, s2.Email, s2.City);
        }
    }
}