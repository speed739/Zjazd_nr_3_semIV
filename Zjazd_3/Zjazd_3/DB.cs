using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Zjazd_3
{
    public class DB
    {
        public void Select(IDbConnection connection)
        {
            var sql = "SELECT * FROM Region";
            var result = connection.Query<Region>(sql);
            foreach (var item in result)
            {
                Console.WriteLine($"{ item.Region_ID}: { item.RegionDescriptionity}");
            }
        }
        public void Insert(IDbConnection connection,string id,string description)
        {

            var sql = "INSERT INTO Region(RegionID,RegionDescription) VALUES(@id,@desc)";
            var changed = connection.Execute(sql,
                new
                {
                    id = id,
                    desc = description

                }); 
            Console.WriteLine("Zmieniono" + changed);
        }
        public void Delete(IDbConnection connection,Region region)
        {
           
            var sql = "DELETE FROM Region " +
                      "WHERE RegionID =" + region.Region_ID;
            var changed = connection.Execute(sql,
                new
                {
                    RegionID = region.Region_ID,

                });
           Console.WriteLine("Usunięto - " + changed);

        }
    }
}
