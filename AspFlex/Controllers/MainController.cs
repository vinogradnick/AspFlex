using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AspFlex.PassiveView;
using AspFlex.RepositoryManager_;

namespace AspFlex.Controllers
{
   
    public class MainController:BaseController<IMainForm>
    {
        private object SelectedObject => View.SelectedObject;
        private readonly CreateObjectController _createObjectController;
        private readonly ChangeObjectController _changeObjectController;
        private readonly RequestPageController _requestPageController;
        private readonly IRepositoryManager _repository;
        public void Subscribe()
        {
            
            View.CreateFider += Create<Fider>;
            View.CreateTp += Create<Tp>;
            View.CreateCustomer += Create<Customer>;
            View.CreateLine += Create<Line>;
            View.CreateSection += Create<Line>;
            View.Remove += Remove;
            View.ChangeEvent += Change;
            View.FillDatabase += FillDatabase;
            View.CustomerBySelectedFider +=OnCustomerBySelectedFider;
            View.CustomerBySelectedTp += OnCustomerBySelectTp;
            View.TpListConnectedFider += OnTpListConnected;
        }

        private void Remove(object sender, EventArgs e)
        {
            _repository.Remove(SelectedObject);
        }

        private void ActionSelected<T>(Action action)
        {
            if (SelectedObject is T entity)
                action.Invoke();
            else
                MessageBox.Show("Упс \n Вы выбрали неверный объект");
        }
        private void OnTpListConnected(object sender, EventArgs e)
        {
            ActionSelected<Fider>(() =>
            {
                var source = from tp in DbSingleton.Db.TpSet where tp.FiderId == ((Fider)SelectedObject).Id select tp;
                _requestPageController.Bind(source.ToList());
            });
        }

        private void OnCustomerBySelectTp(object sender, EventArgs e)
        {
            ActionSelected<Tp>(() =>
            {
               
                var bindSource = from selected in DbSingleton.Db.CustomerSet
                    where selected.LineId == ((Tp)SelectedObject).Id
                    select selected;
                _requestPageController.Bind(bindSource.ToList());
            });
            
        }

        private void OnCustomerBySelectedFider(object sender, EventArgs e)
        {
            ActionSelected<Tp>(() =>
            {
               
                var bindSource = from selected in DbSingleton.Db.CustomerSet
                                 where selected.LineId == ((Tp)SelectedObject).Id
                    select selected;
                _requestPageController.Bind(bindSource.ToList());
            });
           
          
        }

        private  void FillDatabase(object sender, EventArgs e)
        {
         Fill(CreateTp);
        }

        private void Fill(Action action)
        {
            for (int i = 0; i < 5; i++) action.Invoke();
            View.UpdateTable();
        }

        private void CreateLine()
        {
            Line line = new Line()
            {

                Name = Faker.StringFaker.Alpha(10),
                Power = Faker.NumberFaker.Number(128, 1024),
                Voltage = Faker.NumberFaker.Number(110, 510),
                Geocode = Faker.LocationFaker.ZipCode(),
              
            };
            _repository.Insert(line);
        }
        private void CreateCustomer()
        {
            Customer customer = new Customer
            {
                Id = Faker.NumberFaker.Number(100,10000000),
                Name = Faker.NameFaker.Name(),
                ObjectName = Faker.CompanyFaker.Name(),
                PlaceInstall = Faker.LocationFaker.ZipCode(),
               
                
            };
            _repository.Insert(customer);
        }
        private void CreateTp()
        {

            Tp fider = new Tp
            {
                Id = Faker.NumberFaker.Number(100, 10000000),
                Name = Faker.StringFaker.Alpha(10),
                Power = Faker.NumberFaker.Number(128, 1024),
                Voltage = Faker.NumberFaker.Number(110, 510),
                Geocode = Faker.LocationFaker.ZipCode(),
                
            };

            _repository.Insert(fider);
        }
        private void CreateFider()
        {
            Fider fider = new Fider
            {
                Id = Faker.NumberFaker.Number(100, 10000000),
                Name = Faker.StringFaker.Alpha(10),
                Power = Faker.NumberFaker.Number(128, 1024),
                Voltage = Faker.NumberFaker.Number(110, 510),
                Geocode = Faker.LocationFaker.ZipCode()
            };

            _repository.Insert(fider);
        }

        private void Create<T>(object sender, EventArgs e) where T : new()
        {
            try
            {
                _createObjectController.Create(new T());
                View.UpdateTable();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Change(object sender, EventArgs e)
        {
            try
            {
                _repository.Update(_changeObjectController.Change(SelectedObject));
                View.UpdateTable();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Request(object sender,EventArgs e)
        {
            
            
        }

        public MainController(IMainForm view, CreateObjectController createObjectController, ChangeObjectController changeObjectController, RequestPageController requestPageController, IRepositoryManager repository) : base(view)
        {
            this._createObjectController = createObjectController;
            _changeObjectController = changeObjectController;
            _requestPageController = requestPageController;
            this._repository = repository;
            Subscribe();
        }
    }
}
