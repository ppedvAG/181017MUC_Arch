using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloMVVM.Models
{
    class PersonenService
    {
        public List<Person> GetPersonen()
        {
            return new List<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=200},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=300},
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=400},
                new Person{Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=500},
                new Person{Vorname="Rainer",Nachname="Zufall",Alter=60,Kontostand=600},
                new Person{Vorname="Frank N",Nachname="Stein",Alter=70,Kontostand=700},
                new Person{Vorname="Anna",Nachname="Bolika",Alter=80,Kontostand=800},
                new Person{Vorname="Bill",Nachname="Dung",Alter=90,Kontostand=900},
                new Person{Vorname="Axel",Nachname="Schweiß",Alter=100,Kontostand=1000}
            };
        }
    }
}
