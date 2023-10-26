using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{ FirstName = "Engin" },
                new Student{ FirstName = "Derin" },
                new Person { FirstName = "Süheyla"}
            };

            foreach (Person person in persons) 
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    /* 1) Bir nesne bir kere inherit alınabilir ama birden fazla kez implemente edilebilir.
       2) Inherite başa yazılır. Implementler sonra eklenir.
       3) Inheritance base class, implementler interfacedir.
       4) Classların tek başına anlamı vardır, interfacelerin yoktur.
     */
    class Customer:Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
