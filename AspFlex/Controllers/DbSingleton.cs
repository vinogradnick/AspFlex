using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspFlex.Controllers
{
    public class DbSingleton
    {
        private static ElectricityContainer container;

        public static ElectricityContainer Db
        {
            get
            {
                if (container == null) CreateSingleton();

                return container;
            }
        }

        public DbSingleton()
        {
            
        }

        public static void CreateSingleton() => container=new ElectricityContainer();
    }
}
