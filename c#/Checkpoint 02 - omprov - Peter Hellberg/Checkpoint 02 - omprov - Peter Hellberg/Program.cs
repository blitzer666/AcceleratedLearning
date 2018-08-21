using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint_02___omprov___Peter_Hellberg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Furniture name and price separated by comma: ");

            var userInput = Console.ReadLine();

            Console.WriteLine();

           
            string[] furnitureArray = userInput.Split(new[]{ ':' }, StringSplitOptions.RemoveEmptyEntries);

            
            var allFurniture = new List<Furniture>();

            foreach (string furnitureString in furnitureArray)
            {
                var furniture = new Furniture();
                string[] pair = furnitureString.Trim().Split(',');
                string nameOftheFurniture = pair[0];
                int priceOfFurniture = int.Parse(pair[1].Replace("Kr", ""));

                furniture.Name = nameOftheFurniture;
                furniture.Price = Convert.ToInt32(priceOfFurniture);

               allFurniture.Add(furniture);
            }

            if (allFurniture.Count > 0)
            {


                Furniture cheapestRoom = allFurniture.OrderBy(x => x.Price).First();
                Console.WriteLine("Den billigaste möbeln är " + cheapestRoom.Name + " som kostar " + cheapestRoom.Price + " Kr");
            }

        }
        public class Furniture
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
    }
}
