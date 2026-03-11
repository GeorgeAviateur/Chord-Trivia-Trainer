public class InversionPositionQuestion : IQuestionGenerator
{
    private readonly IChordBuilder _builder;
    private readonly IChordInverter _inverter;

    public InversionPositionQuestion(IChordBuilder builder, IChordInverter inverter)
    {
        _builder = builder;
        _inverter = inverter;
    }

    public MusicTheoryQuestion Generate()
    {
        var root = ChromaticScale.Notes[Random.Shared.Next(12)];
        var formula = ChordFormulas.All.Where(x => x.Intervals.Length == 3)
                                       .OrderBy(_ => Random.Shared.Next())
                                       .First();

        var chord = _builder.Build(root, formula);

        int inversion = Random.Shared.Next(3);

        var inverted = _inverter.Invert(chord.Notes, inversion);

        string[] positions = {"bottom","middle","top"};

        int givenIndex = Random.Shared.Next(3);
        int askedIndex = Random.Shared.Next(3);

        return new MusicTheoryQuestion
        {
            QuestionText =
                $"If {inverted[givenIndex]} is the {positions[givenIndex]} note of a {formula.Name} triad in {inversion} inversion, what is the {positions[askedIndex]} note?",
            Answer = inverted[askedIndex]
        };
    }
}