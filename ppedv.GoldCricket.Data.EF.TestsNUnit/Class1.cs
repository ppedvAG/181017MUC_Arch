using NUnit.Framework;
using ppedv.GoldCricket.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppedv.GoldCricket.Data.EF.TestsNUnit
{
    [TestFixture] // mstest: TestClass
    public class EFContextTests
    {

        //public void klassenname_methodenname_ausgangsituation_erwartetesErgebnis
        [Test] // mstest: TestMethod, Xunit: Fact
        public void EFContext_Can_Create_Instance()
        {
            // AAA - Prinzip

            // Arrange -> Initialisieren
            // Act     -> Ausführen
            // Assert  -> Ergebnis interpretieren

            EFContext ctx = new EFContext();
            Assert.IsNotNull(ctx);
        }

        [Test]
        public void EFContext_Can_Create_DB()
        {
            EFContext ctx = new EFContext();

            if (ctx.Database.Exists())
                ctx.Database.Delete();

            Assert.IsFalse(ctx.Database.Exists()); // Clean-Zustand: keine DB

            ctx.Database.Create();
            Assert.IsTrue(ctx.Database.Exists()); // DB muss jetzt da sein !
        }

        [Test]
        public void EFContext_Can_CRUD_Person() // Create, Read, Update, Delete
        {
            Person p = new Person { Vorname = "Franz", Nachname = "Ose", Alter = 30, Kontostand = 2000m };
            string neuerNachname = "Osinger";

            // Create
            using (EFContext ctx = new EFContext())
            {
                ctx.Person.Add(p); // Insert in Person-Tabelle
                ctx.SaveChanges(); // Ab hier hat p auch eine ID !
            }

            using (EFContext ctx = new EFContext())
            {
                var geladenePerson = ctx.Person.Find(p.ID);
                Assert.IsNotNull(geladenePerson);
                Assert.AreEqual(p.Nachname, geladenePerson.Nachname); // Read

                //Update
                geladenePerson.Nachname = neuerNachname;
                ctx.SaveChanges(); // UPDATE -> Person hat sich verändert -> Änderung in DB nachtragen
            }

            using (EFContext ctx = new EFContext())
            {
                var geladenePerson = ctx.Person.Find(p.ID); // neu laden, da wir die Person nicht aus dem Cache haben wollen !!!
                Assert.IsNotNull(geladenePerson);
                Assert.AreEqual(neuerNachname, geladenePerson.Nachname); // Update-Test

                //Delete
                ctx.Person.Remove(geladenePerson);
                ctx.SaveChanges();
            }

            using (EFContext ctx = new EFContext())
            {
                var geladenePerson = ctx.Person.Find(p.ID); // Person existiert nicht -> NULL
                Assert.IsNull(geladenePerson);
            }
        }
    }
}
