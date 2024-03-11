using System;
namespace ClassLibrary1
{
    public class Book : IComparable<Book>
    {
        int ID { get; set; }
        string Title { get; set; }

        int NumPages { get; set; }

        public Book(int id, string title, int numPages)
        {
            ID = id;
            Title = title;
            NumPages = numPages;
        }
        public Book()
        {
            ID = 0;
            Title = "Unknown";
            NumPages = 0;
        }

        public string toString()
        {
            return "ID: " + ID + " Title: " + Title + " NumPages: " + NumPages;
        }
        public int CompareTo(Book b)
        {
            return this.NumPages - b.NumPages;
        }
    }


        public class Employee : IComparable<Employee>
        {
            public string? Id { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? Code { get; set; }
            public DateTime BirthDate { get; set; }

            public DateTime HireDate { get; set; }

            public float Salary { get; set; } = 1800;

            public int Payments { get; set; } = 14;




            public Employee (string? id, string? firstName, string? lastName, string? code, DateTime birthDate, DateTime hireDate, float salary, int payments)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Code = code;
                BirthDate = birthDate;
                HireDate = hireDate;
                Salary = salary;
                Payments = payments;             
            }
        public Employee(string? id, string? firstName, string? lastName, string? code, DateTime birthDate, DateTime hireDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Code = code;
            BirthDate = birthDate;
            HireDate = hireDate;
        }

        public void ToString()
            {
                Console.WriteLine($"Id: {Id}\n, FirstName: {FirstName}\n, LastName: {LastName}\n, Code: {Code}\n, BirthDate: {BirthDate}\n, HireDate: {HireDate}\n, Salary: {Salary}\n, Payments: {Payments}\n");
            }

        public int CompareTo(Employee? other)
            {
                if (other == null) return 1;
                return this.LastName.CompareTo(other.LastName);
            }
            
            public int Edad (DateTime a)
            {
            return DateTime.Now.Year - a.Year;
            }
        }
    public class SalesEmployee : Employee
    {
        public float Commission { get; set; }
        public SalesEmployee(string? id, string? firstName, string? lastName, float commission) : base(id, firstName, lastName, null, DateTime.Now, DateTime.Now, 0, 0)
        {
            Commission = commission;
        }
    }
    
}