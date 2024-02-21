public class Song
{
    public string Name { get; set; }
    public string Executor { get; set; }
    public int DurationMinute { get; set; }

    public Song(string name, string executor, int durationMinute)
    {
        Name = name;
        Executor = executor;
        DurationMinute = durationMinute;
    }
}
