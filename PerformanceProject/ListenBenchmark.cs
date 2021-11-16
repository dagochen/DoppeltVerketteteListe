
using BenchmarkDotNet.Attributes;
using Listen.Library;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class ListenBenchmark
{

    private static readonly Liste linkedList = new DoppeltVerketteteListe();
    private static readonly Liste arrayList = new ArrayListe();

    [Params(10, 1000, 10000)]
    public int Size { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        for (int i = 0; i < Size; i++)
        {
            linkedList.Hinzufuegen("prepare" + i);
            arrayList.Hinzufuegen("prepare" + i);
        }
    }

    [Benchmark]
    public void HintenHinzufuegenBenchmark()
    {
        // 1000 Einträge erstellen
        for (int i = 0; i < 1000; i++)
        {
            linkedList.Hinzufuegen("hinten" + i);
        }
    }

    [Benchmark]
    public void HintenHinzufuegenArrayListBenchmark()
    {
        // 1000 Einträge erstellen
        for (int i = 0; i < 1000; i++)
        {
            arrayList.Hinzufuegen("hinten" + i);
        }
    }

    [Benchmark]
    public void MitteHinzufuegenLinkedListBenchmark()
    {
        
        for (int i = linkedList.Anzahl / 2; i < (linkedList.Anzahl / 2) + 100; i++)
        {
            linkedList.Hinzufuegen("mitte" + i, 0 + i);
        }
    }

    [Benchmark]
    public void VornHinzufuegenLinkedListBenchmark()
    {
        // 100 vorne hinzufügen
        for (int i = 0; i < 100; i++)
        {
            linkedList.Hinzufuegen("vorne" + i, 0);
        }
    }


    [Benchmark]
    public void MitteHinzufuegenArrayListBenchmark()
    {

        for (int i = linkedList.Anzahl / 2; i < (linkedList.Anzahl / 2) + 100; i++)
        {
            arrayList.Hinzufuegen("mitte" + i, 0 + i);
        }
    }

    [Benchmark]
    public void VornHinzufuegenArrayListBenchmark()
    {
        // 100 vorne hinzufügen
        for (int i = 0; i < 100; i++)
        {
            arrayList.Hinzufuegen("vorne" + i, 0);
        }
    }

}