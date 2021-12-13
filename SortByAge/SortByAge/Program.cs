using System;

namespace SortByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayItems<Person> people = new ArrayItems<Person>();

            Person person1 = new Person("Rashad", "Gasimzade", 21);
            Person person2 = new Person("Hikmet", "Gasimli", 18);
            Person person3 = new Person("Sadig", "Abdullayev", 14);

            people.AddItems(person1);
            people.AddItems(person2);
            people.AddItems(person3);
            
            people.GetSortedByAgeItems();
            Console.WriteLine(person1>person2);
        }
    }
}
