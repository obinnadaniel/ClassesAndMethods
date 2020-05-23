using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Daniel";
            person.Age = 32;
            person.HasPet = true;

            person.Greeting();
            Console.ReadLine();
        }
    }
}
