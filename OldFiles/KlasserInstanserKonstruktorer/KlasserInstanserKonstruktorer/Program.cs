using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserInstanserKonstruktorer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Bo", 30);
            Person person2 = new Person("Li", 40);

            person1.CelebrateBirthday();
            person1.CelebrateBirthday();
            person1.Print();

            person2.name = "An";
            person2.Print();

        }
    }
}
