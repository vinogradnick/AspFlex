using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using AspFlex.Controllers;

namespace AspFlex.RepositoryManager_
{
    public class CustomerRepository : IRepository<Customer>
    {
        public void Add(Customer model) => DbSingleton.Db.CustomerSet.Add(model);

        public void Remove(Customer model) => DbSingleton.Db.CustomerSet.Remove(model);

        public void Update(Customer model) =>DbSingleton.Db.Entry(model).State = EntityState.Modified;

        public Customer GetModel(int id) => DbSingleton.Db.CustomerSet.FirstOrDefault(el => el.Id == id);

        public Customer GetModel(Func<Customer, bool> predicate) => DbSingleton.Db.CustomerSet.FirstOrDefault(predicate);

        public List<Customer> GetList(Func<Customer, bool> predicate) => DbSingleton.Db.CustomerSet.Where(predicate).ToList();

        public List<Customer> All() => DbSingleton.Db.CustomerSet.ToList();
    }
}