using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AspFlex.Controllers;

namespace AspFlex.RepositoryManager_
{
    public static class RequestMN
    {
        
       
        public static Tp GetTp(int id)
        {
            return (from _tp in DbSingleton.Db.TpSet
               
                where _tp.Id == id
                select _tp
                ).FirstOrDefault();
        }

        public static Customer GetCustomer(int id)
        {
            Customer result = (from customer in DbSingleton.Db.CustomerSet
                where customer.Id == id
                select customer).SingleOrDefault();
            return result;

        }
        public static Fider GetFider(int id) => (from fider in DbSingleton.Db.FiderSet where fider.Id == id select fider).FirstOrDefault();

        public static Line GetLine(int id)
        {
            var res = from line in DbSingleton.Db.LineSet
                
                where line.Id == id
                select new Line()
                {
                    Id = line.Id,
                    Name = line.Name,
                    Geocode = line.Geocode,
                    Voltage = line.Voltage,
                    Power = line.Power,
                   
                };
            return res.SingleOrDefault();
        }
    }
}
