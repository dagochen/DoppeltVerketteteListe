namespace Listen.Library;

public interface Liste
{
    public int Anzahl { get; set; }

    public void Hinzufuegen(string element);

    public void Hinzufuegen(string element, int position);

    public bool IstElementEnthalten(string element);

    public void EntferneElement(string element);
    public void EntferneElement(int position);

    public int PositionVon(string element);

    public string InhaltVonElementAnPosition(int position);

    public bool IstLeer { get; }

    public void AllesLoeschen();
}
