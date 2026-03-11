public class ChordFormula
{
    public string Name { get; }
    public int[] Intervals { get; }

    public ChordFormula(string name, int[] intervals)
    {
        Name = name;
        Intervals = intervals;
    }
}