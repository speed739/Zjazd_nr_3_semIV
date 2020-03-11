using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;

namespace Zjazd_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Region test = new Region();
            test.Region_ID = "300";
            test.RegionDescriptionity = "RegionZ";

            var constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using var connection = new SqlConnection(constring);
            var db = new DB();
            db.Select(connection);
            db.Insert(connection, "300", "RegionZ");
            db.Delete(connection,test);
        }
    }
}
