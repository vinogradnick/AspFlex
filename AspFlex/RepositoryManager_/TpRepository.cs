using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using AspFlex.Controllers;

namespace AspFlex.RepositoryManager_
{
    public class TpRepository : IRepository<Tp>
    {
        public void Add(Tp model) => DbSingleton.Db.TpSet.Add(model);

        public void Remove(Tp model) => DbSingleton.Db.TpSet.Remove(model);

        public void Update(Tp model) => DbSingleton.Db.Entry(model).State = EntityState.Modified;

        public Tp GetModel(int id) => DbSingleton.Db.TpSet.FirstOrDefault(el => el.Id == id);

        public Tp GetModel(Func<Tp, bool> predicate) => DbSingleton.Db.TpSet.FirstOrDefault(predicate);

        public List<Tp> GetList(Func<Tp, bool> predicate) => DbSingleton.Db.TpSet.Where(predicate).ToList();

        public List<Tp> All() => DbSingleton.Db.TpSet.ToList();
    }
}