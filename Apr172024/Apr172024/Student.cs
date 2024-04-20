using System;

namespace Apr172024
{
    class Student
    {
        // Fields
        static private string _schoolname ;
        private int _id;
        public string _name;
        public string _gender;
        public int _age;

        // Constructor
        public Student()
        {

        }
        public Student(int ID)
        {
            this._id = ID;
        }
        public Student(int ID, string Name)
        {
            this._id = ID;
            this._name = Name;
        }

        // Methods
        public static void set_schoolname (string SchoolName)
        {
            _schoolname = SchoolName;
        }
        public static string get_schoolname ()
        {
            return _schoolname;
        }
        public void Print()
        {
            Console.WriteLine($"-----{_schoolname}-----\nID : {this._id}\nName : {this._name}\nGender : {this._gender}\nAge : {this._age}\n");
        }

    }
}
