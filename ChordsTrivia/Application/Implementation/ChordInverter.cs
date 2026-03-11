public class ChordInverter : IChordInverter
{
    public List<string> Invert(List<string> chord, int inversion)
    {
        var result = new List<string>(chord);

        for(int i = 0; i < inversion; i++)
        {
            var first = result[0];
            result.RemoveAt(0);
            result.Add(first);
        }

        return result;
    }
}