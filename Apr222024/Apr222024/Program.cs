using System;
using System.Text.RegularExpressions;

namespace Apr222024
{
    class Student
    {
        private int _id;
        private string _name;
        private float _obt_marks;
        private static float _max_marks = 75f;
        private static string _pattern = "^[a-zA-Z-' ]*$";

        public void setID (int ID)
        {
            if (ID <= 0)
            {
                throw new ArgumentException("ID must be a positive integer.");
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

        public void setName (string Name)
        {
            Regex re = new Regex(_pattern);
            
            if (String.IsNullOrEmpty(Name))
            {
                this._name = "Anonymous";
            }
            else if (!re.IsMatch(Name))
            {
                this._name = "Unknown";
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
                return "Anonymous";
            }
            else
            {
                return this._name;
            }
        }
        public void setObtMarks (float ObtMarks)
        {
            if(ObtMarks > _max_marks || ObtMarks < 0) 
            {
                throw new Exception($"Marks Must be between 0 and {_max_marks}");
            }
            else
            {
                this._obt_marks = ObtMarks;
            }
        }
        public float getObtMarks ()
        {
            return this._obt_marks; 
        }

        public float getMaxMarks ()
        {
            return _max_marks;
        }
        public string getPattern ()
        {
            return _pattern;
        }

    }
    internal class Program
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.setID(1);
            s1.setName("Shoaib Faisal");
            s1.setObtMarks(53f);

            Console.WriteLine($"ID : {s1.getID()}\nName : {s1.getName()}\nPercentage : {s1.getObtMarks() / s1.getMaxMarks() * 100}%");



        }
    }
}
