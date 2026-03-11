public class ReverseTriadQuestion : IQuestionGenerator
{
    private readonly IChordBuilder _builder;

    public ReverseTriadQuestion(IChordBuilder builder)
    {
        _builder = builder;
    }

    public MusicTheoryQuestion Generate()
    {
        var formula = ChordFormulas.All
            .Where(f => f.Intervals.Length == 3)
            .OrderBy(_ => Random.Shared.Next())
            .First();

        var root = ChromaticScale.Notes[Random.Shared.Next(12)];

        var chord = _builder.Build(root, formula);

        int index = Random.Shared.Next(1, chord.Notes.Count); // 3rd or 5th

        return new MusicTheoryQuestion
        {
            QuestionText =
                $"{chord.Notes[index]} is the {(index == 1 ? "3rd" : "5th")} of what {formula.Name} triad?",
            Answer = root
        };
    }
}