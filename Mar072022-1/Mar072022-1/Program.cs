using System;
public class Student
{
    private readonly string _dept = "MIS";
    private int _id;
    private string _name;

    public string Email { get; set; }
    public string City { get; set; }
    public DateTime DOB { get; set; }
    public string Dept { get { return _dept; }  }
    public int Id {
        get
        {
            return this._id;
        }
        set 
        {
            if(value <= 0)
            {
                throw new ArgumentOutOfRangeException("The value of id must be +ve int");
            }
            this._id = value;
        } 
    }
    public string Name {
        get
        {
            return _name;

        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name can not be null or empty");
            }
            this._name = value;

        }
    }    
}
internal class Program
{
    static void Main()
    {
        Student std = new Student();
        std.Id = 1;
        std.Name = "Jon Doe";
        std.Email = "jon_doe@email.com";
        std.DOB = Convert.ToDateTime("07-Mar-2005");

        Console.WriteLine("Name : {0}\nDate of Birth : {1}", std.Name, std.DOB);

        
    }
}

