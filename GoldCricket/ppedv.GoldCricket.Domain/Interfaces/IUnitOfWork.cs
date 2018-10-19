using System;
using System.Collections.Generic;
using System.Text;

namespace ppedv.GoldCricket.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        // Spezial-Variante
        IPersonRepository PersonRepository { get; }
        IDatabaseRepository DatabaseRepository { get; }
        // Generelle-Variante
        IUniversalRepository<T> GetRepository<T>() where T : Entity;
        void Save();
    }
}
