public class QuestionGenerator
{
    private readonly IChordBuilder _builder;
    private readonly IChordInverter _inverter;

    public QuestionGenerator(IChordBuilder builder, IChordInverter inverter)
    {
        _builder = builder;
        _inverter = inverter;
    }

    public MusicTheoryQuestion GenerateQuestion()
    {
        var root = ChromaticScale.Notes[Random.Shared.Next(12)];
        var formula = ChordFormulas.All[Random.Shared.Next(ChordFormulas.All.Count)];

        var chord = _builder.Build(root, formula);

        int inversion = Random.Shared.Next(chord.Notes.Count);
        var inverted = _inverter.Invert(chord.Notes, inversion);

        int noteIndex = Random.Shared.Next(inverted.Count);

        return new MusicTheoryQuestion
        {
            QuestionText =
                $"What is note {noteIndex + 1} of {root} {formula.Name} in inversion {inversion}?",
            Answer = inverted[noteIndex]
        };
    }
}