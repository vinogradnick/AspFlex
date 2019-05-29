using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using AspFlex.Controllers;

namespace AspFlex.RepositoryManager_
{
    public class LineRepository : IRepository<Line>
    {
        public void Add(Line model) => DbSingleton.Db.LineSet.Add(model);

        public void Remove(Line model) => DbSingleton.Db.LineSet.Remove(model);

        public void Update(Line model) => DbSingleton.Db.Entry(model).State = EntityState.Modified;

        public Line GetModel(int id) => DbSingleton.Db.LineSet.FirstOrDefault(el => el.Id == id);

        public Line GetModel(Func<Line, bool> predicate) => DbSingleton.Db.LineSet.FirstOrDefault(predicate);

        public List<Line> GetList(Func<Line, bool> predicate) => DbSingleton.Db.LineSet.Where(predicate).ToList();

        public List<Line> All() => DbSingleton.Db.LineSet.ToList();
    }
}