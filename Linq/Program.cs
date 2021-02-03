using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
            {
                new Person("Nisse", 20),
                new Person("Pelle" ,65),
                new Person("Olle" , 66),
                new Person("Sara" , 54),
                new Person("Ida" ,  36),
                new Person("Fia",   45),
                new Person("Sopia", 32),
            };

            var numbersArray = Enumerable.Range(1, 10).ToArray();
            var numbersList = Enumerable.Range(1, 10).ToList();

            string st = "Hej!";
            string result1 = st.Add("Banan");
            string result2 = st.Add("Banana", "split", "är", "gott");

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            numbersArray.Print();
            numbersList.Print();
            persons.Print();
        }
    }
}
