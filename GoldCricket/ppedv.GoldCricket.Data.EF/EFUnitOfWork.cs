using ppedv.GoldCricket.Domain;
using ppedv.GoldCricket.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ppedv.GoldCricket.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private EFContext context = new EFContext();

        private IPersonRepository personRepository;
        public IPersonRepository PersonRepository
        {
            get
            {
                if (personRepository == null)
                    personRepository = new EFPersonRepository(context);
                return personRepository;
                //return personRepository = personRepository ?? new EFPersonRepository(context);
            }
        }

        private IDatabaseRepository databaseRepository;
        public IDatabaseRepository DatabaseRepository
        {
            get
            {
                if (databaseRepository == null)
                    databaseRepository = new EFDatabaseRepository(context);
                return databaseRepository;
            }
        }

        public IUniversalRepository<T> GetRepository<T>() where T : Entity
        {
            // Einfache Variante:
            return new EFUniversalRepository<T>(context);
            // Pro-Variante: Nachschauen, ob ich in meinen eigenene Properties bereits ein T-Repository habe
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
