public class TriadNoteQuestion : IQuestionGenerator
{
    private readonly IChordBuilder _builder;

    public TriadNoteQuestion(IChordBuilder builder)
    {
        _builder = builder;
    }

    public MusicTheoryQuestion Generate()
    {
        var root = ChromaticScale.Notes[Random.Shared.Next(12)];

        var formulas = ChordFormulas.All
            .Where(f => f.Intervals.Length == 3)
            .ToList();

        var formula = formulas[Random.Shared.Next(formulas.Count)];

        var chord = _builder.Build(root, formula);

        int index = Random.Shared.Next(chord.Notes.Count);

        string[] degrees = { "root", "3rd", "5th" };

        return new MusicTheoryQuestion
        {
            QuestionText =
                $"What is the {degrees[index]} of {root} {formula.Name}?",
            Answer = chord.Notes[index]
        };
    }
}