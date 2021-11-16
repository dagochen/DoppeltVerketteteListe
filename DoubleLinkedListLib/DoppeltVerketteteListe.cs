namespace Listen.Library;
public class DoppeltVerketteteListe : Liste
{

    private Knoten Anfang { get; set; }
    private Knoten Ende { get; set; }

    public DoppeltVerketteteListe()
    {
        Anfang = new Knoten();
        Ende = new Knoten();
        Anfang.Nachfolger = Ende;
        Ende.Vorgaenger = Anfang;
    }

    public int Anzahl { get; set; } = 0;

    public bool IstLeer => true;

    public void EntferneElement(string element)
    {
        throw new NotImplementedException();
    }

    public void EntferneElement(int position)
    {
        throw new NotImplementedException();
    }

    public void Hinzufuegen(string element)
    {
       
        Knoten neuerKnoten = new Knoten();
        neuerKnoten.Inhalt = element;
        Anfang.Nachfolger = neuerKnoten;
        neuerKnoten.Vorgaenger = Anfang;

        neuerKnoten.Nachfolger = Ende;
        Ende.Vorgaenger = neuerKnoten;

        Anzahl++;
    }

    public void Hinzufuegen(string element, int position)
    {
        throw new NotImplementedException();
    }

    public string InhaltVonElementAnPosition(int position)
    {
        throw new NotImplementedException();
    }

    public bool IstElementEnthalten(string element)
    {
        throw new NotImplementedException();
    }

    public int PositionVon(string element)
    {
        throw new NotImplementedException();
    }

    public void AllesLoeschen()
    {
        throw new NotImplementedException();
    }
}
