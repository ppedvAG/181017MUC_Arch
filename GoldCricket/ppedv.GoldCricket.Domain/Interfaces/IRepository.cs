using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppedv.GoldCricket.Domain.Interfaces
{
    public interface IRepository
    {
        IQueryable<T> Query<T>() where T : Entity; // Für LINQ-Zugriff im Core-> aus LINQ wird gscheites SQL
        IEnumerable<T> GetAll<T>() where T : Entity;
        T GetByID<T>(int ID) where T : Entity;
        void Add<T>(T item) where T : Entity;
        void Delete<T>(T item) where T : Entity;
        void Update<T>(T item) where T : Entity;
        void Save();
    }
}
