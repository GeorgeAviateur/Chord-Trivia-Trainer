public static class IntervalHelper
{
    public static string Move(string note, int semitones)
    {
        int index = Array.IndexOf(ChromaticScale.Notes, note);
        return ChromaticScale.Notes[(index + semitones + 12) % 12];
    }

    public static string MoveDown(string note, int semitones)
    {
        return Move(note, -semitones);
    }
}