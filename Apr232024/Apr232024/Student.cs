using System;
using System.Text.RegularExpressions;

namespace Apr232024
{
    internal class Student
    {
        private int _id;
        private string _name;
        private float _obt_marks;
        private static float _max_marks = 75f;
        private static string _pattern = "^[a-zA-Z-' ]*$";

        Regex re = new Regex(_pattern);

        public int Id
        {
            set 
            {
                if(value <= 0)
                {
                    throw new Exception("Student ID can't be negative or zero.");
                }
                this._id = value; 
            }
            get
            {
                return this._id;
            }
        }
        public string Name
        {                       
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    this._name = "No Name";
                }
                else if (!re.IsMatch(value))
                {
                    this._name = "Unknown";
                }
                else
                {
                    this._name = value;
                }
            }
            get
            {
                if(String.IsNullOrEmpty(this._name))
                {
                    return "No Name";
                }
                else
                {
                    return this._name;
                }
            }
        }
        public float ObtMarks
        {
            set
            {
                if(value < 0 || value > _max_marks)
                {
                    throw new Exception($"Value must be between 0 and {_max_marks}");
                }
                this._obt_marks = value;
            }
            get
            {
                return this._obt_marks;
            }
        }
        public float MaxMarks
        {
            get
            {
                return _max_marks;
            }
        }
        public string Pattern
        {
            get
            {
                return _pattern;
            }
        }

        
    }
}
