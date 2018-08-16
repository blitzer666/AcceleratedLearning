using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_10._5_Product_list_with_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<int, string>();

            bool running = true;

            while (running)

            {

                Console.Write("Enter product id and name, separate by comma: ");
                string inmatat = Console.ReadLine();
                if (string.IsNullOrEmpty(inmatat))
                {
                    break;
                }
                if (inmatat == "Command:Replace")
                {
                    ReplaceItem();
                }
                        
                string[] products = inmatat.Split(',');

                int id = int.Parse(products[0]);
                string name = (products[1]);

                if (dic.ContainsKey(id))
                {
                    Console.WriteLine("The product list already contains the id " + id);
                    Console.WriteLine("Replace item y/n? ");
                    string replaceItem = Console.ReadLine();
                    continue;
                    
                }
                dic.Add(id, name);

            }
            foreach (var item in dic)
            {
                Console.WriteLine("Product id = " + item.Key + " and name = " + item.Value);
            }
            
        }
        static void ReplaceItem()
        {
            string input = Console.ReadLine();
            while (true)
            {
      
            }
        }


       

        
    }

}


 

        


        





































        //{
         
        //    var dic = new Dictionary<int, string>();
        //    bool running = true;

        //    while (running)
        //    {
        //        Console.Write("Enter product id and name: ");

        //        string userInput = (Console.ReadLine());
        //        string[] products = userInput.Split(',');

        //        if (String.IsNullOrEmpty(userInput))
        //        {
        //            break;
        //        }

        //        int id = userInput[0];
                
        //    }





            //var product = new Dictionary<int, string>();
            //product.Add('1', "Tennisball");
            //product.Add('2', "Racket");
            //product.Add('3', "Shoes");
            //product.Add('4', "Apple");

            //foreach (var item in product)
            //{
            //    /*1(item.Key);
            //    bar(item.Value);
            //    */
            //}



            //Console.WriteLine($"Product id= {dic['1']}");
            //Console.WriteLine($"Product id= {dic['2']}");
            //Console.WriteLine($"Product id= {dic['3']}");
            //Console.WriteLine($"Product id= {dic['4']}");
            //Console.WriteLine();


            //if (dic.ContainsKey('B'))
            //    Console.WriteLine("Det finns en priskategori som heter B");
            //if (!dic.ContainsKey('D'))
            //    Console.WriteLine("Det finns ingen priskategori som heter D");
            //Console.WriteLine();
            //dic.Add('D', 150);
            //dic.Remove('B');
            // dic['A'] = 20;
            //Console.WriteLine("Nu har priskategori D lagts till och priskategori B tagits bort");
            //Console.WriteLine("Priskategori A kostar nu 20kr");
        
        //static  void DisplayProductDictionary(products)
        //{

        //}
       
    



    
        
        



//        {
//            while (true)
//            {
//                Console.WriteLine("Enter product id and name: ");
//                string productList = Console.ReadLine();
//                try
//                {
//                    string[] productArray = BuildProductDictionary(productList);

//                    Console.WriteLine("");
//                    break;

//                }
//                catch (ArgumentException ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }
//            }


//        }
//    }
//}


