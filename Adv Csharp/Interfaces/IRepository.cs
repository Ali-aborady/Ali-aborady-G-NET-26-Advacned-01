using System;
using System.Collections.Generic;
using System.Text;

namespace Adv_Csharp.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Remove(int id);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
