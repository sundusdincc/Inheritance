namespace Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*TohumlumluBitki: tohumlubitki*");
            TohumluBitkiler tohumlubitki = new TohumluBitkiler();
            tohumlubitki.TohumlaCogalma();


            Console.WriteLine("\n*Kuşlar: Martı*");
            Kuşlar marti = new Kuşlar();
            marti.Ucmak();


            Person per1 = new Person();
            per1.Id = 1; //valid
            per1.FirstName = "James"; //valid
            per1.LastName = "Bond"; //valid

            //per1.CompanyName; // not supported
            //per1.Salary;  // not supported

            Person per2 = new Employee();
            per2.Id = 2; //valid
            per2.FirstName = "Bill"; //valid
            per2.LastName = "Gates"; //valid

            //per2.CompanyName; // not supported
            //per2.Salary;  // not supported

            Employee emp = new Employee();
            emp.Id = 1; //valid
            emp.FirstName = "Steve";//valid
            emp.LastName = "Jobs";//valid
            emp.CompanyName = "XYZ"; //valid
            emp.Salary = 10000; //valid 

            //invalid, can't assign base type to derived type
            //Employee emp = new Person();
            emp.EmpInfo(emp);
            per1.PersonInfo();
            per2.PersonInfo();


        }
    }
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void PersonInfo()
    {
        Console.WriteLine("\nId:{0}",Id);
        Console.WriteLine("FirstName:{0}",FirstName);
        Console.WriteLine("LastName:{0}",LastName);
    }
}

class Employee : Person
{
    public string CompanyName { get; set; }
    public decimal Salary { get; set; }

    public void EmpInfo(Employee emp)
    {
        Console.WriteLine($"\nID:{emp.Id}\n" + $"FirstName:{emp.FirstName}\n" + $"LastName:{emp.LastName}");
        Console.WriteLine("CompanyName: " + emp.CompanyName + "\n" + "Salary: " + emp.Salary);
    }
}








