using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempel_på_Property
{
    class Animal
    {
        public string AnimalBreed { get; set; } // skriv in prop + TAB för property
        public int AnimalWeight { get; set; }

        
        static void Main(string[] args)
        {
            var animal1 = new Animal();
            var animal2 = new Animal();
            var animal3 = new Animal();

            animal1.AnimalBreed = "zebra";
            animal1.AnimalWeight = 158;

            animal2.AnimalBreed = "Monkey";
            animal2.AnimalWeight = 22;

            animal3.AnimalBreed = "Elephant";
            animal3.AnimalWeight = 800;

            Console.WriteLine("The animal is of the breed " + animal1.AnimalBreed + " and weights " + animal1.AnimalWeight);
            Console.WriteLine();
            Console.WriteLine("The animal is of the breed " + animal2.AnimalBreed + " and weights " + animal2.AnimalWeight);
            Console.WriteLine();
            Console.WriteLine("The animal is of the breed " + animal3.AnimalBreed + " and weights " + animal3.AnimalWeight);


        }
    }
}
