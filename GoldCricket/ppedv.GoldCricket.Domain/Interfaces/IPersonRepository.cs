namespace ppedv.GoldCricket.Domain.Interfaces
{
    // Definiert alle Features, die zusätzlich zu den "Standardfeatures" implementiert werden müssen
    public interface IPersonRepository : IUniversalRepository<Person>
    {
        Person GetPersonWithHighestKontostand();
    }
}
