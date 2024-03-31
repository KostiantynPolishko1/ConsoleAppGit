using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGit
{
    public class Employer : Person
    {
        public string? name { get; private set; }
        public int salary { get; private set; }

        public Employer() : base() { name = "unknown"; salary = 10; }

        public Employer(string? name, int salary, int age, string? sex) : base(salary, sex)
        {
            this.name = name??= "unknown";
            this.salary = salary;
        }

        public override string ToString() => $"{name} - {salary} | " + base.ToString();
    }
}
