using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserInstanserKonstruktorer
{
    class Person
    {
        // Klassvariabler
        public string name;
            int age;

        //Konstruktor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;

        }

        // Metod
        public void CelebrateBirthday()
        {
            age++;
        }

        // Metod
        public void Print()
        {
            Console.WriteLine("Name:" + name + " Age:" + age);
        }
    }
}
