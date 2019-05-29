using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using AspFlex.Controllers;

namespace AspFlex.RepositoryManager_
{
    public class FiderRepository : IRepository<Fider>
    {
        public void Add(Fider model) => DbSingleton.Db.FiderSet.Add(model);

        public void Remove(Fider model) => DbSingleton.Db.FiderSet.Remove(model);

        public void Update(Fider model) => DbSingleton.Db.Entry(model).State = EntityState.Modified;

        public Fider GetModel(int id) => DbSingleton.Db.FiderSet.FirstOrDefault(el => el.Id == id);

        public Fider GetModel(Func<Fider, bool> predicate) => DbSingleton.Db.FiderSet.FirstOrDefault(predicate);

        public List<Fider> GetList(Func<Fider, bool> predicate) => DbSingleton.Db.FiderSet.Where(predicate).ToList();

        public List<Fider> All() => DbSingleton.Db.FiderSet.ToList();
    }
}