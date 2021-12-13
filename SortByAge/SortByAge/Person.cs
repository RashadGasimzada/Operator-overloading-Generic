using System;
using System.Collections.Generic;
using System.Text;

namespace SortByAge
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;       
            
        }
        public static bool operator >(Person person1, Person person2)
        {
            return person1.Age > person2.Age;
        }
        public static bool operator <(Person person1, Person person2)
        {
            return person1.Age < person1.Age;
        }
    }
}
