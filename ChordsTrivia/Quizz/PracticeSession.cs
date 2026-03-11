public class PracticeSession
{

    private readonly GuitarTriadGenerator _generator;

    public int DisplaySeconds = 14;

    public PracticeSession(GuitarTriadGenerator generator)
    {
        _generator = generator;
    }

    public async Task Start()
    {
        while (true)
        {
            var instruction = _generator.Generate();

            Console.Clear();
            Console.WriteLine(instruction);

            await Task.Delay(DisplaySeconds * 1000);

            Console.Clear();
        }
    }
}