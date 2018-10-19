using ppedv.GoldCricket.Domain;
using ppedv.GoldCricket.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppedv.GoldCricket.Data.EF
{
    // public           -> Überall zugreifbar
    // private          -> Nur in der eigenen Klasse zugreifbar
    // protected        -> Nur in der eigenen Klasse + alle die davon Erben zugreifbar

    // internal         -> Nur in der selben Assembly nutzbar wie public, ausserhalb wie private
    // protected internal -> kombi aus internal und protected
    // private protected -> protected, dass nur für die eigene Assembly gilt

    public class EFUniversalRepository<T> : IUniversalRepository<T> where T : Entity
    {
        public EFUniversalRepository(EFContext context)
        {
            this.context = context;
        }
        protected readonly EFContext context;

        public void Add(T item)
        {
            context.Set<T>().Add(item);
        }

        public void Delete(T item)
        {
            context.Set<T>().Remove(item);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetByID(int ID)
        {
            return context.Set<T>().FirstOrDefault(x => x.ID == ID); // IMMER aus der DB
        }

        public IQueryable<T> Query()
        {
            return context.Set<T>();
        }

        public void Update(T item)
        {
            var loaded = GetByID(item.ID);
            if (loaded != null)
                context.Entry(loaded).CurrentValues.SetValues(item);
        }
    }
}
