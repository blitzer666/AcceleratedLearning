using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace Coutry
{
    public class FormuleringSqlData
    {
        public void PrintingDataInColums()
        {
            Console.Write("Enter tabel name:");
            string tabelname = Console.ReadLine();
            Console.Write("Enter colum name:");
            string columname = Console.ReadLine();
            string con = @"Server= (localdb)\mssqllocaldb;Database=gettaxapi";
            string sql = "select " + columname + " from " + tabelname;
            using (SqlConnection conncetion = new SqlConnection(con))
            using (SqlCommand commad = new SqlCommand(sql, conncetion))
            {
                conncetion.Open();
                SqlDataReader reader = commad.ExecuteReader();
                Console.WriteLine("\n".PadRight(10) + "*" + columname + "*\n", Color.DeepPink);
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine("".PadRight(10) + reader[i] + " ", Color.Blue);
                    }
                }


            }

        }
        public void PrintAllDataInDataBase()
        {
            string con = @"Server= (localdb)\mssqllocaldb;Database=gettaxapi";
            string sql = @"select  country,standard,super_reduced,reduced,reduced1,reduced2,parking,taxdate,VatInformation.countryCode from
                          VatInformation left join CountryNames on VatInformation.countryNamesId=CountryNames.Id";
            using (SqlConnection conncetion = new SqlConnection(con))
            using (SqlCommand commad = new SqlCommand(sql, conncetion))
            {
                conncetion.Open();
                SqlDataReader reader = commad.ExecuteReader();
                Console.WriteLine("country        Standard      SuperReduced  Reduced      Reduced1     Reduced2     Parking      Taxdate      CountryCode", Color.DeepPink);
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i].ToString().PadRight(15), Color.Blue);
                    }
                    Console.WriteLine();
                }
            }

        }
        public void UpDateSingelColumsInDataBase()
        {
            System.Console.WriteLine("Enter Tabel name");
            string tName = Console.ReadLine();
            System.Console.WriteLine("Enter colum Name");
            string cName = Console.ReadLine();
            System.Console.WriteLine("Enter value");
            object cValue = Console.ReadLine();
            System.Console.WriteLine("enter Id where you wanna update");
            int id = int.Parse(Console.ReadLine());

            string con = @"Server= (localdb)\mssqllocaldb;Database=gettaxapi";
            string sql = "UPDATE " + tName + " SET " + cName + " = @name1 WHERE Id = @id";

            using (SqlConnection conncetion = new SqlConnection(con))
            using (SqlCommand commad = new SqlCommand(sql, conncetion))
            {
                conncetion.Open();

                commad.Parameters.Add(new SqlParameter("name1", cValue));
                commad.Parameters.Add(new SqlParameter("id", id));
                commad.ExecuteNonQuery();

            }

        }
        public void InsertDetailInToTabel(string tableName, List<string> columNames, List<object> columnValues)
        {
            //string con = @"Server= (localdb)\mssqllocaldb;Database=churchs;Trusted_Connection=true";
            // string sql = "insert into blogpost(title,author) values(@0,@1)";


            List<string> parameters = new List<string>();

            for (int i = 0; i < columNames.Count; i++)
            {
                parameters.Add("@p" + i);
            }

            string columnNamesAsString = string.Join(",", columNames);
            string parametersAsString = string.Join(",", parameters);
            string con = @"Server= (localdb)\mssqllocaldb;Database=gettaxapi";
            string sql = "insert into " + tableName + " (" + columnNamesAsString + ") values(" + parametersAsString + ")";


            using (SqlConnection conncetion = new SqlConnection(con))
            using (SqlCommand commad = new SqlCommand(sql, conncetion))
            {
                conncetion.Open();

                for (int i = 0; i < columNames.Count; i++)
                {
                    commad.Parameters.Add(new SqlParameter(parameters[i], columnValues[i]));
                    commad.ExecuteNonQuery();
                    //commad.Parameters.Add(new SqlParameter("name1", cValue));
                }



            }
        }
        public void AskingForInsertDetail()
        {
            //InsertDetailInToTabel("Locations", new List<string> {  "Name" }, new List<object> { "Kalle" });
            Console.WriteLine("enter table name");
            string tInput = Console.ReadLine();
            Console.WriteLine("enter colums name(separate by comma)");
            string cInput = Console.ReadLine();
            Console.WriteLine("enter values as order by colum names(also separte by comma)");
            string vInput = Console.ReadLine();

            var cInputSplit = cInput.Split(',').ToList();

            var vInputSplit = vInput.Split(',').Select(x => (object)x).ToList();
            InsertDetailInToTabel(tInput, cInputSplit, vInputSplit);
        }
    }
}
