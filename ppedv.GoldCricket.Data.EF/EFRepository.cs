using ppedv.GoldCricket.Domain;
using ppedv.GoldCricket.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppedv.GoldCricket.Data.EF
{
    public class EFRepository : IRepository
    {
        // Controllfreak-Antipattern:
        private EFContext context = new EFContext();

        public void Add<T>(T item) where T : Entity
        {
            context.Set<T>().Add(item);
        }

        public void Delete<T>(T item) where T : Entity
        {
            context.Set<T>().Remove(item);
        }

        public IEnumerable<T> GetAll<T>() where T : Entity
        {
            return context.Set<T>().ToList();
        }

        public T GetByID<T>(int ID) where T : Entity
        {
            // 2 Möglichkeiten

            // return context.Set<T>().Find(ID); // Find() nimmt sich auch Elemente aus dem Cache raus !
            // Wenn man das ohne Cache haben will:
            return context.Set<T>().FirstOrDefault(x => x.ID == ID); // IMMER aus der DB
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update<T>(T item) where T : Entity
        {
            var loaded = GetByID<T>(item.ID);
            if (loaded != null)
                context.Entry(loaded).CurrentValues.SetValues(item);
        }
    }
}
