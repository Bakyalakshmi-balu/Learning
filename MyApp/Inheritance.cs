namespace MyApp
{
    // Base class Employee
    public class Employee
    {
        public int Id{get;set; }
        public string Name{get;set; }
        public string Email{get;set; }
        public string Department{get;set; }
        public int PhoneNo{get;set; }

// Constructor for Employee class
        public Employee(int id, string name, 
        string email, string department, int phone)
        {
            Id = id;
            Name = name;
            Email = email;
            Department = department;
            PhoneNo = phone;
        }

//  Method to simulate employee login
        public void login()
        {
            Console.WriteLine("Employee has logged in");
        }
    }

//  Derived class Developer that inherits from Employee
    public class Developer : Employee
    {

        // Constructor for Developer class
        public Developer(
            int id, 
            string name, 
            string email, 
            string department, 
            int phoneNo) 
            // base keyword is used to call the constructor of the base class (Employee) and pass the parameters to it
            : base(id, name, email, 
            department, phoneNo){}
        public void writeCode()
        {
            Console.WriteLine("Developer is writing code");
        }
    }
//  Derived class Manager that inherits from Employee
    public class Manager : Employee
    {
        // Constructor for Manager class
        public Manager(
            int id, 
            string name, 
            string email, 
            string department, 
            int phoneNo) 
            : base(id, name, email,
             department, phoneNo)
        {
        }

        public void manageMeeting()
        {
            Console.WriteLine("conducting meeting");
        }
    }
}