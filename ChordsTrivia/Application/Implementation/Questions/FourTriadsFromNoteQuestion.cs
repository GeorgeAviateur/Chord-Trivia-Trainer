public class FourTriadsFromNoteQuestion : IQuestionGenerator
{
    public MusicTheoryQuestion Generate()
    {
        var note = ChromaticScale.Notes[Random.Shared.Next(12)];
        bool third = Random.Shared.Next(2) == 0;

        Dictionary<string,int> intervals = third
            ? new()
            {
                {"Major",4},
                {"Minor",3},
                {"Diminished",3},
                {"Augmented",4}
            }
            : new()
            {
                {"Major",7},
                {"Minor",7},
                {"Diminished",6},
                {"Augmented",8}
            };

        var answers = intervals
            .Select(k => $"{IntervalHelper.MoveDown(note,k.Value)} {k.Key}")
            .ToList();

        return new MusicTheoryQuestion
        {
            QuestionText = $"Name the four triads of which {note} is the {(third ? "3rd" : "5th")}.",
            Answer = string.Join(", ", answers)
        };
    }
}