using Homeworks.HW_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homeworks.HW_5.Persons
{
    public abstract class Person : IDescribable
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public string City { get; private set; }

        public Person(string name, string surname) 
        {
            Name = name;
            Surname = surname;
            City = "UNKWOWN";
        }

        public Person(string name, string surname, int age) : this(name, surname)
        {
            Age = age;
        }

        public Person(string name, string surname, int age, string city) : this(name, surname, age)
        {
            City = city;
        }

        public virtual string DescribeYourself()
        {
            return $"""
            {Name} {Surname}
            Age: {Age}
            City: {City}
            """;
        }

    }
}
