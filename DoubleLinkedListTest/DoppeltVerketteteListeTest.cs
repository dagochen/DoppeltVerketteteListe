using Listen.Library;
using Shouldly;
using Xunit;

namespace DoppeltVerketteteListeTest
{
    public class DoppeltVerketteteListeTest
    {

        Liste testListe = new DoppeltVerketteteListe();

        [Fact]
        public void NeuErstellteListeIstLeer()
        {
            testListe.Anzahl.ShouldBe(0);
            testListe.IstLeer.ShouldBeTrue();
        }

        [Fact]
        public void HinzufuegenZurListe()
        {
            testListe.Hinzufuegen("Hallo Welt");

            testListe.Anzahl.ShouldBe(1);
            testListe.IstLeer.ShouldBeFalse();
            testListe.IstElementEnthalten("Hallo Welt").ShouldBeTrue();
        }

        [Fact]
        public void HinzufuegenAnBestimmterPosition()
        {
            testListe.Hinzufuegen("Hallo");

            testListe.Hinzufuegen("Welt", 0);

            testListe.Anzahl.ShouldBe(2);
            testListe.IstLeer.ShouldBeFalse();
            testListe.IstElementEnthalten("Hallo").ShouldBeTrue();
            testListe.IstElementEnthalten("Welt").ShouldBeTrue();
            testListe.PositionVon("Hallo").ShouldBe(1);
            testListe.PositionVon("Welt").ShouldBe(0);
            testListe.InhaltVonElementAnPosition(1).ShouldBe("Hallo");
            testListe.InhaltVonElementAnPosition(0).ShouldBe("Welt");

        }

        [Fact]
        public void IstEnthaltenOderNichtEnthalten()
        {
            testListe.Hinzufuegen("Hallo Welt");

            testListe.IstElementEnthalten("Hallo Welt").ShouldBeTrue();
            testListe.IstElementEnthalten("Welt, Hallo").ShouldBeFalse();
        }

        [Fact]
        public void StringHinzufuegenUndLoeschen()
        {
            testListe.Hinzufuegen("Hallo Welt");
            testListe.Anzahl.ShouldBe(1);
            testListe.IstLeer.ShouldBeFalse();
            testListe.IstElementEnthalten("Hallo Welt").ShouldBeTrue();

            testListe.EntferneElement("Hallo Welt");
            testListe.Anzahl.ShouldBe(0);
            testListe.IstLeer.ShouldBeTrue();
        }
        [Fact]
        public void ElementHinzufuegenUndLoeschen()
        {
            testListe.Hinzufuegen("Hallo Welt");
            testListe.Anzahl.ShouldBe(1);
            testListe.IstLeer.ShouldBeFalse();
            testListe.IstElementEnthalten("Hallo Welt").ShouldBeTrue();

            testListe.EntferneElement(0);
            testListe.Anzahl.ShouldBe(0);
            testListe.IstLeer.ShouldBeTrue();
        }

        [Fact]
        public void MehrereHinzufuegenUndLoeschen()
        {
            testListe.Hinzufuegen("Hallo Welt");
            testListe.Anzahl.ShouldBe(1);
            testListe.IstLeer.ShouldBeFalse();
            testListe.IstElementEnthalten("Hallo Welt").ShouldBeTrue();
            testListe.InhaltVonElementAnPosition(0).ShouldBe("Hallo Welt");

            testListe.Hinzufuegen("Foo", 1);
            testListe.Hinzufuegen("Bar", 1);
            testListe.InhaltVonElementAnPosition(1).ShouldBe("Bar");
            testListe.InhaltVonElementAnPosition(2).ShouldBe("Foo");
            testListe.Anzahl.ShouldBe(3);

            testListe.EntferneElement("Hallo Welt");
            testListe.Anzahl.ShouldBe(2);
            testListe.IstLeer.ShouldBeFalse();

            testListe.EntferneElement(0);
            testListe.IstElementEnthalten("Hallo Welt").ShouldBeFalse();
            testListe.IstElementEnthalten("Bar").ShouldBeFalse();
            testListe.IstElementEnthalten("Foo").ShouldBeTrue();
        }

        [Fact]
        public void AllesLoeschen()
        {
            testListe.Hinzufuegen("Hallo Welt");
            testListe.Hinzufuegen("Hallo Welt2");
            testListe.Hinzufuegen("Hallo Welt3");
            testListe.Anzahl.ShouldBe(3);
            testListe.AllesLoeschen();
            testListe.IstLeer.ShouldBeTrue();
            testListe.Anzahl.ShouldBe(0);
        }
    }
}