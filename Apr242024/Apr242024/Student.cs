using System;
using System.Text.RegularExpressions;

namespace Apr242024
{
    internal class Student
    {
        private int _id;
        private string _name;
        private float _obtmarks;
        private static float _maxmarks = 75f;
        private static string _pattern = "^[a-zA-Z' ]*$";

        Regex re = new Regex(_pattern);

        public int Id 
        {
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("ID must be a positive integer...");
                }
                else
                {
                    this._id = value;
                }
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
                    this._name = "Anonymous";
                }
                else if(!re.IsMatch(value))
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
                if (String.IsNullOrEmpty(this._name))
                {
                    return "Anonymous";
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
                if (value > _maxmarks)
                {
                    throw new Exception($"Obtained marks must be form 0 to {_maxmarks}");          
                }
                else
                {
                    this._obtmarks = value;
                }
            }
            get
            {
                return this._obtmarks;
            }
        }
        public float MaxMarks
        {
            get
            {
                return _maxmarks;
            }
        }
    }
}
