using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Http;
using System.Text;

namespace Coutry
{
    class Commad
    {
        public void GetAllTaxInformationFromApi()
        {
            using (var webClient1 = new HttpClient())
            {


                string content1 = webClient1.GetAsync("https://jsonvat.com/").Result.Content.ReadAsStringAsync().Result;
               // string con = @"Server= (localdb)\mssqllocaldb;Database=EuroTaxes";
                //var myList = new List<object>();
                string con = @"Server= (localdb)\mssqllocaldb;Database=EuroTaxes";
                string sql = @"insert into vatinformation(standard,super_reduced,reduced,reduced1,reduced2,parking,taxdate)
                     values(@standard,@super_reduced,@reduced,@reduced1,@reduced2,@parking,@taxdate)";

                var xs = JsonConvert.DeserializeObject<Rootobject>(content1);
                using (SqlConnection conncetion = new SqlConnection(con))
                using (SqlCommand commad = new SqlCommand(sql, conncetion))
                {
                    conncetion.Open();
                    foreach (var item in xs.rates)
                    {

                        foreach (var item1 in item.periods)
                        {
                            commad.Parameters.Add(new SqlParameter("@standard", item1.rates.standard));
                            commad.Parameters.Add(new SqlParameter("@super_reduced", item1.rates.super_reduced));
                            commad.Parameters.Add(new SqlParameter("@reduced", item1.rates.reduced));
                            commad.Parameters.Add(new SqlParameter("@reduced1", item1.rates.reduced1));
                            commad.Parameters.Add(new SqlParameter("@reduced2", item1.rates.reduced2));
                            commad.Parameters.Add(new SqlParameter("@parking", item1.rates.parking));
                            commad.Parameters.Add(new SqlParameter("@taxdate", item1.effective_from));
                            commad.ExecuteNonQuery();
                        
                          


                        }
                    }
                    

                }


                

            }
        }

        internal void GettingCountryNameFromApi()
        {
            using (var webClient1 = new HttpClient())
            {
                string content1 = webClient1.GetAsync("https://jsonvat.com/").Result.Content.ReadAsStringAsync().Result;
                string con = @"Server= (localdb)\mssqllocaldb;Database=EuroTaxes";
                string sql = @"insert into countrynames(country)
                     values(@country)";
                var xs = JsonConvert.DeserializeObject<Rootobject>(content1);
                using (SqlConnection conncetion = new SqlConnection(con))
                using (SqlCommand commad = new SqlCommand(sql, conncetion))
                {
                    conncetion.Open();
                    foreach (var item in xs.rates)
                    {
                        commad.Parameters.Add(new SqlParameter("@country", item.name));
                        commad.ExecuteNonQuery();
                    }
                }

            }
        }
    }
}
