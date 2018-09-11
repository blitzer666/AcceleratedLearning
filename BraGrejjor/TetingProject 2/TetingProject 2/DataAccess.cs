using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace TetingProject2
{
    class DataAccess
    {       

        public List<Sql> GetOrderDates()
        {
            string sql = @"Select CustomerName From Customers";
            string con = @"Server=(localdb)\mssqllocaldb;Database=Company";
            //string sql = @"Select CustomerName From Customers";//@"Select orders.orderID, customers.customername, orders.orderdate
            //from orders
            //join Customers on orders.customerid = customers.customerID";

            using (SqlConnection connection = new SqlConnection(con))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                var result = new List<Sql>();
                while (reader.Read())
                {
                    var sq = new Sql();

                    //int orderID = reader.GetSqlInt32(0).Value;
                    string CustomerName = reader.GetSqlString(1).Value;
                   // int orderdate = reader.GetSqlInt32(2).Value;

                   // sq.orderID = orderID;
                    sq.CustomerName = CustomerName;
                   // sq.orderdate = orderdate;
                    

                    result.Add(sq);
                }
                return result;
            }
            
        }


    }
}
