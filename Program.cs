using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ex
{
    //class Emploee
    //{
    //    private string name;
    //    private int age;
    //    private int salary;

    //    public Emploee(string v1, int v2, int v3)
    //    {
    //        this.name = v1;
    //        this.age = v2;
    //        this.salary = v3;
    //    }

    //    public List<Emploee> Filter(List<Emploee> list, IComparer<Emploee> comparer)
    //    {
    //        list.Sort(comparer ? salary)
    //        return list;

    //    }
    //}



    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Emploee emploee = new Emploee("Egor", 23, 333);

    //        List<Emploee> employ = new List<Emploee>();

    //        employ.Add(new Emploee("Egor", 23, 333));
    //        employ.Add(new Emploee("Dima", 23, 333));
    //        employ.Add(new Emploee("Vova", 43, 343));

    //        emploee.Filter(employ, IComparer<Emploee>);

    //        Console.ReadLine();
    //    }

    //}

    class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "John", Age = 30, Salary = 50000 },
            new Employee { Name = "Alice", Age = 25, Salary = 60000 },
            new Employee { Name = "Bob", Age = 35, Salary = 45000 }
        };

            Console.WriteLine("Before sorting:");
            PrintEmployees(employees);

            employees.Sort();

            Console.WriteLine("\nAfter sorting by name:");
            PrintEmployees(employees);
        }

        static void PrintEmployees(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"Name: {emp.Name}, Age: {emp.Age}, Salary: {emp.Salary}");
            }
        }
    }
}
