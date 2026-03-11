public class FifthToThirdQuestion : IQuestionGenerator
{
    public MusicTheoryQuestion Generate()
    {
        var note = ChromaticScale.Notes[Random.Shared.Next(12)];

        var fifthIntervals = new Dictionary<string,int>
        {
            {"Major",7},
            {"Minor",7},
            {"Diminished",6},
            {"Augmented",8}
        };

        var type = fifthIntervals.Keys.ElementAt(Random.Shared.Next(4));
        var root = IntervalHelper.MoveDown(note, fifthIntervals[type]);

        var third = IntervalHelper.Move(root,
            type switch
            {
                "Major" => 4,
                "Minor" => 3,
                "Diminished" => 3,
                "Augmented" => 4
            });

        return new MusicTheoryQuestion
        {
            QuestionText = $"If {note} is the 5th of a {type} triad, what is the 3rd?",
            Answer = third
        };
    }
}