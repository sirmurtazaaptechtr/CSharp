using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
namespace Nov272023
{
    class User
    {
        int _id;
        string _type;
        string _name;
        string _email;
        int _age;
        float _salary;

        public User() :this(0, "N/A")
        {
            
        }
        public User(int ID) 
        {
            this._id = ID;
        }

        public User(int ID, string Type)
        {
            this._id = ID;
            this._type = Type;
        }


        public bool SetType(string Type)
        {
            this._type = Type;
            return true;
        }

        public bool SetName (string Name)
        {
            this._name = Name;
            return true;
        }
        public void SetEmail (string Email)
        {
            this._email = Email;
        }
        public bool SetAge (int Age)
        {
            if(Age < 0)
            {
                return false;
            }else
            {
                this._age = Age;
                return true;
            }
        }
        public void SetSalary (float Salary)
        {
            this._salary = Salary;
        }

        public void Print() 
        {
            Console.WriteLine("\nID : {4}\nType : {5}\nName : {0}\nEmail : {1}\nAge : {2}\nSalary : {3}\n", this._name, this._email, this._age, this._salary,this._id,this._type);
        }
        ~User() 
        {
            Console.WriteLine("\nThe End\n");
        }
    }
    internal class Program
    {
        static void Main()
        {
            User u1 = new User(1);
            User u2 = new User();
            User u3 = new User(3, "Administrator");

            if(u1.SetName("Kinza Danish"))
            {
                Console.WriteLine("Name is set successfully");
            }
            u1.SetEmail("kinzadanish@outlook.com");
            if(u1.SetAge(-2))
            {
                Console.WriteLine("Age is set successfully");
            }else
            {
                Console.WriteLine("Invalid Input");
            }
            u1.SetSalary(125455.25f);

            u2.SetName("Ahsan Khan");
            u2.SetEmail("ahsankhan@gmail.com");
            u2.SetAge(21);
            u2.SetSalary(525366.75f);
            
            u3.SetName("Khurram");
            u3.SetEmail("khurram@gmail.com");
            u3.SetAge(22);
            u3.SetSalary(325366.50f);

            
            PATA.Class1.Print();
            PATB.Class1.Print();
            Program.Print();

            u1.Print();
            u2.Print();
            u3.Print();

        }
        public static void Print ()
        {
            Console.WriteLine("This is Main Team");
        }
    }
}