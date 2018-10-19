using System.Collections.Generic;

namespace ppedv.GoldCricket.Domain.Interfaces
{
    public interface IDatabaseRepository : IUniversalRepository<Database>
    {
        IEnumerable<Application> GetAllApplicationsThatUseThisDB(Database database);
    }
}
