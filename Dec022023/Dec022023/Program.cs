using System;
using System.Text.RegularExpressions;
namespace Dec022023
{
    class PointSheet
    {
        private string _pattern = @"^[a-zA-Z-' ]*$";
        private string _name;
        private float _maxmarks = 75.0f;
        private float _obtmarks = 0;

        public void SetName (string Name)
        {
            Regex re = new Regex(this._pattern);
            if(re.Match(Name).Success)
            {
                this._name = Name;
            }else
            {
                this._name = "Invalid Name";
            }  
        }
        public string GetName ()
        {
            if(string.IsNullOrEmpty(this._name))
            {
                return "No Name";
            }else
            {
                return this._name;
            }
        }
        public float GetMaxMarks ()
        {
            return this._maxmarks;
        }
        public void SetObtMarks (float ObtMarks)
        {
            if(ObtMarks > this._maxmarks || ObtMarks < 0)
            {
                this._obtmarks = 0;
            }
            else
            {
                this._obtmarks = ObtMarks;
            }
        }
        public float GetObtMarks()
        {            
            return this._obtmarks;
        }
        public void Print ()
        {
            Console.WriteLine("Name : {0}\nMax Marks : {1}\nObt. Marks : {2}\nPercentage : {3}%\n", GetName(), GetMaxMarks(), GetObtMarks(), GetObtMarks()/GetMaxMarks()*100);
        }
    }
    internal class Program
    {
        static void Main()
        {
            PointSheet ps1 = new PointSheet();
            //ps1.SetName("123");
            //ps1.SetName("Ali69");
            ps1.SetName("Ali Raza");

            //ps1.SetObtMarks(-2);
            //ps1.SetObtMarks(80);
            ps1.SetObtMarks(22);

            ps1.Print();
            //Console.WriteLine("\nName : {0}\nMax Marks : {1}\nObt. Marks : {2}",ps1.GetName(),ps1.GetMaxMarks(),ps1.GetObtMarks());
        }
    }
}
