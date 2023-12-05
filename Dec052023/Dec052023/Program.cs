using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Dec052023
{
    class PointSheet
    {
        private string _name;
        private float _maxmarks = 75.0f;
        private float _obtmarks;
        //private string _institute;

        //public string Institute
        //{
        //    set { this._institute = value; }
        //    get { return this._institute; }
        //}
        public string Institute { get; } = "Aptech Learning";
        public string Pattern { get; } = @"^[a-zA-Z-' ]*$";

        

        public float ObtMarks
        {
            set 
            {
                if (value > this._maxmarks || value < 0)
                {
                    this._obtmarks = 0;
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

        public string Name 
        {
            set
            {
                Regex re = new Regex(Pattern);
                if (re.IsMatch(value))
                {
                    this._name = value;
                }
                else
                {
                    this._name = "Invalid Name";
                }
            }
            get
            {
                return string.IsNullOrEmpty(this._name)?"No Name":this._name;
            }
        }

        public void Print()
        {
            Console.WriteLine("Name : {0}\nMaxMarks : {1}\nObtMarks : {2}\nPercentage : {3}", Name, MaxMarks, ObtMarks, ObtMarks/MaxMarks*100);
        }
    }
        internal class Program
    {
        static void Main()
        {
            PointSheet ps = new PointSheet();
            ps.Name = "Ali Raza";
            ps.ObtMarks = 75;            
            
            Console.WriteLine(ps.Institute);
            Console.WriteLine(ps.MaxMarks);
            ps.Print();
        }
    }
}
