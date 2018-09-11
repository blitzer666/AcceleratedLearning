using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Coutry
{
    public class DataForming
    {
        public void GettingCountryNameFromApi()
        {
            List<string> mylist = new List<string>();
            using (var webClient1 = new HttpClient())
            {

                
                string content1 = webClient1.GetAsync("https://jsonvat.com/").Result.Content.ReadAsStringAsync().Result;
                var xs = JsonConvert.DeserializeObject<Rootobject>(content1);
                

                foreach (var item in xs.rates)
                {
                    string con = @"Server= (localdb)\mssqllocaldb;Database=gettaxapi";
                    string sql = @"insert into countrynames(country,countrycode)
                         values(@country,@countrycode)";
                    using (SqlConnection conncetion = new SqlConnection(con))
                    using (SqlCommand commad = new SqlCommand(sql, conncetion))
                    {
                        conncetion.Open();
                        commad.Parameters.Add(new SqlParameter("@country", item.name));
                        commad.Parameters.Add(new SqlParameter("@countrycode", item.country_code));
                        commad.ExecuteNonQuery();
                    }
                   
                }
            }
            
        }

        public void UpdataSqlDataBaseFromApi()
        {
            using (var webClient1 = new HttpClient())
            {


                string content1 = webClient1.GetAsync("https://jsonvat.com/").Result.Content.ReadAsStringAsync().Result;
                var xs = JsonConvert.DeserializeObject<Rootobject>(content1);


                foreach (var item in xs.rates)
                {

                    foreach (var item1 in item.periods)
                    {
                        string con = @"Server= (localdb)\mssqllocaldb;Database=gettaxapi";
                        string sql = @" update VatInformation
                                     set vatinformation.countryNamesId=CountryNames.Id
                                     from VatInformation inner join CountryNames on
                                     VatInformation.countryCode=CountryNames.CountryCode";
                        using (SqlConnection conncetion = new SqlConnection(con))
                        using (SqlCommand commad = new SqlCommand(sql, conncetion))
                        {
                         
                            conncetion.Open();
                           
                            commad.ExecuteNonQuery();
                            
                        }
                    }
                }
            }

        }

        public void GettingTaxInformationFromApi()
        {
            //List<object> mylist = new List<object>();
            using (var webClient1 = new HttpClient())
            {


                string content1 = webClient1.GetAsync("https://jsonvat.com/").Result.Content.ReadAsStringAsync().Result;
                var xs = JsonConvert.DeserializeObject<Rootobject>(content1);


                foreach (var item in xs.rates)
                {

                    foreach (var item1 in item.periods)
                    {
                        string con = @"Server= (localdb)\mssqllocaldb;Database=gettaxapi";
                        string sql = @"insert into vatinformation(standard,super_reduced,reduced,reduced1,reduced2,parking,taxdate,countrycode)
                        values(@standard,@super_reduced,@reduced,@reduced1,@reduced2,@parking,@taxdate,@countrycode)";
                        using (SqlConnection conncetion = new SqlConnection(con))
                        using (SqlCommand commad = new SqlCommand(sql, conncetion))
                        {
                            //var vInputSplit = cInput.Split(',').Select(x => (object)x).ToList();
                            conncetion.Open();
                            commad.Parameters.Add(new SqlParameter("@standard", item1.rates.standard));
                            commad.Parameters.Add(new SqlParameter("@super_reduced", item1.rates.super_reduced));
                            commad.Parameters.Add(new SqlParameter("@reduced", item1.rates.reduced));
                            commad.Parameters.Add(new SqlParameter("@reduced1", item1.rates.reduced1));
                            commad.Parameters.Add(new SqlParameter("@reduced2", item1.rates.reduced2));
                            commad.Parameters.Add(new SqlParameter("@parking", item1.rates.parking));
                            commad.Parameters.Add(new SqlParameter("@taxdate", item1.effective_from));
                            commad.Parameters.Add(new SqlParameter("@countrycode", item.country_code));
                            commad.ExecuteNonQuery();
                            
                        }
                    }
                }
            }
           
        }
    }
}
