public class GuitarTriadGenerator
{
    private static readonly string[] Qualities =
    {
        "Major","Minor","Diminished","Augmented"
    };

    public PlayChordInstruction Generate()
    {
        var root = ChromaticScale.Notes[Random.Shared.Next(12)];
        var quality = Qualities[Random.Shared.Next(Qualities.Length)];
        var inversion = (Inversion)Random.Shared.Next(3);
        var guitarString = GuitarStrings.Available[
            Random.Shared.Next(GuitarStrings.Available.Length)
        ];

        return new PlayChordInstruction
        {
            Root = root,
            Quality = quality,
            Inversion = inversion,
            String = guitarString
        };
    }
}