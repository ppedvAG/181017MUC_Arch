using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppedv.GoldCricket.Domain.Interfaces
{
    public interface IUniversalRepository<T> where T : Entity
    {
        IQueryable<T> Query();
        IEnumerable<T> GetAll();
        T GetByID(int ID);
        void Add(T item);
        void Delete(T item);
        void Update(T item);
    }
}
