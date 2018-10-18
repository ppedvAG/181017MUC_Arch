using ppedv.GoldCricket.Domain;
using ppedv.GoldCricket.Domain.Interfaces;
using System;

namespace ppedv.GoldCricket.Logic
{
    public class Core // Programmkern
    {
        public Core(IRepository repository)
        {
            Repository = repository;
        }

        public IRepository Repository { get; set; }

        // Logik, die irgendwas mit dem Repository macht ...
        public void CreateDemoData()
        {
            Person p1 = new Person { Vorname = "Tom", Nachname = "Ate", Alter = 10, Kontostand = 10000 };
            Person p2 = new Person { Vorname = "Anna", Nachname = "Nass", Alter = 20, Kontostand = 20000 };
            Person p3 = new Person { Vorname = "Peter", Nachname = "Silie", Alter = 30, Kontostand = 33000 };
            Person p4 = new Person { Vorname = "Franz", Nachname = "Ose", Alter = 40, Kontostand = -444 };
            Person p5 = new Person { Vorname = "Martha", Nachname = "Pfahl", Alter = 50, Kontostand = 555 };

            Database d1 = new Database { Name = "Azure Cloud", Location="Überall" };
            Database d2 = new Database { Name = "LocalDB mit EF", Location="Auf meinem Rechner..." };
            Database d3 = new Database { Name = "SQL Server", Location="Zimmer 501, Stock 12 hinter dem Besenkammerl" };
            Database d4 = new Database { Name = "Das eine komische XML-File aufm Desktop", Location="Desktop" };

            Application a1 = new Application
            {
                Name = "Microsoft Paint",
                ApplicationType = ApplicationType.Desktop,
                Owner = p1,
                Started = DateTime.Now,
            };
            a1.Databases.Add(d1);
            a1.Databases.Add(d2);

            Application a2 = new Application
            {
                Name = "Visual Studio 2017 Enterprise Edition",
                ApplicationType = ApplicationType.Desktop,
                Owner = p2,
                Started = new DateTime(2017,6,12,12,45,33)
            };
            a2.Databases.Add(d2);
            a2.Databases.Add(d4);

            Application a3 = new Application
            {
                Name = "Kantinenplan",
                ApplicationType = ApplicationType.Web,
                Owner = p3,
                Started = new DateTime(2000, 6, 1, 12, 00, 00)
            };
            a3.Databases.Add(d1);
            a3.Databases.Add(d2);
            a3.Databases.Add(d3);
            a3.Databases.Add(d4);

            Application a4 = new Application
            {
                Name = "Google Maps",
                ApplicationType = ApplicationType.Mobile,
                Owner = p4,
                Started = new DateTime(1995, 5, 5, 12, 00, 59)
            };
            a4.Databases.Add(d1);

            Application a5 = new Application
            {
                Name = "SAP Netweaver Middleware Deluxe Edtion",
                ApplicationType = ApplicationType.Service,
                Owner = p5,
                Started = new DateTime(1848, 3, 3, 6, 00, 12)
            };
            a4.Databases.Add(d4);


            Repository.Add(a1);
            Repository.Add(a2);
            Repository.Add(a3);
            Repository.Add(a4);
            Repository.Add(a5);
        }
    }
}
