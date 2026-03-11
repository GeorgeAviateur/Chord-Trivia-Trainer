public class Menu
{
    public void Start()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== Main Menu ====");
            Console.WriteLine("1. Trivia");
            Console.WriteLine("2. Play the chord");
            Console.WriteLine("q. Quit");

            var input = Console.ReadLine()?.Trim().ToLower();

            if (input == "q")
                return;

            switch (input)
            {
                case "1":
                    RunTrivia();
                    break;

                case "2":
                    RunPlayChordMenu();
                    break;
            }
        }
    }

private List<ChordMode> ParseModes(string input)
    {
        var modes = new List<ChordMode>();

        var parts = input.Split(',');

        foreach (var part in parts)
        {
            if (int.TryParse(part.Trim(), out int value))
            {
                if (Enum.IsDefined(typeof(ChordMode), value))
                {
                    modes.Add((ChordMode)value);
                }
            }
        }

        return modes;
    }

private void RunPlayChordMenu()
    {
        Console.Clear();

        Console.WriteLine("Select chord types (comma separated):");
        Console.WriteLine("1. Triads");
        Console.WriteLine("2. 7th chords");
        Console.WriteLine("3. 9th chords");
        Console.WriteLine("4. 13th chords");
        Console.WriteLine("Example: 1,2");
        Console.WriteLine("Press q to return");

        var input = Console.ReadLine()?.Trim().ToLower();

        if (input == "q")
            return;

        var selectedModes = ParseModes(input);

        StartPractice(selectedModes);
    }

  public void RunTrivia()
    {
        Console.Clear();

        Console.WriteLine("Trivia mode started.");
        Console.WriteLine("Press any key to return.");

        var builder = new ChordBuilder();
        var inverter = new ChordInverter();

        var generators = new List<IQuestionGenerator>
        {
            new TriadNoteQuestion(builder),
            new ReverseTriadQuestion(builder),
            new FifthToThirdQuestion(),
            new FourTriadsFromNoteQuestion(),
            new InversionPositionQuestion(builder, inverter),
            new ThirdToFifthQuestion(),
        };

        var engine = new QuizEngine(generators);

        var question = engine.Generate();

        Console.WriteLine(question.QuestionText);
        Console.ReadLine();
        Console.WriteLine($"Answer: {question.Answer}");
Console.Read();
    }

 public void StartPractice(List<ChordMode> modes)
    {
        Console.Clear();

        Console.WriteLine("Starting practice mode...");
        Console.WriteLine($"Chord types: {string.Join(", ", modes)}");
        Console.WriteLine("Press any key to stop.");

        var builder = new ChordBuilder();
        var generator = new GuitarTriadGenerator();

        var session = new PracticeSession(generator);

        Task.Run(async () => await session.Start());

        Console.Read();
    }

    }