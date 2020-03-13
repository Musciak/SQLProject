using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;


namespace SQLProject
{
    public class DataAccess
    {
        public List<Customer> GetCustomers(string lastName)
        {
            // as soon as you done with using this statement, destroy this connection, using prevents from unappropriate killing the connection with SQL server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TESTSQLDATABASE")))
            {
                // stworzona została tu klasa dynamiczna, dowołujemy się do stored procedured stworzonym w SQL Managerze
               var output= connection.Query<Customer>("dbo.Customer_GetByLastName @LastName", new { LastName = lastName }).ToList();
               return output;
            }

        }

        public void InsertPerson(string firstName, string LastName, string City, string Country, string Phone)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TESTSQLDATABASE")))
            { 
                //Customer newCustomer = new Customer { FirstName = firstName, LastName = LastName, City = City, Country = Country, Phone = Phone };
                List<Customer> customer = new List<Customer>();
                customer.Add(new Customer { FirstName = firstName, LastName = LastName, City = City, Country = Country, Phone = Phone });

                connection.Execute("dbo.Customer_Insert @FirstName, @LastName, @City, @Country, @Phone", customer);
            }
        }
    }
}
