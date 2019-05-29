using System.Collections.Generic;
using AspFlex.PassiveView;

namespace AspFlex.Controllers
{
    public abstract class BaseController<TView>
    {
        
        protected BaseController(TView view)
        {
            View = view;
            
        }

       

        public TView View { get; }
    }
}