namespace Listen.Library;


    public class Knoten
{
    public Knoten Vorgaenger { get; set; }

    public Knoten Nachfolger { get; set; }

    public string Inhalt { get; set; }

    public Knoten()
    {
        this.Vorgaenger = null!;
        this.Nachfolger = null!;
        this.Inhalt = "";
    }
    public Knoten(Knoten vorgaenger, Knoten nachfolger, String inhalt)
    {
        this.Vorgaenger = vorgaenger;
        this.Nachfolger = nachfolger;
        this.Inhalt = inhalt;
    }
}
