public class ThirdToFifthQuestion : IQuestionGenerator
{
    public MusicTheoryQuestion Generate()
    {
        var note = ChromaticScale.Notes[Random.Shared.Next(12)];

        var formulas = new Dictionary<string,int>
        {
            {"Major",4},
            {"Minor",3},
            {"Diminished",3},
            {"Augmented",4}
        };

        var type = formulas.Keys.ElementAt(Random.Shared.Next(formulas.Count));
        var interval = formulas[type];

        var root = IntervalHelper.MoveDown(note, interval);
        var fifth = IntervalHelper.Move(root,
            type switch
            {
                "Major" => 7,
                "Minor" => 7,
                "Diminished" => 6,
                "Augmented" => 8
            });

        return new MusicTheoryQuestion
        {
            QuestionText = $"If {note} is the 3rd of a {type} triad, what is the 5th?",
            Answer = fifth
        };
    }
}