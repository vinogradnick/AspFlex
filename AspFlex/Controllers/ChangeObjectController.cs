using System.Windows.Forms;
using AspFlex.PassiveView;

namespace AspFlex.Controllers
{
    public class ChangeObjectController : BaseController<IAddObjectView>
    {
        public ChangeObjectController(IAddObjectView view) : base(view)
        {
        }

        public T Change<T>(T change)
        {
            View.Bind(change);
            if (View.ShowDialog() == DialogResult.OK)
            {
                T data = (T)View.Data;
                return data;
            }

            return default(T);
        }
    }
}