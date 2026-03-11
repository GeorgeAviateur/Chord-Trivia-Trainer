public class Chord
{
    public string Root { get; }
    public ChordFormula Formula { get; }
    public List<string> Notes { get; }

    public Chord(string root, ChordFormula formula, List<string> notes)
    {
        Root = root;
        Formula = formula;
        Notes = notes;
    }
}