using System.Windows.Forms;
using AspFlex.PassiveView;
using AspFlex.RepositoryManager_;

namespace AspFlex.Controllers
{
    public class CreateObjectController : BaseController<IAddObjectView>
    {
        private readonly IRepositoryManager _repository;

        public CreateObjectController(IAddObjectView view, IRepositoryManager repository) : base(view)
        {
            _repository = repository;
        }

        public void Create<T>(T model)
        {
            View.Bind(model);
            if (View.ShowDialog() == DialogResult.OK)
                _repository.Insert(View.Data);

        }
    }
}