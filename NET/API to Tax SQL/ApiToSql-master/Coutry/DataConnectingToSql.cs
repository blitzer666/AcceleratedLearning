using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coutry
{
    public class DataConnectingToSql
    {

        public void SendingCountriesToSql(List<string> countryNameList)
        {
           
            for (int i = 0; i < countryNameList.Count; i++)
            {
                string con = @"Server= (localdb)\mssqllocaldb;Database=gettaxapi";
                string sql = @"insert into countrynames(country,countrycode)
                         values(@country,@countrycode)";
                using (SqlConnection conncetion = new SqlConnection(con))
                using (SqlCommand commad = new SqlCommand(sql, conncetion))
                {
                    conncetion.Open();
                    commad.Parameters.Add(new SqlParameter("@country", countryNameList[i]));
                    commad.Parameters.Add(new SqlParameter("@country", countryNameList[i]));
                    commad.ExecuteNonQuery();
                }

            }
        }

       
        
    }
}
