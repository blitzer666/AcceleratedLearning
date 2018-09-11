using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint03_Listor___Peter_Hellberg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = MultipleBy100AndAdd3(new List<int> {2, 8, 3, 11 });

            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }

        public static List<int> MultipleBy100AndAdd3(List<int> list)

        
        {
            var addResultList = new List<int>();
            foreach (int number in list)
            {

                int xnumber = number * 100 + 3;
                addResultList.Add(xnumber);
            }
            return addResultList;
        }




    }
    
   
    
}
