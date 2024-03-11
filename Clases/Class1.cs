
    using System;

    namespace generics
    {
        public class Employee : IComparable<Employee>
        {
            public string? Id { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }

            public Employee(string? id, string? firstName, string? lastName)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
            }

            public int CompareTo(Employee? other)
            {
                if (other == null) return 1;
                return this.LastName.CompareTo(other.LastName);
            }
        }
    }

