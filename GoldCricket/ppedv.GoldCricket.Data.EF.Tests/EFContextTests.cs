using NUnit.Framework;
using System;

namespace ppedv.GoldCricket.Data.EF.Tests
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

        public void EFContext_Can_Create_DB()
        {

        }

    }
}
