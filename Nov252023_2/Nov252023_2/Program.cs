using System;
namespace Nov252023_2
{
    class Customer
    {
        int _id;
        string _name;
        string _email;
        int _age;
        float _wallet;

        public Customer() 
            : this(0)
        {

        }
        public Customer(int ID) 
        {
            this._id = ID;
        }

        public void SetName (string Name)
        {
            this._name = Name;
        }
        public void SetEmail (string Email)
        {
            this._email = Email;
        }
        public void SetAge (int Age)
        {
            this._age = Age;
        }
        public void SetWallet (float Wallet)
        {
            this._wallet = Wallet;
        }
        public void Print ()
        {
            Console.WriteLine("ID : {4}\nName : {0}\nEmail : {1}\nAge : {2}\nWallet : {3}", this._name, this._email, this._age, this._wallet, this._id);
        }

        ~Customer()
        {
            Console.WriteLine("\n__________\n");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Customer c1 = new Customer(1);
            Customer c2 = new Customer(2);
            Customer c3 = new Customer();            

            c1.SetName("Saad Khurram");
            c1.SetEmail("saadkhurram1@outlook.com");
            c1.SetAge(17);
            c1.SetWallet(124350.50f);

            c2.SetName("Muhammad Zubair");
            c2.SetEmail("muhammadzubair669@gmail.com");
            c2.SetAge(21);
            c2.SetWallet(224350.30f);

            c3.SetName("Muhammad Taha");
            c3.SetEmail("tahatehseen@gmail.com");
            c3.SetAge(20);
            c3.SetWallet(0.30f);

            c1.Print();
            c2.Print();
            c3.Print();            
        }
    }
}
