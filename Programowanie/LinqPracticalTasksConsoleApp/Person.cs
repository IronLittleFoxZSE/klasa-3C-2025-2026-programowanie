using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticalTasksConsoleApp
{
    public enum Gender { Male, Female, Other }

    internal class Person
    {
        public int Id { get; init; }
        public string FirstName { get; init; } = default!;
        public string LastName { get; init; } = default!;
        public int Age { get; init; }
        public Gender Gender { get; init; }
        public string City { get; init; } = default!;
        public decimal Salary { get; init; }
        public List<string> Skills { get; init; } = new();

        public override string ToString()
            => $"{Id}: {FirstName} {LastName}, {Age} lat, {Gender}, {City}, {Salary:C0}, Skills=[{string.Join(", ", Skills)}]";
    }
}
