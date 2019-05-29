using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspFlex.PassiveView;

namespace AspFlex.Controllers
{
    public class RequestPageController:BaseController<IRequestPage>
    {
        public object SelectedObject => View.SelectedObject;
        public RequestPageController(IRequestPage view) : base(view)
        {
        }

        public void Bind(dynamic dataStore)
        {
            View.Bind(dataStore);
            View.ShowDialog();
        }
        public void Bind<T>(Func<T,bool> func)
        {
            foreach (var property in DbSingleton.Db.GetType().GetProperties())
            {
                if (typeof(T) == property.PropertyType)
                {
                    dynamic prop = property.GetValue(DbSingleton.Db);
                    View.Bind(prop.Where(func).ToList());
                    
                }
                
            }
        }
    }
}
