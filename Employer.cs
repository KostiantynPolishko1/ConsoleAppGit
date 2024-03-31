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

        public Employer() : base() { }

        public Employer(string name, int salary, int age, string? sex) : base(salary, sex)
        {
            this.name = name;
            this.salary = salary;
        }
    }
}
