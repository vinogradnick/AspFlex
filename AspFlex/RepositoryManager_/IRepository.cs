using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AspFlex.Controllers;

namespace AspFlex.RepositoryManager_
{
    public interface IRepository<T>
    {
        void Add(T model);
        void Remove(T model);
        void Update(T model);
        T GetModel(int id);
        T GetModel(Func<T, bool> predicate);
        List<T> GetList(Func<T, bool> predicate);
        List<T> All();
       
    }
}
