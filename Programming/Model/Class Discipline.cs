public class Discipline
{
    public string DisciplineName { get; set; }
    public int NumberOfHours { get; set; }
    private int _grade;

    public int Grade
    {
        get
        {
            return _grade;
        }
        set
        {
            if (value < 2 || value > 5)
            {
                throw new ArgumentException();
            }
            _grade = value;
        }
    }
}