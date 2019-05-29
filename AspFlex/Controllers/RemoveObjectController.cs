using AspFlex.Controllers;
using AspFlex.PassiveView;

namespace AspFlex
{
    public  class RemoveObjectController:BaseController<IRemoveObjectView>
    {
        public RemoveObjectController(IRemoveObjectView view) : base(view)
        {
        }
    }
}