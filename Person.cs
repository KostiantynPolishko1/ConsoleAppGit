using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGit
{
    public class Person
    {
        public int age {  get; private set; }
        public string? sex { get; private set; }

        public Person() : this (18, null) { }

        public Person(int age, string? sex)
        {
            this.age = age;
            this.sex = sex??= "gender";
        }

        public override string ToString() => $"age : {age}, sex : {sex}"; 
    }
}
