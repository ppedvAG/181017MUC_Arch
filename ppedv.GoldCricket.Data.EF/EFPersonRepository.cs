using ppedv.GoldCricket.Domain;
using ppedv.GoldCricket.Domain.Interfaces;
using System;
using System.Linq;
using System.Text;

namespace ppedv.GoldCricket.Data.EF
{
    public class EFPersonRepository : EFUniversalRepository<Person>, IPersonRepository
    {
        public EFPersonRepository(EFContext context) : base(context){}

        public Person GetPersonWithHighestKontostand()
        {
            return context.Person.OrderByDescending(x => x.Kontostand).First();
        }
    }
}
