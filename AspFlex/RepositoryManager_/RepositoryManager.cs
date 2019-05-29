using System;
using System.Diagnostics;
using AspFlex.Controllers;

namespace AspFlex.RepositoryManager_
{
    public class RepositoryManager:IRepositoryManager
    {
        private readonly IRepository<Fider> _fRepository;
        private readonly IRepository<Tp> _tpRepository;
        
        private readonly IRepository<Line> _lineRepository;
        private readonly IRepository<Customer> _customerRepository;
        

        public RepositoryManager()
        {
            _fRepository = new FiderRepository();
            _tpRepository = new TpRepository();
            
            _lineRepository = new LineRepository();
            _customerRepository = new CustomerRepository();
        }

        public  void Insert(object entity)
        {
            switch (entity)
            {
                case Fider fider:
                    _fRepository.Add(fider);
                    break;
                case Tp tp:
                    _tpRepository.Add(tp);
                    break;
                
                case Line line:
                    _lineRepository.Add(line);
                    break;
                case Customer customer:
                    _customerRepository.Add(customer);
                    break;
                
                 

            }
            Debug.WriteLine("Add");
           Save();

        }

        public  void Save()
        {
            try
            {
                 DbSingleton.Db.SaveChanges();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
            
        }
        public  void Update(object entity)
        {

            switch (entity)
            {
                case Fider fider:
                    _fRepository.Update(fider);
                    break;
                case Tp tp:
                    _tpRepository.Update(tp);
                    break;
                
                    break;
                case Line line:
                    _lineRepository.Update(line);
                    break;
                case Customer customer:
                    _customerRepository.Update(customer);
                    break;
                


            }
            Save();

        }
        public  void Remove(object entity)
        {
            switch (entity)
            {
                case Fider fider:
                    _fRepository.Remove(fider);
                    break;
                case Tp tp:
                    _tpRepository.Remove(tp);
                    break;
               
                    break;
                case Line line:
                    _lineRepository.Remove(line);
                    break;
                case Customer customer:
                    _customerRepository.Remove(customer);
                    break;
                

            }
            Save();

        }
    }
}