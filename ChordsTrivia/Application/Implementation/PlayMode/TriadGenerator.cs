public class TriadGenerator
{
    private readonly IChordBuilder _builder;

    public TriadGenerator(IChordBuilder builder)
    {
        _builder = builder;
    }

    public Chord Generate()
    {
        var root = ChromaticScale.Notes[Random.Shared.Next(12)];

        var triads = ChordFormulas.All
            .Where(f => f.Intervals.Length == 3)
            .ToList();

        var formula = triads[Random.Shared.Next(triads.Count)];

        return _builder.Build(root, formula);
    }
}