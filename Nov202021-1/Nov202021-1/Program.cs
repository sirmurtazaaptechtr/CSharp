using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov202021_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///This is an XML comment
            ///</summary>
            string empName;
            int empSal;
            empName = "Moiz Ghazali";
            empSal = 10000;
            Console.WriteLine("Dear" + empName + ", your salary is PKR " + empSal + "/=");
            bool boolTest = true;
            short byteTest = 19;
            int intTest;
            string stringTest = "Abdul Rehman Makki";
            float floatTest;
            intTest=140000;
            floatTest = 14.5f;
            Console.WriteLine("boolTest = {0}\nbyteTest = {1}\n", boolTest, byteTest);
            Console.WriteLine("boolTest ="+boolTest+"\nbyteTest ="+byteTest);
            Console.WriteLine("\nintTest =" + intTest + "\nfloatTest =" + floatTest + "\nstringTest =" + stringTest);
            Console.Read();
        }
    }
}
