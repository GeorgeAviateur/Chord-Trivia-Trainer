public class PlayChordInstruction
{
    public string Root { get; set; }
    public string Quality { get; set; }
    public Inversion Inversion { get; set; }
    public int String { get; set; }

    public override string ToString()
    {
        string inversionText = Inversion switch
        {
            Inversion.Root => Root,
            Inversion.First => $"{Root}/{GetThird()}",
            Inversion.Second => $"{Root}/{GetFifth()}",
            _ => Root
        };

        return $"Play: {inversionText} {Quality} on string {String}";
    }

    private string GetThird()
    {
        return IntervalHelper.Move(Root,
            Quality == "Major" || Quality == "Augmented" ? 4 : 3);
    }

    private string GetFifth()
    {
        return IntervalHelper.Move(Root,
            Quality switch
            {
                "Major" => 7,
                "Minor" => 7,
                "Diminished" => 6,
                "Augmented" => 8,
                _ => 7
            });
    }
}