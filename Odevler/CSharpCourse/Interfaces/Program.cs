namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        //IntarfacesIntro();
        //Demo();

        ICustomerDal[] customerDals = new ICustomerDal[2]
        {
            new SqlServerCustomerDal(),
            new OracleServerCustomerDal()
        };

        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }
    }

    private static void Demo()
    {
        IPerson person = new Customer();

        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlServerCustomerDal());
    }

    private static void IntarfacesIntro()
    {
        PersonManager manager = new PersonManager();
        Customer customer = new Customer
        {
            Id = 1,
            FirstName = "Engin",
            LastName = "Demiroğ",
            Adress = "Ankara"
        };

        Student student = new Student
        {
            Id = 2,
            FirstName = "Derin",
            LastName = "Demiroğ",
            Departmant = "Computer Science"
        };
        manager.Add(student);
        manager.Add(customer);
    }
}

interface IPerson //temel nesne oluşturup implemente etmek amacı taşır
{
    int Id { get; set; }
    string LastName { get; set; }
    string FirstName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Adress { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Departmant { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}