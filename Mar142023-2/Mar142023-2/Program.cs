using System;
namespace Mar142023_1
{
    public class Student
    {
        private int _id;
        private string _name;
        private float _obtMarks;
        private float _maxMarks = 75f;

        public float getMaxMarks()
        {
            return this._maxMarks;
        }
        public void setMarks(float ObtMarks)
        {
            this._obtMarks = ObtMarks;
        }
        public float getMarks() {
            if(this._obtMarks < 0 || this._obtMarks > this._maxMarks)
            {
                throw new Exception("Marks can't be less than zero or greater than Max Marks i.e. 75");
            }
            else
            {
                return this._obtMarks;
            }
        }
        public void setName(string Name)
        {
            if(String.IsNullOrEmpty(Name))
            {
                throw new Exception("name can't be null");
            }
            else
            {
                this._name = Name;
            }
        }
        public string getName() 
        {
            if (String.IsNullOrEmpty(this._name))
            {
                return "N/A";
            }
            else
            {
                return this._name;
            }
        }
        public void setID(int ID)
        {
            if(ID <= 0)
            {
                //Console.WriteLine("ID must be greater than 0");
                throw new Exception("ID must be greater than 0");
            }
            else
            {
                this._id = ID;
            }            
        }
        public int getID()
        {
            return this._id;
        }
    }
    internal class Program
    {
        static void Main()
        {
            Student s1 = new Student();
            //s1.setID(-1);
            s1.setID(1);
            //s1.setName(null);
            s1.setName("Nimra");

            s1.setMarks(65f);

            float Per = s1.getMarks()/s1.getMaxMarks() * 100;

            //Console.WriteLine("Dear {0}, ID : {1}", s1.getName(), s1.getID());

            Console.WriteLine("Dear {0}, ID : {1}\nYou have obtained {2} out of {3} marks and your percentage is {4}% ", s1.getName(), s1.getID(), s1.getMarks(), s1.getMaxMarks(), Per);
        }
    }
}