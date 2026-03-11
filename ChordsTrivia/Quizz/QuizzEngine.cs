public class QuizEngine
{
    private readonly List<IQuestionGenerator> _generators;

    public QuizEngine(List<IQuestionGenerator> generators)
    {
        _generators = generators;
    }

    public MusicTheoryQuestion Generate()
    {
        var generator = _generators[
            Random.Shared.Next(_generators.Count)
        ];

        return generator.Generate();
    }
}