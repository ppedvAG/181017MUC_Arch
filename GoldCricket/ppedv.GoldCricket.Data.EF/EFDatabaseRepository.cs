using ppedv.GoldCricket.Domain;
using ppedv.GoldCricket.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ppedv.GoldCricket.Data.EF
{
    public class EFDatabaseRepository : EFUniversalRepository<Database>, IDatabaseRepository
    {
        public EFDatabaseRepository(EFContext context) : base(context){}

        public IEnumerable<Application> GetAllApplicationsThatUseThisDB(Database database)
        {
            //return context.Application.Where(x => x.Databases.Contains(database)).ToList();

            // Alternativschreibweise:
            var query = from app in context.Application
                        where app.Databases.Contains(database)
                        select app;
            return query.ToList();
        }
    }
}
