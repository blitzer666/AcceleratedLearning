using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Http;

namespace Coutry
{
    class Program
    {
        static void Main(string[] args)
        {
            new App().Menu();
            //ApiToSql();
            //DataForming allData = new DataForming();
          

        }

        private static void ApiToSql()
        {
            DataForming allData = new DataForming();
            allData.GettingCountryNameFromApi();
            allData.GettingTaxInformationFromApi();
            allData.UpdataSqlDataBaseFromApi();


        }
    }
}
