using NUnit.Framework;
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

    }
}
