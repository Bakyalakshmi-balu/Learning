namespace MyApp
{
    public class Employee
    {
        public int Id{get;set; }
        public string Name{get;set; }
        public string Email{get;set; }
        public string Department{get;set; }
        public int PhoneNo{get;set; }

        public Employee(int id, string name, 
        string email, string department, int phone)
        {
            Id = id;
            Name = name;
            Email = email;
            Department = department;
            PhoneNo = phone;
        }


        public void login()
        {
            Console.WriteLine("Employee has logged in");
        }
    }


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

    public class Manager : Employee
    {
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