public class ChordBuilder : IChordBuilder
{
    public Chord Build(string root, ChordFormula formula)
    {
        int rootIndex = Array.IndexOf(ChromaticScale.Notes, root);

        var notes = formula.Intervals
            .Select(i => ChromaticScale.Notes[(rootIndex + i) % 12])
            .ToList();

        return new Chord(root, formula, notes);
    }
}